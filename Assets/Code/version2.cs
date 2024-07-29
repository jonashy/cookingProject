using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class version2 : MonoBehaviour
{
    // To add a new Cookbook you need to add a new entry in the enum Books below and
    // go to unity inside canvas -> BookDropDown and add a new entry in options in the
    // inspector with the same name that is added in the enum below.

    enum Books
    {
        All = 0,
        EWB = 1,
        CBC = 2,
        HPBC = 3,
    }

    class AskIngredient
    {
        public string Name;
        public int Occurrences;
    }

    List<AskIngredient> _askIngredients = new List<AskIngredient>();


    List<string> _allIngredients = new List<string>();
    Dictionary<string, List<string>> _ingredients = new Dictionary<string, List<string>>();
    Dictionary<string, List<string>> _recipes = new Dictionary<string, List<string>>();

    List<string> _curIngredients = new List<string>();
    KeyValuePair<string, List<string>> _curRecipe;
    string _curBook;
    List<KeyValuePair<string, List<string>>> _curRecipes = new List<KeyValuePair<string, List<string>>>();


    [SerializeField]
    TMP_Dropdown _bookDropdown;
    [SerializeField]
    TMP_InputField _searchBox;
    [SerializeField]
    Button _ingredientButton;
    [SerializeField]
    GameObject _ingredientSuggestionBtnPrefab;
    [SerializeField]
    GameObject _ingredientBtnPrefab;

    [SerializeField]
    TMP_Text _askIngredientBtn;

    #region Panels
    [SerializeField]
    GameObject _ingredientSuggestionPanel;
    [SerializeField]
    GameObject _pantryPanel;
    [SerializeField]
    GameObject _missingIngredientsByRecipePanel;
    [SerializeField]
    GameObject _availableRecipesPanel;
    [SerializeField]
    GameObject _missingIngredientsPanel;
    #endregion

    private int _curIndex;


    // Start is called before the first frame update
    void Start()
    {
        var ta = Resources.Load<TextAsset>("Ingredients");
        var text = ta.text;
        var lines = text.Split('\n');
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i].Trim();
            var values = line.Split('_');
            if (values.Length == 2)
            {
                var type = values[0].Trim();
                var ingredient = values[1].Trim();

                if (_ingredients.ContainsKey(type))
                {
                    _ingredients[type].Add(ingredient);
                    _allIngredients.Add(ingredient);
                    print("adding: " + ingredient);
                }
                else
                {
                    _ingredients.Add(type, new List<string> { ingredient });
                    _allIngredients.Add(ingredient);
                    print("adding: " + ingredient);
                }
            }
        }

        ta = Resources.Load<TextAsset>("Recipes");
        text = ta.text;
        lines = text.Split('\n');
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i].Trim();
            var values = line.Split('_');
            if (values.Length == 2)
            {
                var receipe = values[0].Trim();
                var ingredientsStr = values[1].Trim();
                var ingredients = ingredientsStr.Split(',');

                for (var j = 0; j < ingredients.Length; j++)
                {
                    var ingredient = ingredients[j].Trim();

                    if (_recipes.ContainsKey(receipe))
                    {
                        if (_recipes[receipe].Contains(ingredient))
                        {
                            Debug.LogWarning("Duplicate ingredient: " + ingredient + " on receipe: " + receipe + " -- line: " + (i + 1));
                        }
                        else
                        {
                            if (_allIngredients.FirstOrDefault(stringToCheck => stringToCheck.Contains(ingredient)) == null)
                            {
                                Debug.LogError("Ingredient " + ingredient + " not found! Receipe: " + receipe + " -- line: " + (i + 1));
                            }

                            _recipes[receipe].Add(ingredient);
                        }
                    }
                    else
                    {
                        if (_allIngredients.FirstOrDefault(stringToCheck => stringToCheck.Contains(ingredient)) == null)
                        {
                            Debug.LogError("Ingredient " + ingredient + " not found! Receipe: " + receipe + " -- line: " + (i + 1));
                        }

                        _recipes.Add(receipe, new List<string> { ingredient });
                    }
                }
            }
        }

        print("ingredients: " + _allIngredients.Count);
        print("receipes: " + _recipes.Count);
    }

    public void OnSearchBoxInputChange(string newText)
    {
        var value = _searchBox.text;
        print("value: " + value);

        RemoveAllItemsFromGameObject(_ingredientSuggestionPanel);

        foreach (var ingredient in _allIngredients)
        {
            print(ingredient + " -- " + value + "======" + (ingredient.Equals(value)));
            if (value.Length >= 3 && ingredient.ToLowerInvariant().Contains(value))
            {
                AddIngredientSuggesionToIngredientSuggestionPanel(ingredient);
            }
        }
    }

    private void AddIngredientSuggesionToIngredientSuggestionPanel(string ingredient)
    {
        var go = Instantiate(_ingredientSuggestionBtnPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponentInChildren<TextMeshProUGUI>().text = ingredient;
        go.transform.SetParent(_ingredientSuggestionPanel.transform);
        go.GetComponentInChildren<RectTransform>().position = Vector3.zero;
        go.GetComponentInChildren<Button>().onClick.AddListener(() =>
        {
            AddIngredientToPantryPanel(ingredient);
        });
    }

    private void AddIngredientToMissingIngredientsPanel(string ingredient)
    {
        var go = Instantiate(_ingredientBtnPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponentInChildren<TextMeshProUGUI>().text = ingredient;
        go.transform.SetParent(_missingIngredientsPanel.transform);
        go.GetComponentInChildren<RectTransform>().position = Vector3.zero;
        go.GetComponentInChildren<Button>().onClick.AddListener(() =>
        {
            DestroyImmediate(go);

            AddIngredientToPantryPanel(ingredient);
        });
    }

    private void AddRecipeToAvailableRecipesPanel(KeyValuePair<string, List<string>> recipe)
    {
        var go = Instantiate(_ingredientBtnPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponentInChildren<Button>().onClick.AddListener(() =>
        {
            RemoveAllItemsFromGameObject(_missingIngredientsPanel);

            // Find missing ingredients from current recipe
            _curRecipe = recipe;
            
            var missingList = recipe.Value.Where(i => !_curIngredients.Contains(i)).ToList();
            foreach(var ingredient in missingList)
            {
                AddIngredientToMissingIngredientsPanel(ingredient);
            }
        });
        go.GetComponentInChildren<TextMeshProUGUI>().text = recipe.Key;
        go.transform.SetParent(_availableRecipesPanel.transform);
        go.GetComponentInChildren<RectTransform>().position = Vector3.zero;
    }

    public void OnAddToPantryButtonClick()
    {
        AddIngredientToPantryPanel(_searchBox.text);
    }

    private void AddIngredientToPantryPanel(string ingredient)
    {
        if (_curIngredients.Contains(ingredient))
        {
            return;
        }

        var go = Instantiate(_ingredientBtnPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponentInChildren<TextMeshProUGUI>().text = ingredient;
        go.transform.SetParent(_pantryPanel.transform);
        go.GetComponentInChildren<RectTransform>().position = Vector3.zero;
        go.GetComponentInChildren<Button>().onClick.AddListener(() =>
        {
            _curIngredients.Remove(ingredient);
            DestroyImmediate(go);
            UpdateListOfRecipes();
            RemoveAllItemsFromGameObject(_missingIngredientsPanel);
        });

        _curIngredients.Add(ingredient);

        UpdateListOfRecipes();
    }

    private void UpdateListOfRecipes()
    {
        // Find recipes that match all the ingredients in the pantry
        _curRecipes = _recipes.Where(v => {
            if (String.IsNullOrEmpty(_curBook) || _curBook == "All")
            {
                return _curIngredients.Count > 0 &&
                   v.Value.Intersect(_curIngredients).Count() == _curIngredients.Count;
            }

            return _curIngredients.Count > 0 && v.Key.Contains(_curBook) &&
               v.Value.Intersect(_curIngredients).Count() == _curIngredients.Count;
            }
        ).ToList();
        print("Found: " + _curRecipes.Count + " recipes!");
        RemoveAllItemsFromGameObject(_availableRecipesPanel);
        foreach (var recipe in _curRecipes)
        {
            AddRecipeToAvailableRecipesPanel(recipe);
        }

        if(_curRecipes.Count < 1)
        {
            RemoveAllItemsFromGameObject(_missingIngredientsPanel);
        }
        else
        {
            CalculateListOfIngredientsToAsk();
        }
    }

    private void RemoveAllItemsFromGameObject(GameObject go)
    {
        var t = go.transform;
        while(t.childCount > 0)
        {
            var child = t.GetChild(0);
            child.SetParent(null);
            DestroyImmediate(child.gameObject);
        }
    }

    public void OnBookDropDownChange()
    {
        _curBook = Enum.GetName(typeof(Books), _bookDropdown.value);
        UpdateListOfRecipes();
        RemoveAllItemsFromGameObject(_missingIngredientsPanel);
    }

    public void OnClearPantryButtonClick()
    {
        _curIngredients.Clear();
        _curIndex = 0;
        _curRecipes.Clear();
        RemoveAllItemsFromGameObject(_ingredientSuggestionPanel);
        RemoveAllItemsFromGameObject(_pantryPanel);
        RemoveAllItemsFromGameObject(_missingIngredientsByRecipePanel);
        RemoveAllItemsFromGameObject(_availableRecipesPanel);
        RemoveAllItemsFromGameObject(_missingIngredientsPanel);
        _askIngredientBtn.SetText("");
        OnSearchBoxInputChange("");
    }

    public void OnClearMissingIngredientsButtonClick()
    {
        RemoveAllItemsFromGameObject(_missingIngredientsPanel);
    }

    public void OnIngredientButtonClick()
    {
        AddIngredientToPantryPanel(_askIngredientBtn.text);
        OnSkipIngredientButtonClick();
    }

    public void OnSkipIngredientButtonClick()
    {
        _curIndex++;
        if (_curIndex >= _askIngredients.Count)
            _curIndex = 0;

        UpdateIngredientQuestion();
    }

    private void CalculateListOfIngredientsToAsk()
    {
        _askIngredients = new List<AskIngredient>();
        foreach(var recipe in _curRecipes)
        {
            print("Recipe: " + recipe.Value);
            foreach (var ingredient in recipe.Value)
            {
                var ingredientName = ingredient;
            print("Ingred: " + ingredientName);

                if (_curIngredients.Contains(ingredientName))
                    continue;

                var aiInd = _askIngredients.FindIndex(i => i.Name == recipe.Value[0]);
                if (aiInd >= 0)
                {
                    _askIngredients[aiInd].Occurrences++;
                }
                else
                {
                    _askIngredients.Add(new AskIngredient { Name = ingredientName, Occurrences = 1 });
                }
            }
        }

        //ingredients.OrderBy(ing => ing.Value);
        _askIngredients.OrderBy(ing => ing.Occurrences);

        UpdateIngredientQuestion();
    }

    private void UpdateIngredientQuestion()
    {
        _askIngredientBtn.SetText("");

        if (_curIndex < _askIngredients.Count)
        {
            _askIngredientBtn.SetText(_askIngredients[_curIndex].Name);
        }
    }
}
