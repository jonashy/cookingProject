using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class version2 : MonoBehaviour
{
    List<string> _allIngredients = new List<string>();
    Dictionary<string, List<string>> _ingredients = new Dictionary<string, List<string>>();
    Dictionary<string, List<string>> _receipes = new Dictionary<string, List<string>>();

    [SerializeField]
    TMP_InputField _searchBox;
    [SerializeField]
    Button _ingredientButton;
    [SerializeField]
    GameObject _ingredientBtnPrefab;

    [SerializeField]
    GameObject _pantryPanel;


    // Start is called before the first frame update
    void Start()
    {
        var ta = Resources.Load<TextAsset>("Ingredients");
        var text = ta.text;
        var lines = text.Split('\n');
        for(var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            var values = line.Split('_');
            if(values.Length == 2)
            {
                var type = values[0];
                var ingredient = values[1];

                if(_ingredients.ContainsKey(type))
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
            var line = lines[i];
            var values = line.Split('_');
            if (values.Length == 2)
            {
                var receipe = values[0];
                var ingredientsStr = values[1];
                var ingredients = ingredientsStr.Split(',');

                for (var j = 0; j < ingredients.Length; j++)
                {
                    var ingredient = ingredients[j];

                    if (_receipes.ContainsKey(receipe))
                    {
                        if(_receipes[receipe].Contains(ingredient))
                        {
                            Debug.LogWarning("Duplicate ingredient: " + ingredient + " on receipe: " + receipe + " -- line: " + (i + 1));
                        }
                        else
                        {
                            if (_allIngredients.FirstOrDefault(stringToCheck => stringToCheck.Contains(ingredient)) == null)
                            {
                                Debug.LogError("Ingredient " + ingredient + " not found! Receipe: " + receipe + " -- line: " + (i + 1));
                            }

                            _receipes[receipe].Add(ingredient);
                        }
                    }
                    else
                    {
                        if(_allIngredients.FirstOrDefault(stringToCheck => stringToCheck.Contains(ingredient)) == null)
                        {
                            Debug.LogError("Ingredient " + ingredient + " not found! Receipe: " + receipe + " -- line: " + (i + 1));
                        }

                        _receipes.Add(receipe, new List<string> { ingredient });
                    }
                }
            }
        }

        print("ingredients: " + _allIngredients.Count);
        print("receipes: " + _receipes.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSearchBoxInputChange(string newText)
    {
        var value = _searchBox.text;
        print("value: " + value);

        foreach(var key in _ingredients.Keys)
        {
            if(_ingredients[key].IndexOf(value) >= 0)
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

    public void OnAddToPantryButtonClick()
    {
        var go = Instantiate(_ingredientBtnPrefab, Vector3.zero, Quaternion.identity);
        go.GetComponentInChildren<TextMeshProUGUI>().text = _searchBox.text;
        go.GetComponent<RectTransform>().position = Vector3.zero;
        go.transform.parent = _pantryPanel.transform;
    }



}
