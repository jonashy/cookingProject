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
    enum Books
    {
        All = 0,
        EWB = 1,
        CBC = 2
    }

    List<string> _allIngredients = new List<string>();
    Dictionary<string, List<string>> _ingredients = new Dictionary<string, List<string>>();
    Dictionary<string, List<string>> _recipes = new Dictionary<string, List<string>>();

    List<string> _curIngredients = new List<string>();
    KeyValuePair<string, List<string>> _curRecipe;
    string _curBook;

    [SerializeField]
    TMP_Dropdown _bookDropdown;
    [SerializeField]
    TMP_InputField _searchBox;
    [SerializeField]
    Button _ingredientButton;
    [SerializeField]
    GameObject _ingredientBtnPrefab;

    #region Panels
    [SerializeField]
    GameObject _pantryPanel;
    [SerializeField]
    GameObject _availableRecipesPanel;
    [SerializeField]
    GameObject _missingIngredientsPanel;
    #endregion


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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSearchBoxInputChange(string newText)
    {
        var value = _searchBox.text;
        print("value: " + value);

        foreach(var ingredient in _allIngredients)
        {
            print(ingredient + " -- " + value + "======" + (ingredient.Equals(value)));
            if (ingredient.Equals(value))
            {
                _ingredientButton.gameObject.SetActive(true);
                _ingredientButton.GetComponentInChildren<TextMeshProUGUI>().text = value;
                print("Ingredient exists on list!!");
                return;
            }
        }

         _ingredientButton.gameObject.SetActive(false);
        print("Ingredient does NOT exist!!");

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
        var recipes = _recipes.Where(v => {
            if (String.IsNullOrEmpty(_curBook) || _curBook == "All")
            {
                return _curIngredients.Count > 0 &&
                   v.Value.Intersect(_curIngredients).Count() == _curIngredients.Count;
            }

            return _curIngredients.Count > 0 && v.Key.Contains(_curBook) &&
               v.Value.Intersect(_curIngredients).Count() == _curIngredients.Count;
            }
        ).ToList();
        print("Found: " + recipes.Count + " recipes!");
        RemoveAllItemsFromGameObject(_availableRecipesPanel);
        foreach (var recipe in recipes)
        {
            AddRecipeToAvailableRecipesPanel(recipe);
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

}
