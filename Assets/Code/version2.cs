using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class version2 : MonoBehaviour
{
    Dictionary<string, List<string>> _allIngredients = new Dictionary<string, List<string>>();
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
                var name = values[1];

                if(_allIngredients.ContainsKey(type))
                {
                    _allIngredients[type].Add(name);
                }
                else
                {
                    _allIngredients.Add(type, new List<string> { name });
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSearchBoxInputChange(string newText)
    {
        var value = _searchBox.text;
        print("value: " + value);

        foreach(var key in _allIngredients.Keys)
        {
            if(_allIngredients[key].IndexOf(value) >= 0)
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
