using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//make list in excel, make them all true
public class stringTesting : MonoBehaviour 
{
    public Text milk;
    
    public bool selectAllBool;

	public GameObject ButtonPrefab;
	public GameObject Parent;

    private string[] allItems = new string[]{
    //put indgredients here
//"____apples",
"____avocado",
//"____bananas",
//"____basil",
"____bellPeppers",
"____berries",
//"____broccoli",
//"____cabbage",
//"____canteloupe",
//"____carrot",
"____cauliflower",
//"____celery",
"____cherryTomatoes",
//"____chiliPepper",
"____cilantro",
"____corn",
//"____cucumbers",
//"____dill",
//"____eggplant",
"____freshHerbs",
"____garlic",
"____ginger",
//"____greenBeans",
//"____greenChili",
//"____greenOnions",
"____jalapenos",
//"____lemongrass",
"____lemons",
//"____lettuce",
"____limes",
//"____mango",
//"____mint",
"____mixedVeggies",
//"____mushrooms",
//"____onions",
//"____oranges",
//"____papaya",
//"____parsley",
//"____peaches",
//"____pears",
//"____pineapple",
//"____portobello",
//"____potatoes",
//"____radishes",
//"____raspberries",
//"____redOnions",
//"____saladGreens",
//"____shallots",
//"____snowPeas",
//"____spinach",
//"____squash",
//"____strawberries",
"____tomatoes",
//"____watermelon",
"____zucchini",
"___almondExtract",
"___almonds",
"___applesauce",
//"___apricotsDried",
//"___bakingPowder",
//"___bakingSoda",
"___basil",
//"___beanSprouts",
//"___berbereSpice",
"___blackOlives",
"___breadcrumbsWholeWheat",
"___breadWholeGrain",
"___brownRice",
"___brownSugar",
"___bunsHamburger",
"___canBlackBeans",
//"___canChickpeas",
//"___canCondensedMilk",
"___canCrushedTomatoes",
"___canDicedTomatoes",
//"___canFavaBeans",
"___canolaOil",
"___cardamom",
"___carribeanJerkSeasoning",
"___cayennePepper",
"___chiaSeeds",
"___chickenBroth",
//"___chickpeaFlour",
"___chiliFlakes",
"___chiliPowder",
"___cinnamon",
"___cloves",
"___cocoaPowder",
//"___coconutExtract",
//"___coconutFlakes",
//"___coconutMilk",
//"___coconutOil",
//"___coconutShredded",
"___coffee",
"___cookingSpray",
"___coriander",
"___cornstarch",
//"___cornTortillas",
"___couscous",
"___cumin",
"___darkChocolate",
//"___edamame",
"___fishSauce",
"___flaxseed",
"___flourAlmond",
//"___flourCoconut",
"___flourRice",
//"___flourSemolina",
"___flourWholeWheat",
"___freshFruit",
//"___garamMasala",
"___garlicPowder",
"___ginger",
//"___gingerGarlicPaste",
"___granulatedSweetener",
//"___greenChili",
//"___greenCurryPaste",
//"___hoisinSauce",
"___honey",
"___hotSauce",
"___iceCubes",
"___italianSeasoning",
"___jam",
"___kalamataOlives",
"___lentils",
//"___marinara",
//"___matchaGreenTeaPowder",
//"___mincedChiliPowder",
"___mincedGarlic",
"___mincedGinger",
"___mirin",
//"___misoPaste",
"___mustardSeeds",
//"___noriSheet",
"___nutmeg",
"___nuts",
"___oil",
"___oliveOil",
//"___orangeJuice",
"___oregano",
"___oysterSauce",
"___paprika",
//"___pasteRedBean",
"___peanutButter",
"___peanuts",
//"___pecans",
"___pepper",
//"___pieCrust".
"___pineNuts",
"___pistachios",
"___pitaWholeWheat",
"___powderedSugar",
//"___quincePaste",
"___quinoa",
//"___raisins",
"___redChiliPowder",
"___redPepperFlakes",
"___redWineVinegar",
//"___ricePaperWrappers",
"___riceVinegar",
"___rolledOats",
//"___ryeBread",
//"___saffron",
"___salsa",
"___salt",
"___sesameOil",
"___sesameSeeds",
"___skewers",
"___slicedJalapenos",
"___soySauce",
"___srirachaSauce",
"___sweetener",
"___syrupSugarFree",
//"___tahini",
//"___tahiniPaste",
//"___tandooriSpice",
//"___thaiRedCurryPaste",
"___thyme",
//"___tofu",
"___tomatoPaste",
//"___tortillasWheat",
//"___turmeric",
"___vanillaExtract",
"___vegBroth",
"___vegetableOil",
//"___vermicelliNoodles",
//"___walnuts",
"___water",
"___whiteRice",
//"___za'atarSpiceMix",
"__berriesFrozen",
"__cauliflowerRice",
//"__chicken",
//"__drumsticksChicken",
//"__edamameFrozen",
//"__falafalPattiesFrozen",
//"__fish",
//"__frozenAcaiPacket",
"__frozenPeas",
//"__frozenTropicalFruit",
"__iceCream",
//"__lamb",
//"__salmon",
"__sausage",
//"__seafood",
//"__shrimp",
//"__smokedSalmon",
//"__steak",
"__stirFryVeggies",
//"__thighsChicken",
//"__tunaWhole",
//"__turkeyGround",
//"__whiteFish",
"_almondMilk",
"_butter",
"_cheeseLowFat",
//"_cottageCheese",
"_creamCheese",
"_eggs",
//"_feta",
"_greekYogurt",
//"_halloumiCheese",
"_heavyCream",
"_milk",
"_mozarella",
"_parmesan",
//"_phylloDough",
"_pudding",
"_puffPastry",
"_ricotta",
"_sourCream",
"_whippedCream",
 };


	private bool[] itemStates;

    private string[][] lessons = new string[][] {
        //put recipes here new string [] {"1", "2"},
        //Roasted Grapefruit with Pistachio Sauce   
new string [] { "____bellPeppers", "____onions", "____spinach", "____tomatoes", "___chiliPowder", "___cumin", "___oliveOil", "___pepper","___salt", "_eggs",},
new string [] { "____cherryTomatoes", "____cucumbers","____onions", "____saladGreens", "__chicken", "___kalamataOlives","____lemons", "___oliveOil", "___oregano", "___pepper","___salt", "_feta",},
new string [] { "____garlic", "____ginger", "____onions", "____spinach", "___canDicedTomatoes", "__cauliflowerRice","___cayennePepper", "___coriander", "___cumin", "___lentils", "___oliveOil", "___salt", "___turmeric", "___vegBroth",},
new string [] { "____lemons", "____mint", "____apples", "_butter", "___cinnamon", "___honey", "___sweetener", "_greekYogurt",},
new string [] { "____basil","____bellPeppers", "____redOnions","___blackOlives", "___canDicedTomatoes", "___oliveOil", "___pepper","___salt", "_eggs","_feta",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____garlic", "____greenOnions", "____lettuce", "____limes","__chicken","___fishSauce", "___oliveOil", "___peanutButter", "___soySauce", "___srirachaSauce",},
new string [] { "____bellPeppers", "____garlic", "____lemons", "____redOnions","____zucchini", "___basil", "___oliveOil", "___oregano", "___pepper","__salmon", "___salt",},
new string [] { "____berries", "___chiaSeeds", "___cinnamon", "___sweetener", "___vanillaExtract","_almondMilk",},
new string [] { "____bellPeppers", "____garlic", "____onions", "____parsley", "___canDicedTomatoes", "___cayennePepper", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "_eggs",},
new string [] { "____cherryTomatoes", "____cucumbers","____garlic", "____lemons", "____mint", "____parsley", "____redOnions","___canChickpeas", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "__shrimp",},
new string [] { "____garlic", "____ginger", "___brownRice", "___mirin", "___riceVinegar", "___soySauce", "___sweetener", "__chicken", "__stirFryVeggies",},
new string [] { "____berries", "___honey", "___nuts", "_greekYogurt",},
new string [] { "____greenChili", "____onions", "____spinach", "____tomatoes", "___cumin", "___garamMasala", "___gingerGarlicPaste", "___mustard", "___oil", "___rolledOats","___salt", "___turmeric", "___water",},
new string [] { "____bellPeppers", "____cilantro", "____corn", "____limes","____onions", "___canBlackBeans", "___canDicedTomatoes", "___chiliPowder", "___cumin", "___garlicPowder", "___oliveOil", "___paprika", "___pepper","___quinoa","___salt", "__chicken",},
new string [] { "____lemons", "____parsley", "___almonds", "___cinnamon", "___coriander", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "__cauliflowerRice","__lamb",},
new string [] { "____mango","____papaya", "____pineapple","____watermelon", "____canteloupe", "____limes","____mint",},
new string [] { "___ryeBread", "__smokedSalmon", "____avocado", "____dill",},
new string [] { "____carrot", "____cucumbers","____freshHerbs", "____limes","____saladGreens", "___beanSprouts", "___fishSauce", "___honey", "___mincedChiliPowder", "___mincedGarlic", "___mincedGinger", "___oliveOil", "___peanuts", "___soySauce", "___vermicelliNoodles", "__shrimp",},
new string [] { "____cucumbers","____lemons", "____redOnions","____tomatoes", "___kalamataOlives","___mincedGarlic", "___oliveOil", "___oregano", "___pepper","___redWineVinegar","___salt", "___thyme", "__drumsticksChicken", "__thighsChicken", "_feta",},
new string [] { "____pears","___cinnamon", "___honey", "___walnuts", "_greekYogurt",},
new string [] { "____cilantro", "____ginger", "____greenChili", "____lemons", "____mint", "____onions", "___chickpeaFlour", "___cookingSpray", "___coriander", "___redChiliPowder","___salt", "___turmeric", "___water",},
new string [] { "____cilantro", "____garlic", "____greenOnions", "____limes","____onions", "___coconutMilk", "___soySauce", "___thaiRedCurryPaste", "___tofu", "___vegBroth", "___vegetableOil", "__stirFryVeggies",},
new string [] { "____bellPeppers", "____garlic", "____lemons", "____onions", "____parsley", "___brownRice", "___canDicedTomatoes", "___oliveOil", "___paprika", "___saffron", "___turmeric", "___vegBroth", "__frozenPeas", "__seafood",},
new string [] { "____bananas", "____berries", "___chiaSeeds", "___coconutFlakes", "___nuts", "__frozenAcaiPacket", "_almondMilk",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____onions", "___canDicedTomatoes", "___chiliPowder", "___cornTortillas", "___cumin", "___oliveOil", "___salsa", "___salt", "___slicedJalapenos", "_lowFatCheese",},
new string [] { "____cucumbers","____dill", "____garlic", "____lemons", "____lettuce", "____onions", "____parsley", "____redOnions","____tomatoes", "___breadcrumbsWholeWheat", "___cumin", "___oliveOil", "___oregano", "___pepper","___salt", "__turkeyGround", "_greekYogurt",},
new string [] { "____lemons", "____parsley", "___cayennePepper", "___cinnamon", "___coriander", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "___turmeric", "__fish", "__stirFryVeggies",},
new string [] { "____bananas", "____berries", "___flaxseed", "___iceCubes", "___sweetener", "_almondMilk", "_greekYogurt",},
new string [] { "____bellPeppers", "____cilantro", "____redOnions","____tomatoes", "____zucchini", "___cookingSpray", "___cumin", "___pepper","___salt",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____garlic", "____ginger", "____limes","____mushrooms","____onions", "___chickenBroth", "___coconutMilk", "___oliveOil", "___peanutButter", "___pepper","___redPepperFlakes", "___salt", "___soySauce", "__chicken",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____jalapenoPepper", "____onions", "___brownRice", "___canBlackBeans", "___canDicedTomatoes", "___chiliPowder", "___cumin", "___oliveOil", "___oregano", "___paprika", "___pepper","___salt", "__turkeyGround",},
new string [] { "___sweetener", "___vanillaExtract","__berries","_greekYogurt",},
new string [] { "____cilantro", "____garlic", "____ginger", "____onions", "____tomatoes", "___cayennePepper", "___coriander", "___cumin", "___lentils", "___oliveOil", "___salt", "___turmeric", "___water",},
new string [] { "____cherryTomatoes", "____cucumbers","____lemons", "____mint", "____parsley", "____redOnions","___cumin", "___kalamataOlives","___oliveOil", "___pepper","___quinoa","___salt", "_feta",},
new string [] { "____garlic", "____ginger", "____greenOnions", "____oranges", "___brownRice", "___canolaOil", "___chickenBroth", "___cornstarch","___honey", "___redPepperFlakes", "___riceVinegar", "___soySauce", "__chicken",},
new string [] { "___coconutExtract","___coconutMilk", "___sweetener", "___vanillaExtract","_almondMilk", "___coconutFlakes",},
new string [] { "____avocado", "____cilantro", "____jalapenos","____limes","____redOnions","___breadWholeGrain", "___canBlackBeans", "___canDicedTomatoes", "___pepper","___salt", "_feta",},
new string [] { "____cucumbers","____garlic", "____lemons", "____parsley", "____redOnions","____tomatoes", "___oliveOil", "___oregano", "___pepper","___salt", "___tortillasWheat","__chicken","_greekYogurt",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____garlic", "____onions", "____spinach", "___canDicedTomatoes", "___cinnamon", "___coriander", "___cumin", "___lentils", "___oliveOil", "___pepper","___salt", "___tomatoPaste", "___turmeric", "___vegBroth",},
new string [] { "____mint", "____pineapple","___cinnamon", "___honey",},
new string [] { "____basil","____cherryTomatoes", "___oliveOil", "___pepper","___salt", "_eggs","_milk","_mozarella",},
new string [] { "____freshHerbs", "____garlic", "____ginger", "____limes","____saladGreens", "___fishSauce", "___peanuts", "___riceVinegar", "___vermicelliNoodles", "__chicken",},
new string [] { "____cilantro", "____garlic", "____lemons", "____onions", "___coriander", "___cumin", "___gingerGarlicPaste", "___oliveOil", "___paprika", "___pepper","___salt", "___tandooriSpice", "___turmeric", "__cauliflowerRice","__chicken","_greekYogurt",},
new string [] { "____peaches", "___cinnamon", "___nutmeg","___salt", "___sweetener", "___vanillaExtract","___walnuts", "_almondMilk", "_butter",},
new string [] { "____onions", "____potatoes", "____spinach", "___oliveOil", "___pepper","___salt", "_eggs",},
new string [] { "____avocado", "____carrot", "____cucumbers","____ginger", "___brownRice", "___honey", "___noriSheet", "___riceVinegar", "___sesameOil", "___sesameSeeds", "___soySauce", "__edamameFrozen", "__tunaWhole",},
new string [] { "____cucumbers","____garlic", "____lemons", "____mint", "____parsley", "____redOnions","____tomatoes", "___bulgerWheat", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "___skewers", "___water", "__shrimp",},
new string [] { "____berries", "___honey", "___pistachios","_greekYogurt",},
new string [] { "___almonds", "___chiaSeeds", "___cinnamon", "___coconutFlakes", "___honey", "___vanillaExtract","__berriesFrozen", "_almondMilk",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____ginger", "____greenOnions", "____limes","____mushrooms","____onions", "____snowPeas", "___coconutMilk", "___fishSauce", "___oliveOil", "___thaiRedCurryPaste", "___vegBroth", "__shrimp",},
new string [] { "____garlic", "____lemons", "____parsley", "___kalamataOlives","___oliveOil", "___oregano", "___paprika", "___pepper","___salt", "__fish",},
new string [] { "____lemons", "___applesauce","___bakingPowder", "___bakingSoda","___flourAlmond", "___flourWholeWheat", "___salt", "___sweetener", "_eggs","_greekYogurt",},
new string [] { "____onions", "____spinach", "____tomatoes", "___cumin", "___oil", "___redChiliPowder","___salt", "___turmeric", "_eggs",},
new string [] { "____cherryTomatoes", "____cucumbers","____lemons", "____mint", "____parsley", "____redOnions","____saladGreens", "___oliveOil", "___pepper","___salt", "__falafalPattiesFrozen",},
new string [] { "____basil","____garlic", "____parsley", "____zucchini", "___flourAlmond", "___marinara", "___oregano", "___pepper","___salt", "__turkeyGround", "_parmesan",},
new string [] { "____berries", "____lemons", "____mint", "___sweetener", "___water",},
new string [] { "____apples", "____berries", "___cinnamon", "___flaxseed", "___nuts", "___rolledOats","___sweetener", "___water",},
new string [] { "____avocado", "____cherryTomatoes", "____cilantro", "____corn", "____limes","____redOnions","____saladGreens", "___canBlackBeans", "___chiliPowder", "___cookingSpray", "___cumin", "___oliveOil", "___paprika", "___pepper","___salsa", "___salt", "__chicken","_greekYogurt",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____limes","____onions", "____zucchini", "___brownRice", "___brownSugar","___coconutMilk", "___fishSauce", "___oliveOil", "___thaiRedCurryPaste", "___vegBroth", "__shrimp",},
new string [] { "____berries", "___honey", "___nuts", "___vanillaExtract","_greekYogurt",},
new string [] { "____onions", "____spinach", "___oliveOil", "___pepper","___salt", "_eggs","_feta",},
new string [] { "___edamame", "___tofu", "____saladGreens", "____cucumbers","____carrot", "____greenOnions", "___soySauce", "___riceVinegar", "___sesameOil", "____ginger", "___sesameSeeds",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____onions", "___almonds", "___apricotsDried", "___cinnamon", "___coriander", "___cumin", "___oliveOil", "___paprika", "___pepper","___quinoa","___salt", "___turmeric", "__salmon",},
new string [] { "____berries", "___powderedSugar", "_butter", "_phylloDough", "_pudding",},
new string [] { "____cilantro", "____greenChili", "____mixedVeggies", "____onions", "____tomatoes", "___cumin", "___garamMasala", "___gingerGarlicPaste", "___mustardSeeds", "___oil", "___rolledOats","___salt", "___turmeric",},
new string [] { "____bellPeppers", "____cherryTomatoes", "____garlic", "____onions", "____parsley", "____zucchini", "___couscous", "___oliveOil", "___oregano", "___pepper","___salt", "___vegBroth",},
new string [] { "____basil","____bellPeppers", "____eggplant", "____garlic", "____onions", "____zucchini", "___canDicedTomatoes", "___italianSeasoning", "___oliveOil", "___oregano", "___pepper","___salt", "___thyme", "___tomatoPaste", "__chicken",},
new string [] { "____strawberries", "___powderedSugar", "___vanillaExtract","_heavyCream",},
new string [] { "____limes","____tomatoes", "___canBlackBeans", "___cornTortillas", "___oliveOil", "___pepper","___salt", "_eggs",},
new string [] { "____carrot", "____cilantro", "____cucumbers","____garlic", "____limes","____mint", "____saladGreens", "___chiliFlakes", "___fishSauce", "___peanuts", "___riceVinegar", "___sweetener", "___vermicelliNoodles", "__shrimp",},
new string [] { "____bellPeppers", "____cherryTomatoes", "____garlic", "____lemons", "____parsley", "____redOnions","____zucchini", "___oliveOil", "___oregano", "___pepper","___salt", "___thyme", "__chicken",},
new string [] { "____limes","____mint", "___coconutMilk", "___granulatedSweetener", "___water",},
new string [] { "____parsley", "___oliveOil", "___pepper","___salt", "___za'atarSpiceMix", "_eggs",},
new string [] { "____cabbage", "____carrot", "____cilantro", "____cucumbers","____garlic", "____ginger", "____greenOnions", "____limes","____mint", "____saladGreens", "___chiliFlakes", "___peanutButter", "___riceVinegar", "___sesameOil", "___soySauce", "___water", "__steak",},
new string [] { "____cauliflower", "____cilantro", "____ginger", "____lemons", "___cookingSpray", "___cumin", "___mincedGarlic", "___oil", "___salt", "___tandooriSpice", "___turmeric", "__whiteFish", "_greekYogurt",},
new string [] { "___cinnamon", "___cornstarch","___granulatedSweetener", "___vanillaExtract","_almondMilk", "_eggs","_puffPastry",},
new string [] { "____berries", "___bakingpowder", "___coconutOil","___cookingSpray", "___flourWholeWheat", "___salt", "___sweetener", "___syrupSugarFree","___vanillaExtract","_almondMilk",},
new string [] { "___water", "___misoPaste", "___tofu", "____greenOnions", "___noriSheet", "____mushrooms","____carrot", "____mixedVeggies",},
new string [] { "____carrot", "____cilantro", "____garlic", "____ginger", "____onions", "____zucchini", "___apricotsDried", "___canDicedTomatoes", "___cayennePepper", "___chickenBroth", "___cinnamon", "___coriander", "___couscous", "___cumin", "___pepper","___salt", "__lamb",},
new string [] { "___applesauce","___bakingSoda","___coconutOil","___flourAlmond", "___flourWholeWheat", "___syrupSugarFree","___vanillaExtract","___water", "_almondMilk", "_eggs",},
new string [] { "____cilantro", "____corn", "____garlic", "____onions", "____parsley", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "_almondMilk", "_parmesan",},
new string [] { "____cilantro", "____cucumbers","____garlic", "____lemons", "____mint", "____onions", "____parsley", "____redOnions","____saladGreens", "____tomatoes", "___bakingPowder", "___canChickpeas", "___coriander", "___cumin", "___flourWholeWheat", "___oliveOil", "___pepper","___salt", "___tahiniPaste", "___water",},
new string [] { "____garlic", "____parsley", "____zucchini", "___basil", "___breadcrumbsWholeWheat", "___canDicedTomatoes", "___oliveOil", "___oregano", "___pepper","___salt", "__turkeyGround", "_eggs","_parmesan",},
new string [] { "___cinnamon", "___granulatedSweetener", "___salt", "___vanillaExtract","_eggs","_milk",},
new string [] { "____onions", "____potatoes", "___flourWholeWheat", "___oil", "___pepper","___salt", "_eggs",},
new string [] { "____cucumbers","____garlic", "____lemons", "____mint", "____parsley", "____tomatoes", "___canChickpeas", "___coriander", "___cumin", "___oliveOil", "___pepper","___pineNuts", "___salt", "___tahini","_greekYogurt",},
new string [] { "____basil","____cilantro", "____garlic", "____onions", "___brownrice", "___coconutMilk", "____greenCurryPaste", "___oliveOil", "___soySauce", "___sweetener", "___tofu", "___vegBroth", "__cauliflowerRice",},
new string [] { "____berries", "___almonds", "___cornstarch","___sweetener", "___vanillaExtract","_almondMilk",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____onions", "___canBlackBeans", "___chiliPowder", "___cumin", "___hotSauce", "___pepper","___salsa", "___salt", "_eggs",},
new string [] { "____cilantro", "____corn", "____garlic", "____onions", "____parsley", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "_almondMilk", "_parmesan",},
new string [] { "____cilantro", "____cucumbers","____garlic", "____lemons", "____mint", "____onions", "____parsley", "____redOnions","____saladGreens", "____tomatoes", "___bakingPowder", "___canChickpeas", "___coriander", "___cumin", "___flourWholeWheat", "___oliveOil", "___pepper","___salt", "___tahiniPaste", "___water",},
new string [] { "____basil","____garlic", "____parsley", "____zucchini", "___breadcrumbsWholeWheat", "___canDicedTomatoes", "___oliveOil", "___oregano", "___pepper","___salt", "__turkeyGround", "_eggs","_parmesan",},
new string [] { "___cinnamon", "___salt", "___sweetener", "___vanillaExtract","_eggs","_milk",},
new string [] { "____onions", "____potatoes", "___cookingSpray", "___flourWholeWheat", "___pepper","___salt", "_eggs",},
new string [] { "____cucumbers","____garlic", "____lemons", "____mint", "____parsley", "____tomatoes", "___canChickpeas", "___coriander", "___cumin", "___oliveOil", "___pepper","___pineNuts", "___pitaWholeWheat","___salt", "___tahini","_greekYogurt",},
new string [] { "____basil","____cilantro", "____garlic", "____onions", "___brownRice", "___brownSugar","___coconutMilk", "___greenCurryPaste", "___oliveOil", "___soySauce", "___tofu", "___vegBroth", "__cauliflowerRice","__stirFryVeggies",},
new string [] { "____berries", "___almonds", "___cornstarch","___sweetener", "___vanillaExtract","_almondMilk",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____onions", "___canBlackBeans", "___chiliPowder", "___cumin", "___hotSauce", "___pepper","___salsa", "___salt", "_eggs",},
new string [] { "____freshHerbs", "____limes","____mixedVeggies", "____saladGreens", "___fishSauce", "___mincedGarlic", "___mincedGinger", "___peanuts", "___riceVinegar", "___sesameOil", "___soySauce", "___sweetener", "___vermicelliNoodles", "__shrimp",},
new string [] { "____cauliflower", "____cilantro", "____onions", "___cayennePepper", "___coriander", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "___turmeric", "__salmon",},
new string [] { "____oranges", "___applesauce","___bakingPowder", "___bakingSoda","___flourAlmond", "___flourCoconut", "___orangeJuice", "___salt", "___sweetener", "___vanillaExtract","_eggs","_greekYogurt",},
new string [] { "____bellPeppers", "____onions", "____spinach", "___oliveOil", "___pepper","___salt", "_eggs","_feta",},
new string [] { "____avocado", "____bellPeppers", "____bunsHamburger","____garlic", "____lettuce", "____redOnions","____tomatoes", "___breadcrumbsWholeWheat", "___canBlackBeans", "___chiliPowder", "___cumin", "___pepper","___salt",},
new string [] { "____garlic", "____onions", "____parsley", "___basil", "___breadcrumbsWholeWheat", "___canDicedTomatoes", "___garlicPowder", "___marinara", "___oregano", "___pepper","___salt", "__turkeyGround", "_eggs","_parmesan",},
new string [] { "____cilantro", "____garlic", "____lemons", "____parsley", "___canFavaBeans", "___coriander", "___cumin", "___oliveOil", "___pepper","___pitaWholeWheat","___salt",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____garlic", "____onions", "____tomatoes", "___canBlackBeans", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "___vegBroth",},
new string [] { "____cucumbers","____garlic", "____lemons", "____mint", "____parsley", "____redOnions","____tomatoes", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "___skewers", "__chicken",},
new string [] { "____apples", "___cinnamon", "___sweetener", "___walnuts",},
new string [] { "____ginger", "___cardamom", "___cinnamon", "___nuts", "___raisins", "___rolledOats","___water", "_almondMilk",},
new string [] { "____cherryTomatoes", "____cilantro", "____cucumbers","____garlic", "____ginger", "____limes","____mint", "____redOnions","____saladGreens", "___sesameOil", "___soySauce", "___sweetener", "__steak",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____garlic", "____onions", "___cayennePepper", "___chiliPowder", "___cornTortillas", "___cumin", "___oliveOil", "___paprika", "___pepper","___salsa", "___salt", "__shrimp", "_sourCream",},
new string [] { "____berries", "___almonds", "___brownRice", "___cinnamon", "___sweetener", "_almondMilk",},
new string [] { "____dill", "____lemons", "___oliveOil", "___pepper","___salt", "_almondMilk", "_eggs",},
new string [] { "____bellPeppers", "____parsley", "____redOnions","____tomatoes", "___almonds", "___apricotsDried", "___canChickpeas", "___cinnamon", "___cumin", "___oliveOil", "___paprika", "___pepper","___quinoa","___salt",},
new string [] { "____bellPeppers", "____broccoli", "____garlic", "____ginger", "____onions", "____snowPeas", "___brownRice", "___chickenBroth", "___cornstarch","___hoisinSauce", "___oil", "___riceVinegar", "___sesameSeeds", "___soySauce", "__chicken",},
new string [] { "____berries", "____lemons", "___flourAlmond", "___sweetener", "___vanillaExtract","_eggs","_ricotta",},
new string [] { "____basil","____bellPeppers", "____cherryTomatoes", "____onions", "____zucchini", "___oliveOil", "___pepper","___salt", "_eggs","_feta",},
new string [] { "____avocado", "____carrot", "____cucumbers","____greenOnions", "___brownRice", "___edamame", "___riceVinegar", "___sesameOil", "___sesameSeeds", "___soySauce", "__tunaWhole",},
new string [] { "____lemons", "___coriander", "___cumin", "___garlicPowder", "___ginger","___paprika", "___tandooriSpice", "___turmeric", "__chicken","_greekYogurt",},
new string [] { "____pears","___almonds", "___cinnamon", "___honey",},
new string [] { "____bellPeppers", "____onions", "____spinach", "____tomatoes", "___chiliPowder", "___cookingSpray", "___cumin", "___pepper","___salt", "_eggs",},
new string [] { "____cherryTomatoes", "____cucumbers","____lemons", "____redOnions","___kalamataOlives","___oliveOil", "___oregano", "___pepper","___quinoa","___salt", "__chicken","_feta",},
new string [] { "____cilantro", "____garlic", "____ginger", "____limes","____onions", "___chickenBroth", "___coconutMilk", "___fishSauce", "___greenCurryPaste", "___oliveOil", "___soySauce", "__chicken","__stirFryVeggies",},
new string [] { "____apples", "___cinnamon", "___honey", "___nuts", "___sweetener", "_butter", "_greekYogurt",},
new string [] { "____garlic", "____mushrooms","____onions", "____spinach", "___oliveOil", "___pepper","___salt", "_eggs",},
new string [] { "____cilantro", "____garlic", "____ginger", "____lemongrass", "____limes","____onions", "___coconutMilk", "___fishSauce", "___oliveOil", "___pepper","___redPepperFlakes", "___salt", "___vegBroth", "__shrimp", "__stirFryVeggies",},
new string [] { "____asparagus","____lemons", "___garlicPowder", "___italianSeasoning", "___oliveOil", "___pepper","___salt", "__salmon",},
new string [] { "____strawberries", "___bakingPowder", "___cocoaPowder", "___coconutShredded", "___flourAlmond", "___pecans","___salt", "___sweetener", "___vanillaExtract","_almondMilk", "_butter", "_eggs","_heavyCream",},
new string [] { "___bakingPowder", "___cookingSpray", "___flourWholeWheat", "___salt", "___sweetener", "___vanillaExtract","_almondMilk", "_eggs","_greekYogurt",},
new string [] { "____avocado", "____carrot", "____cilantro", "____cucumbers","____garlic", "____ginger", "____limes","____mint", "____saladGreens", "___beanSprouts", "___peanutButter", "___ricePaperWrappers", "___soySauce", "___sweetener", "___water", "__shrimp",},
new string [] { "__chicken","___cumin", "___coriander", "___paprika", "___turmeric", "___cinnamon", "____ginger", "___salt", "___pepper","___oliveOil", "____bellPeppers", "____zucchini", "____redOnions","____cilantro", "____parsley",},
new string [] { "____apples", "___cinnamon", "___sweetener", "___vanillaExtract","_butter", "_puffPastry",},
new string [] { "____bellPeppers", "____parsley", "____redOnions","____spinach", "____tomatoes", "___cookingSpray", "___oregano", "___pepper","___salt", "_eggs",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____cucumbers","____garlic", "____ginger", "____limes","____saladGreens", "___chiliFlakes", "___fishSauce", "___peanuts", "___soySauce", "___sweetener", "__steak",},
new string [] { "____eggplant", "___basil", "___cookingSpray", "___marinara", "___oregano", "___pepper","___quinoa","___salt", "_mozarella", "_parmesan",},
new string [] { "___cinnamon", "___cocoaPowder", "___coffee","__iceCream",},
new string [] { "____bellPeppers", "____cucumbers","____mint", "____parsley", "____tomatoes", "___cornTortillas", "___pepper","___salt", "_greekYogurt",},
new string [] { "____carrot", "____celery", "____garlic", "____lemons", "____onions", "____spinach", "___coriander", "___cumin", "___lentils", "___pepper","___salt", "___turmeric", "___vegBroth",},
new string [] { "____bellPeppers", "____cherryTomatoes", "____garlic", "____lemons", "____parsley", "____redOnions","____zucchini", "___oliveOil", "___oregano", "___pepper","___salt", "___thyme", "__chicken",},
new string [] { "____limes","____mint", "___coconutMilk", "___sweetener", "__frozenTropicalFruit",},
new string [] { "____bellPeppers", "____garlic", "____onions", "____parsley", "____spinach", "___canDicedTomatoes", "___cayennePepper", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "_eggs","_feta",},
new string [] { "____cucumbers","____dill", "____garlic", "____lemons", "___oliveOil", "___oregano", "___pepper","___salt", "___skewers", "__chicken","_greekYogurt",},
new string [] { "____basil","____bellPeppers", "____chiliPepper", "____garlic", "____limes","____onions", "___fishSauce", "___oliveOil", "___oysterSauce", "___soySauce", "__cauliflowerRice","__steak",},
new string [] { "____lemons", "___cinnamon", "___cloves","___nuts", "___sweetener", "___vanillaExtract","___water", "_butter", "_phylloDough",},
new string [] { "____avocado", "____dill", "____lemons", "___oliveOil", "___pepper","___salt", "__salmon", "_eggs","_milk",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____limes","____onions", "___chiliPowder", "___cumin", "___garlicPowder", "___oliveOil", "___paprika", "___pepper","___salt", "__cauliflowerRice","__chicken",},
new string [] { "____freshHerbs", "____garlic", "____lemons", "___cayennePepper", "___oliveOil", "___oregano", "___paprika", "___thyme", "__chicken",},
new string [] { "____lemons", "___bakingPowder", "___flourAlmond", "___flourCoconut", "___salt", "___sweetener", "___vanillaExtract","_almondMilk", "_butter", "_eggs","_ricotta",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____limes","____onions", "___canDicedTomatoes", "___oliveOil", "___salsa", "___tortillasWheat","_cheeseLowFat","_eggs",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____onions", "____parsley", "___canDicedTomatoes", "___cayennePepper", "___cumin", "___oliveOil", "___paprika", "_eggs",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____ginger", "____greenBeans", "____onions", "___cumin", "___flourSemolina", "___greenChili","___mustardSeeds", "___oil", "___salt", "___water",},
new string [] { "____ginger", "____greenOnions", "___fishSauce", "___oil", "___soySauce", "_eggs",},
new string [] { "____berries", "___cookingSpray", "___flourAlmond", "___jam", "___sweetener", "___vanillaExtract","_cottageCheese", "_eggs","_greekYogurt",},
new string [] { "____berries", "___chiaSeeds", "___flaxseed", "___nuts", "___sweetener", "_greekYogurt",},
new string [] { "____bellPeppers", "____freshHerbs", "____onions", "____spinach", "___canDicedTomatoes", "___pepper","___salt", "_eggs","_feta",},
new string [] { "____cilantro", "____garlic", "____ginger", "____greenOnions", "___pepper","___salt", "___sesameOil", "___soySauce", "___water", "___whiteRice", "__chicken","_eggs",},
new string [] { "___oliveOil", "____onions", "____bellPeppers", "____garlic", "___cumin", "___paprika", "___canDicedTomatoes", "___salt", "___pepper","_eggs",},
new string [] { "____spinach", "___pepper","___salt", "_butter", "_eggs","_feta","_phylloDough",},
new string [] { "____cherryTomatoes", "____cucumbers","____lemons", "____redOnions","____saladGreens", "___kalamataOlives","___oliveOil", "___oregano", "___pepper","___salt", "__chicken","_feta",},
new string [] { "____carrot", "____cucumbers","____greenOnions", "____radishes", "____saladGreens", "___riceVinegar", "___sesameOil", "___sesameSeeds", "___soySauce", "__salmon", "__tunaWhole",},
new string [] { "____avocado", "____bellPeppers", "____cherryTomatoes", "____cilantro", "____limes","____onions", "____saladGreens", "___chiliPowder", "___cumin", "___garlicPowder", "___oliveOil", "___paprika", "___pepper","___salsa", "___salt", "__chicken","_greekYogurt",},
new string [] { "____cilantro", "____garlic", "____ginger", "____greenChili", "____onions", "___canChickpeas", "___canCrushedTomatoes","___coriander", "___cumin", "___garamMasala", "___oliveOil", "___paprika", "___salt", "___turmeric", "___water",},
new string [] { "____basil","____cherryTomatoes", "____garlic", "____portobello", "___oliveOil", "___pepper","___salt", "_mozarella",},
new string [] { "____limes","___coriander", "___cumin", "___fishSauce", "___honey", "___oliveOil", "___paprika", "___peanutButter", "___redPepperFlakes", "___skewers", "___soySauce", "___turmeric", "___water", "__chicken",},
new string [] { "____cucumbers","____lemons", "____mint", "____parsley", "____redOnions","____tomatoes", "___almonds", "___coriander", "___cumin", "___oliveOil", "___pepper","___quinoa","___salt", "_feta",},
new string [] { "____basil","____bellPeppers", "____eggplant", "____garlic", "____onions", "____squash", "____zucchini", "___basil", "___canDicedTomatoes", "___oliveOil", "___pepper","___salt", "___thyme",},
new string [] { "____cilantro", "____cucumbers","____garlic", "____lemons", "____parsley", "____redOnions","____saladGreens", "____tomatoes", "___bakingPowder", "___canChickpeas", "___coriander", "___cumin", "___flourWholeWheat", "___oliveOil", "___pepper","___salt", "_greekYogurt",},
new string [] { "___garlicPowder", "___oliveOil", "___paprika", "___pepper","___salt", "___skewers", "__sausage","__shrimp",},
new string [] { "____carrot", "____cilantro", "____cucumbers","____mint", "____saladGreens", "___peanuts", "___ricePaperWrappers", "__shrimp",},
new string [] { "____avocado", "____bellPeppers", "____cilantro", "____garlic", "____lettuce", "____limes","____redOnions","___canDicedTomatoes", "___carribeanJerkSeasoning","___oliveOil", "___pepper","___salt",},
new string [] { "____cucumbers","____lemons", "____mint", "____parsley", "____redOnions","___canDicedTomatoes", "___cookingSpray", "___oliveOil", "___pepper","___salt", "_halloumiCheese",},
new string [] { "____cucumbers","____mushrooms","___brownRice", "___chiliPaste","___mincedGarlic", "___oil", "___sesameOil", "___sesameSeeds", "___soySauce", "___tofu", "__stirFryVeggies",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____limes","____onions", "___canDicedTomatoes", "___coconutMilk", "___oliveOil", "___pepper","___salt", "___tomatoPaste", "___vegBroth", "__whiteFish",},
new string [] { "____cilantro", "____garlic", "____ginger", "____onions", "____parsley", "___berbereSpice", "___canDicedTomatoes", "___cumin", "___lentils", "___oliveOil", "___paprika", "___salt", "___turmeric", "___vegBroth",},
new string [] { "____cabbage", "____chiliPepper", "____cilantro", "____garlic", "____limes","____mint", "____shallots", "___chicken", "___fishSauce", "___oliveOil", "___peanuts", "___soySauce", "___sweetener",},
new string [] { "____cilantro", "____onions", "____parsley", "___brownRice", "___coriander", "___cumin", "___lentils", "___oliveOil", "___pepper","___salt", "___turmeric",},
new string [] { "____garlic", "____ginger", "____greenChili", "____onions", "____spinach", "____tomatoes", "___coriander", "___cumin", "___garamMasala", "___oliveOil", "___salt", "___turmeric", "_cottageCheese",},
new string [] { "____avocado", "____canChipotlePepperInAdobo", "____cilantro", "____garlic", "____lettuce", "____onions", "___canDicedTomatoes", "___cumin", "___oliveOil", "___oregano", "___paprika", "___pepper","___salt", "___tortillasWheat","__chicken",},
new string [] { "____carrot", "____celery", "____cilantro", "____garlic", "____limes","____onions", "____parsley", "___canDicedTomatoes", "___cumin", "___oliveOil", "___oregano", "___paprika", "___pepper","___quinoa","___salt", "___vegBroth",},
new string [] { "____bellPeppers", "____carrot", "____cilantro", "____garlic", "____ginger", "____lemons", "____onions", "____squash", "____zucchini", "___apricotsDried", "___canDicedTomatoes", "___cinnamon", "___coriander", "___cumin", "___oliveOil", "___pepper","___raisins", "___salt", "___turmeric", "___vegBroth",},
new string [] { "____bellPeppers", "____cilantro", "____garlic", "____limes","____tomatoes", "___coconutMilk", "___oliveOil", "___pepper","___salt", "___tomatoPaste", "___vegBroth", "__shrimp",},
new string [] { "____eggplant", "____garlic", "____onions", "____parsley", "____tomatoes", "___cumin", "___oliveOil", "___paprika", "___pepper","___salt", "___tomatoPaste",},
new string [] { "____garlic", "____lemons", "____onions", "____spinach", "___oliveOil", "___pepper","___salt", "___vegBroth", "___whiteRice",},
new string [] { "____raspberries", "___flourWholeWheat", "___salt", "___sweetener", "___vanillaExtract","_almondMilk", "_eggs","_milk",},
new string [] { "___flourAlmond", "___salt", "___water", "_butter", "_mozarella",},
new string [] { "___cornstarch","___flourRice", "___freshFruit","___matchaGreenTeaPowder", "___pasteRedBean", "___sweetener", "___water",},
new string [] { "____oranges", "___orangeJuice", "___salt", "___sweetener", "___vanillaExtract","___water", "_eggs",},
new string [] { "___almonds", "___cardamom", "___saffron", "___sweetener", "___water", "_greekYogurt",},
new string [] { "___cinnamon", "___sweetener", "___syrupSugarFree","___walnuts", "_butter", "_phylloDough",},
new string [] { "____berries", "___almondExtract", "___flourAlmond", "___jam", "___sweetener", "_butter",},
new string [] { "___canCondensedMilk", "___coconutShredded", "___vanillaExtract","_butter",},
new string [] { "___pieCrust", "___quincePaste", "___sweetener", "___vanillaExtract","_creamCheese", "_eggs",},
new string [] { "___almonds", "___applesauce","___bakingPowder", "___cardamom", "___flourAlmond", "___flourWholeWheat", "___salt", "___sweetener", "_almondMilk", "_butter", "_eggs",},
new string [] { "____berries", "___almonds", "___darkChocolate", "___jam", "_pudding", "_whippedCream",	},														
new string [] { "____berries", "____lemons", "___flourAlmond", "___sweetener", "___vanillaExtract","_butter", "_creamCheese", "_greekYogurt",},                                              }; 

	private List<string> items = new List<string>();

	public Text availableLessons;
	public Text missingLessons;

	//public int maximumMisses = 2;
	public Text maximumMissesText;
	void Start (){
		itemStates = new bool[allItems.Length];
		var position = Vector2.zero;
		Transform buttonParent = null;
		for(var i = 0; i < allItems.Length; i++) {
			var item = allItems [i];
			var buttonObj = GameObject.Instantiate (ButtonPrefab, Vector3.zero, Quaternion.identity) as GameObject;

			// Make all buttons white (missing state)
			var image = buttonObj.GetComponent<Image>();
			image.color = Color.white;

			// Set the button text
			var button = buttonObj.GetComponent<Button> ();
			var btnText = buttonObj.GetComponentInChildren<Text> () as Text;
			btnText.text = item;

			// Position the button
			var rectTransf = button.GetComponent<RectTransform> ();
			rectTransf.SetParent (Parent.transform);
			rectTransf.offsetMin = position;
			rectTransf.offsetMax = new Vector2 (150, position.y + 15); // CHANGED FROM 20 TO 30 width/button size
			position.y += 10;// CHANGED FROM 20 TO 10
			// 
			var ni = i;
            //below makes everything selected - just save your list in excel and load abov
			//button.onClick.AddListener (delegate {
				itemfunction (buttonObj, ni);
			//});

            button.onClick.AddListener (delegate {
            itemfunction (buttonObj, ni);
            });

			buttonParent = button.transform.parent;
		}

		if (buttonParent) {
			var parentSize = buttonParent.GetComponent<RectTransform> ();
			parentSize.offsetMax = new Vector2(parentSize.offsetMax.x, allItems.Length * 14); //changed from 8 change this to change the size
		}

	}
	//attach this to individual buttons
	//create a check mark or x or color in the drop down 
	//save settings in app?
	public void itemfunction (GameObject buttonObj, int index) 
	{
		var item = allItems [index];	
        itemStates[index] = !itemStates [index];
		if (itemStates[index]) {
			var image = buttonObj.GetComponent<Image>(); //calls the image
			image.color = Color.red; //calls the color
            items.Add (item);//adds the items to index item
            Debug.Log("button pressed");
        }

		else {
			var image = buttonObj.GetComponent<Image>();
			image.color = Color.white;

			items.Remove(item);
		}
	}

	//this is attached to the sort button that you want
	public void stringTest () 
	{
		var wearing = "";
		foreach (var item in items)
			wearing += item + " ";

		availableLessons.text = "Your available recipes: \n";
		missingLessons.text = "Recipes you are missing a few indgredients of: \n:";

		int maximumMisses = 0;
		int.TryParse(maximumMissesText.text, out maximumMisses);
		var numMissingLessons = 0;
		for(var lesson = 1; lesson <= lessons.Length; lesson++) {
			var missing = newSortingIdea.Process(wearing, string.Join(" ", lessons[lesson-1]));
			var countMisses = missing.Replace("and ", "").Split (' ').Length;
			Debug.Log ("Missing: " + missing + " " + lesson + countMisses);

			if (string.IsNullOrEmpty (missing)) {
                availableLessons.text += "You can cook " + lesson; //+ "\n";
																   //if (lesson == 1) { availableLessons.text += "(Desserts) Strawberry Graham Cracker Tarts - net222 \n\n"; }
				if (lesson == 1) { availableLessons.text += " 	Mexican-inspired Egg and Vegetable Scramble	\n"; }
				if (lesson == 2) { availableLessons.text += " 	Lunch: Greek Salad with Grilled Chicken	\n"; }
				if (lesson == 3) { availableLessons.text += " 	Dinner: Indian Spiced Lentil Curry with Cauliflower Rice	\n"; }
				if (lesson == 4) { availableLessons.text += " 	Dessert: Baked Cinnamon Apple Slices with Yogurt Topping	\n"; }
				if (lesson == 5) { availableLessons.text += " 	Breakfast: Mediterranean Vegetable Omelette	\n"; }
				if (lesson == 6) { availableLessons.text += " 	Lunch: Thai Chicken Lettuce Wraps	\n"; }
				if (lesson == 7) { availableLessons.text += " 	Dinner: Italian Baked Salmon with Roasted Vegetables	\n"; }
				if (lesson == 8) { availableLessons.text += " 	Dessert: Cuban Chia Pudding with Fresh Berries	\n"; }
				if (lesson == 9) { availableLessons.text += " 	Breakfast: Spanish-style Baked Eggs with Tomatoes and Peppers	\n"; }
				if (lesson == 10) { availableLessons.text += " 	Lunch: Middle Eastern Chickpea Salad with Grilled Shrimp	\n"; }
				if (lesson == 11) { availableLessons.text += " 	Dinner: Japanese Teriyaki Chicken with Steamed Brown Rice and Stir-Fried Vegetables	\n"; }
				if (lesson == 12) { availableLessons.text += " 	Dessert: Greek Yogurt Parfait with Honey and Nuts	\n"; }
				if (lesson == 13) { availableLessons.text += " 	Breakfast: Indian Masala Oats with Spinach and Turmeric	\n"; }
				if (lesson == 14) { availableLessons.text += " 	Lunch: Mexican Chicken Fajita Bowl with Quinoa	\n"; }
				if (lesson == 15) { availableLessons.text += " 	Dinner: Moroccan Spiced Grilled Lamb Chops with Roasted Cauliflower Couscous	\n"; }
				if (lesson == 16) { availableLessons.text += " 	Dessert: Colombian tropical Fruit Salad	\n"; }
				if (lesson == 17) { availableLessons.text += " 	Breakfast: Swedish Rye Bread with Smoked Salmon and Avocado	\n"; }
				if (lesson == 18) { availableLessons.text += " 	Lunch: Vietnamese Vermicelli Noodle Salad with Grilled Shrimp	\n"; }
				if (lesson == 19) { availableLessons.text += " 	Dinner: Greek Lemon Herb Roasted Chicken with Greek Salad	\n"; }
				if (lesson == 20) { availableLessons.text += " 	Dessert: Baked Pear with Cinnamon and Greek Yogurt	\n"; }
				if (lesson == 21) { availableLessons.text += " 	Breakfast: Indian Spiced Chickpea Pancakes with Mint Chutney	\n"; }
				if (lesson == 22) { availableLessons.text += " 	Lunch: Thai Coconut Curry Soup with Tofu and Vegetables	\n"; }
				if (lesson == 23) { availableLessons.text += " 	Dinner: Spanish Paella with Seafood and Saffron	\n"; }
				if (lesson == 24) { availableLessons.text += " 	Dessert: Brazilian acai berry bowl	\n"; }
				if (lesson == 25) { availableLessons.text += " 	Breakfast: Mexican Chilaquiles with Salsa and Guacamole	\n"; }
				if (lesson == 26) { availableLessons.text += " 	Lunch: Greek Turkey Meatball Lettuce Wraps with Tzatziki Sauce	\n"; }
				if (lesson == 27) { availableLessons.text += " 	Dinner: Moroccan Spiced Baked Fish with Roasted Vegetables	\n"; }
				if (lesson == 28) { availableLessons.text += " 	Dessert: Banana berry smoothie	\n"; }
				if (lesson == 29) { availableLessons.text += " 	Breakfast - Peruvian Vegetable Omelet	\n"; }
				if (lesson == 30) { availableLessons.text += " 	Lunch - Thai Peanut Chicken Soup	\n"; }
				if (lesson == 31) { availableLessons.text += " 	Dinner - Mexican Stuffed Bell Peppers	\n"; }
				if (lesson == 32) { availableLessons.text += " 	Dessert - Greek yogurt berry ice cream	\n"; }
				if (lesson == 33) { availableLessons.text += " 	Breakfast - Indian Spiced Lentil Scramble	\n"; }
				if (lesson == 34) { availableLessons.text += " 	Lunch - Middle Eastern Quinoa Salad	\n"; }
				if (lesson == 35) { availableLessons.text += " 	Dinner - Chinese orange chicken with teriyaki rice	\n"; }
				if (lesson == 36) { availableLessons.text += " 	Dessert - Thai Coconut Cream Ice Cream	\n"; }
				if (lesson == 37) { availableLessons.text += " 	Mexican Avocado Breakfast Toast	\n"; }
				if (lesson == 38) { availableLessons.text += " 	Lunch - Greek Chicken Souvlaki Wrap	\n"; }
				if (lesson == 39) { availableLessons.text += " 	Dinner - Moroccan Spiced Lentil Stew	\n"; }
				if (lesson == 40) { availableLessons.text += " 	Dessert - Hawaiian Grilled Pineapple with Cinnamon	\n"; }
				if (lesson == 41) { availableLessons.text += " 	Breakfast - Italian Caprese Frittata	\n"; }
				if (lesson == 42) { availableLessons.text += " 	Lunch - Vietnamese Vermicelli Noodle Bowl	\n"; }
				if (lesson == 43) { availableLessons.text += " 	Dinner - Indian Tandoori Chicken with Cauliflower Rice	\n"; }
				if (lesson == 44) { availableLessons.text += " 	Dessert - Georgia Baked Peaches with Caramel Sauce (sugar-free)	\n"; }
				if (lesson == 45) { availableLessons.text += " 	Breakfast - Spanish Tortilla with Spinach	\n"; }
				if (lesson == 46) { availableLessons.text += " 	Lunch - Japanese Sushi Bowl with Seared Tuna	\n"; }
				if (lesson == 47) { availableLessons.text += " 	Dinner - Lebanese Grilled Shrimp Skewers with Tabouli	\n"; }
				if (lesson == 48) { availableLessons.text += " 	Dessert - Greek Yogurt Parfait with Pistachios and Honey	\n"; }
				if (lesson == 49) { availableLessons.text += " 	Breakfast - Mexican Chia Seed Pudding with Tropical Fruit	\n"; }
				if (lesson == 50) { availableLessons.text += " 	Lunch - Thai Coconut Curry Soup with Shrimp	\n"; }
				if (lesson == 51) { availableLessons.text += " 	Dinner - Mediterranean Baked Cod with Lemon and Olives	\n"; }
				if (lesson == 52) { availableLessons.text += " 	Dessert - Brazilian Lemon Cake	\n"; }
				if (lesson == 53) { availableLessons.text += " 	Breakfast - Indian Masala Omelette with Spinach	\n"; }
				if (lesson == 54) { availableLessons.text += " 	Lunch - Middle Eastern Falafel Salad	\n"; }
				if (lesson == 55) { availableLessons.text += " 	Dinner - Italian Zucchini Noodles with Turkey Meatballs	\n"; }
				if (lesson == 56) { availableLessons.text += " 	Dessert - Italian Berry Sorbet (sugar-free)	\n"; }
				if (lesson == 57) { availableLessons.text += " 	Breakfast: German Fruit and Nut Oatmeal	\n"; }
				if (lesson == 58) { availableLessons.text += " 	Lunch: Mexican Grilled Chicken Salad	\n"; }
				if (lesson == 59) { availableLessons.text += " 	Dinner: Thai Shrimp Curry with Brown Rice	\n"; }
				if (lesson == 60) { availableLessons.text += " 	Dessert: Greek Yogurt Parfait with Fresh Berries	\n"; }
				if (lesson == 61) { availableLessons.text += " 	Breakfast: Spanish Tortilla with Spinach and Feta	\n"; }
				if (lesson == 62) { availableLessons.text += " 	Lunch: Japanese Edamame and Tofu Salad	\n"; }
				if (lesson == 63) { availableLessons.text += " 	Dinner: Moroccan Spiced Salmon with Quinoa Pilaf	\n"; }
				if (lesson == 64) { availableLessons.text += " 	Dessert: French Napoleon	\n"; }
				if (lesson == 65) { availableLessons.text += " 	Breakfast: Indian Masala Oats with Vegetables	\n"; }
				if (lesson == 66) { availableLessons.text += " 	Lunch: Israeli Couscous and Vegetables	\n"; }
				if (lesson == 67) { availableLessons.text += " 	Dinner: Italian Grilled Chicken Breast with Ratatouille	\n"; }
				if (lesson == 68) { availableLessons.text += " 	Dessert: English Strawberries and cream	\n"; }
				if (lesson == 69) { availableLessons.text += " 	Breakfast: Mexican Huevos Rancheros with Avocado Salsa	\n"; }
				if (lesson == 70) { availableLessons.text += " 	Lunch: Vietnamese Vermicelli Salad with Grilled Shrimp	\n"; }
				if (lesson == 71) { availableLessons.text += " 	Dinner: Greek Lemon Herb Chicken with Roasted Vegetables	\n"; }
				if (lesson == 72) { availableLessons.text += " 	Dessert: Colombian Coconut Lime Sorbet	\n"; }
				if (lesson == 73) { availableLessons.text += " 	Breakfast: Lebanese Za'atar Omelet	\n"; }
				if (lesson == 74) { availableLessons.text += " 	Lunch: Thai Beef Salad with Peanut Dressing	\n"; }
				if (lesson == 75) { availableLessons.text += " 	Dinner: Indian Tandoori Fish with Cauliflower Rice	\n"; }
				if (lesson == 76) { availableLessons.text += " 	Dessert: Portuguese Pastel de Nata	\n"; }
				if (lesson == 77) { availableLessons.text += " 	Breakfast: Belgium Waffles with Berries	\n"; }
				if (lesson == 78) { availableLessons.text += " 	Lunch: Japanese Miso Soup with Tofu and Seaweed	\n"; }
				if (lesson == 79) { availableLessons.text += " 	Dinner: Moroccan Lamb Tagine with Couscous	\n"; }
				if (lesson == 80) { availableLessons.text += " 	Dessert: African Malva Pudding	\n"; }
				if (lesson == 81) { availableLessons.text += " 	Breakfast: Peruvian Humita	\n"; }
				if (lesson == 82) { availableLessons.text += " 	Lunch: Middle Eastern Falafel Salad with Tahini Dressing	\n"; }
				if (lesson == 83) { availableLessons.text += " 	Dinner: Italian Zucchini Noodles with Turkey Meatballs	\n"; }
				if (lesson == 84) { availableLessons.text += " 	Dessert: Chilean Leche Asada	\n"; }
				if (lesson == 85) { availableLessons.text += " 	Breakfast: German Potato Pancakes	\n"; }
				if (lesson == 86) { availableLessons.text += " 	Lunch: Egyptian Fatteh	\n"; }
				if (lesson == 87) { availableLessons.text += " 	Dinner: Thai Green Curry with Tofu and Vegetables	\n"; }
				if (lesson == 88) { availableLessons.text += " 	Dessert: Chinese Soy Milk Pudding	\n"; }
				if (lesson == 89) { availableLessons.text += " 	Breakfast: Mexican Egg Scramble with Black Beans and Avocado	\n"; }
				if (lesson == 90) { availableLessons.text += " 	Breakfast: Peruvian Humita	\n"; }
				if (lesson == 91) { availableLessons.text += " 	Lunch: Middle Eastern Falafel Salad with Tahini Dressing	\n"; }
				if (lesson == 92) { availableLessons.text += " 	Dinner: Italian Zucchini Noodles with Turkey Meatballs	\n"; }
				if (lesson == 93) { availableLessons.text += " 	Dessert: Chilean Leche Asada	\n"; }
				if (lesson == 94) { availableLessons.text += " 	Breakfast: German Potato Pancakes	\n"; }
				if (lesson == 95) { availableLessons.text += " 	Lunch: Egyptian Fatteh	\n"; }
				if (lesson == 96) { availableLessons.text += " 	Dinner: Thai Green Curry with Tofu and Vegetables	\n"; }
				if (lesson == 97) { availableLessons.text += " 	Dessert: Chinese Soy Milk Pudding	\n"; }
				if (lesson == 98) { availableLessons.text += " 	Breakfast: Mexican Egg Scramble with Black Beans and Avocado	\n"; }
				if (lesson == 99) { availableLessons.text += " 	Lunch: Vietnamese Vermicelli Noodle Salad with Shrimp	\n"; }
				if (lesson == 100) { availableLessons.text += " 	Dinner: Indian Spiced Baked Salmon with Cauliflower Rice	\n"; }
				if (lesson == 101) { availableLessons.text += " 	Dessert: Greek Orange Yogurt Cake	\n"; }
				if (lesson == 102) { availableLessons.text += " 	Breakfast: Spanish Omelette with Spinach and Feta Cheese	\n"; }
				if (lesson == 103) { availableLessons.text += " 	Lunch: American Avocado Black Bean Hamburger	\n"; }
				if (lesson == 104) { availableLessons.text += " 	Dinner: Italian Spaghetti and Meatballs	\n"; }
				if (lesson == 105) { availableLessons.text += " 	Breakfast: Egyptian Ful	\n"; }
				if (lesson == 106) { availableLessons.text += " 	Lunch: Brazilian Black Bean and Vegetable Stew	\n"; }
				if (lesson == 107) { availableLessons.text += " 	Dinner: Lebanese Grilled Chicken Kabobs with Tabbouleh	\n"; }
				if (lesson == 108) { availableLessons.text += " 	Dessert: Turkish Baked Apples with Walnuts and Cinnamon	\n"; }
				if (lesson == 109) { availableLessons.text += " 	Breakfast: Indian Masala Oatmeal with Spices and Raisins	\n"; }
				if (lesson == 110) { availableLessons.text += " 	Lunch: Thai Beef Salad with Lime Dressing	\n"; }
				if (lesson == 111) { availableLessons.text += " 	Dinner: Mexican Shrimp Fajitas with Whole Wheat Tortillas	\n"; }
				if (lesson == 112) { availableLessons.text += " 	Dessert: Colombian Arroz Con Leche	\n"; }
				if (lesson == 113) { availableLessons.text += " 	Breakfast: Scandinavian Smoked Salmon and Dill Scramble	\n"; }
				if (lesson == 114) { availableLessons.text += " 	Lunch: Moroccan Quinoa Stuffed Bell Peppers	\n"; }
				if (lesson == 115) { availableLessons.text += " 	Dinner: Chinese Stir-Fried Chicken with Vegetables and Brown Rice	\n"; }
				if (lesson == 116) { availableLessons.text += " 	Dessert: Italian Baked Ricotta Cheesecake with Berries	\n"; }
				if (lesson == 117) { availableLessons.text += " 	Breakfast: Mediterranean Vegetable Frittata with Feta Cheese	\n"; }
				if (lesson == 118) { availableLessons.text += " 	Lunch: Japanese Sushi Bowl with Tuna and Avocado	\n"; }
				if (lesson == 119) { availableLessons.text += " 	Dinner: Indian Tandoori Grilled Chicken with Cucumber Raita	\n"; }
				if (lesson == 120) { availableLessons.text += " 	Dessert: Spanish Baked Pears with Almonds and Honey	\n"; }
				if (lesson == 121) { availableLessons.text += " 	Breakfast: Mexican-Style Veggie Omelet	\n"; }
				if (lesson == 122) { availableLessons.text += " 	Lunch: Greek Quinoa Salad with Grilled Chicken	\n"; }
				if (lesson == 123) { availableLessons.text += " 	Dinner: Thai Yellow Curry with Chicken and Vegetables	\n"; }
				if (lesson == 124) { availableLessons.text += " 	Dessert: Baked Apples with Cinnamon and Greek Yogurt	\n"; }
				if (lesson == 125) { availableLessons.text += " 	Breakfast: Spanish Tortilla with Spinach and Mushrooms	\n"; }
				if (lesson == 126) { availableLessons.text += " 	Lunch: Thai Coconut Shrimp Soup with Lemongrass and Vegetables	\n"; }
				if (lesson == 127) { availableLessons.text += " 	Dinner: Italian Herb Baked Salmon with Asparagus	\n"; }
				if (lesson == 128) { availableLessons.text += " 	Dessert: German Chocolate Cake with Fresh Strawberries	\n"; }
				if (lesson == 129) { availableLessons.text += " 	Breakfast: Japanese Pancakes	\n"; }
				if (lesson == 130) { availableLessons.text += " 	Lunch: Vietnamese Fresh Spring Rolls with Shrimp and Peanut Dipping Sauce	\n"; }
				if (lesson == 131) { availableLessons.text += " 	Dinner: Moroccan Spiced Chicken with Roasted Vegetables	\n"; }
				if (lesson == 132) { availableLessons.text += " 	Dessert - French Apple Tarte Tatin (Sugar-Free)	\n"; }
				if (lesson == 133) { availableLessons.text += " 	Breakfast: Mediterranean Egg Muffins with Spinach and Feta	\n"; }
				if (lesson == 134) { availableLessons.text += " 	Lunch: Thai Beef Salad with Lime Dressing	\n"; }
				if (lesson == 135) { availableLessons.text += " 	Dinner: Italian Baked Eggplant Parmesan with Quinoa	\n"; }
				if (lesson == 136) { availableLessons.text += " 	Dessert - Italian Affogato (Espresso with Vanilla Ice Cream)	\n"; }
				if (lesson == 137) { availableLessons.text += " 	Breakfast - Lebanese Labneh and Vegetable Wrap	\n"; }
				if (lesson == 138) { availableLessons.text += " 	Lunch - Middle Eastern Lentil Soup with Spinach	\n"; }
				if (lesson == 139) { availableLessons.text += " 	Dinner - Greek Lemon Chicken with Roasted Vegetables	\n"; }
				if (lesson == 140) { availableLessons.text += " 	Dessert: Thai Tropical Fruit Salad with Coconut Milk	\n"; }
				if (lesson == 141) { availableLessons.text += " 	Breakfast: Middle Eastern Shakshuka with Spinach and Feta	\n"; }
				if (lesson == 142) { availableLessons.text += " 	Lunch: Greek Chicken Souvlaki Skewers with Tzatziki Sauce	\n"; }
				if (lesson == 143) { availableLessons.text += " 	Dinner: Thai Basil Beef Stir-Fry with Cauliflower Rice	\n"; }
				if (lesson == 144) { availableLessons.text += " 	Dessert - Greek Baklava Bites (Sugar-Free)	\n"; }
				if (lesson == 145) { availableLessons.text += " 	Breakfast: Scandinavian Smoked Salmon and Dill Omelette	\n"; }
				if (lesson == 146) { availableLessons.text += " 	Lunch - Mexican Chicken Fajita Bowl	\n"; }
				if (lesson == 147) { availableLessons.text += " 	Dinner - African Piri Piri Chicken	\n"; }
				if (lesson == 148) { availableLessons.text += " 	Dessert - Italian Lemon Ricotta Cake (Sugar-Free)	\n"; }
				if (lesson == 149) { availableLessons.text += " 	Breakfast: Mexican Chilaquiles	\n"; }
				if (lesson == 150) { availableLessons.text += " 	Breakfast: Middle Eastern Shakshuka	\n"; }
				if (lesson == 151) { availableLessons.text += " 	Breakfast: Indian Vegetable Upma	\n"; }
				if (lesson == 152) { availableLessons.text += " 	Breakfast: Japanese 	\n"; }
				if (lesson == 153) { availableLessons.text += " 	Breakfast: Russian cottage cheese pancakes (Syrniki)	\n"; }
				if (lesson == 154) { availableLessons.text += " 	Breakfast: Mediterranean Greek Yogurt Parfait	\n"; }
				if (lesson == 155) { availableLessons.text += " 	Breakfast: American Veggie Omelet with Spinach and Feta	\n"; }
				if (lesson == 156) { availableLessons.text += " 	Breakfast: Chinese Congee	\n"; }
				if (lesson == 157) { availableLessons.text += " 	Breakfast: Israeli Shakshuka	\n"; }
				if (lesson == 158) { availableLessons.text += " 	Breakfast: Bulgarian Banitsa	\n"; }
				if (lesson == 159) { availableLessons.text += " 	Lunch: Greek Salad with Grilled Chicken	\n"; }
				if (lesson == 160) { availableLessons.text += " 	Lunch: Japanese Sashimi Salad	\n"; }
				if (lesson == 161) { availableLessons.text += " 	Lunch: Mexican Chicken Fajita Bowl	\n"; }
				if (lesson == 162) { availableLessons.text += " 	Lunch: Indian Chana Masala	\n"; }
				if (lesson == 163) { availableLessons.text += " 	Lunch: Italian Caprese Stuffed Portobello Mushrooms	\n"; }
				if (lesson == 164) { availableLessons.text += " 	Lunch: Thai Chicken Satay with Peanut Sauce	\n"; }
				if (lesson == 165) { availableLessons.text += " 	Lunch: Moroccan Quinoa Salad	\n"; }
				if (lesson == 166) { availableLessons.text += " 	Lunch: French Ratatouille	\n"; }
				if (lesson == 167) { availableLessons.text += " 	Lunch: Middle Eastern Falafel Salad	\n"; }
				if (lesson == 168) { availableLessons.text += " 	Lunch: Spanish Shrimp and Chorizo Skewers	\n"; }
				if (lesson == 169) { availableLessons.text += " 	Lunch: Vietnamese Shrimp Summer Rolls	\n"; }
				if (lesson == 170) { availableLessons.text += " 	Lunch: Caribbean Jerk Chicken Lettuce Wraps	\n"; }
				if (lesson == 171) { availableLessons.text += " 	Lunch: Lebanese Tabbouleh with Grilled Halloumi	\n"; }
				if (lesson == 172) { availableLessons.text += " 	Lunch: Korean Bibimbap	\n"; }
				if (lesson == 173) { availableLessons.text += " 	Lunch: Brazilian Fish Moqueca	\n"; }
				if (lesson == 174) { availableLessons.text += " 	Dinner: Ethiopian Misir Wot (Spicy Lentil Stew)	\n"; }
				if (lesson == 175) { availableLessons.text += " 	Dinner: Thai Larb Gai (Spicy Chicken Salad)	\n"; }
				if (lesson == 176) { availableLessons.text += " 	Dinner: Lebanese Mujaddara (Lentils and Rice)	\n"; }
				if (lesson == 177) { availableLessons.text += " 	Dinner: Indian Palak Paneer (Spinach and Cottage Cheese Curry)	\n"; }
				if (lesson == 178) { availableLessons.text += " 	Dinner: Mexican Chicken Tinga	\n"; }
				if (lesson == 179) { availableLessons.text += " 	Dinner: Bolivian Quinoa Soup	\n"; }
				if (lesson == 180) { availableLessons.text += " 	Dinner: Moroccan Vegetable Tagine	\n"; }
				if (lesson == 181) { availableLessons.text += " 	Dinner: Brazilian Moqueca de Camarão (Shrimp Stew)	\n"; }
				if (lesson == 182) { availableLessons.text += " 	Dinner: Turkish Imam Bayildi (Stuffed Eggplant)	\n"; }
				if (lesson == 183) { availableLessons.text += " 	Dinner: Greek Spanakorizo (Spinach and Rice)	\n"; }
				if (lesson == 184) { availableLessons.text += " 	Dessert: French Raspberry Clafoutis	\n"; }
				if (lesson == 185) { availableLessons.text += " 	Dessert: Paraguayan Mbeyu	\n"; }
				if (lesson == 186) { availableLessons.text += " 	Dessert: Japanese Matcha Green Tea Mochi	\n"; }
				if (lesson == 187) { availableLessons.text += " 	Dessert: Spanish Orange Flan	\n"; }
				if (lesson == 188) { availableLessons.text += " 	Dessert: Indian Saffron Cardamom Lassi	\n"; }
				if (lesson == 189) { availableLessons.text += " 	Dessert: Turkish Walnut Baklava	\n"; }
				if (lesson == 190) { availableLessons.text += " 	Dessert: Danish Almond Raspberry Tart	\n"; }
				if (lesson == 191) { availableLessons.text += " 	Dessert: Brazilian Coconut Brigadeiros	\n"; }
				if (lesson == 192) { availableLessons.text += " 	Dessert: Argentinean Quince and Cheese Tart	\n"; }
				if (lesson == 193) { availableLessons.text += " 	Dessert: Swedish Cardamom Almond Cake	\n"; }
				if (lesson == 194) { availableLessons.text += " 	Dessert: British Summer Berry Trifle	\n"; }
				if (lesson == 195) { availableLessons.text += " 	Blackberry Greek Yogurt Cheesecake	\n"; }
			}
            else {
				if (countMisses <= maximumMisses) {
                    missingLessons.text += "Buy " + missing + " to complete recipe \n" + lesson;
					//    if (lesson == 1) { missingLessons.text += "(Desserts) Strawberry Graham Cracker Tarts - net222 \n\n"; }
					if (lesson == 1) { missingLessons.text += "	Mexican-inspired Egg and Vegetable Scramble	\n"; }
					if (lesson == 2) { missingLessons.text += "	Lunch: Greek Salad with Grilled Chicken	\n"; }
					if (lesson == 3) { missingLessons.text += "	Dinner: Indian Spiced Lentil Curry with Cauliflower Rice	\n"; }
					if (lesson == 4) { missingLessons.text += "	Dessert: Baked Cinnamon Apple Slices with Yogurt Topping	\n"; }
					if (lesson == 5) { missingLessons.text += "	Breakfast: Mediterranean Vegetable Omelette	\n"; }
					if (lesson == 6) { missingLessons.text += "	Lunch: Thai Chicken Lettuce Wraps	\n"; }
					if (lesson == 7) { missingLessons.text += "	Dinner: Italian Baked Salmon with Roasted Vegetables	\n"; }
					if (lesson == 8) { missingLessons.text += "	Dessert: Cuban Chia Pudding with Fresh Berries	\n"; }
					if (lesson == 9) { missingLessons.text += "	Breakfast: Spanish-style Baked Eggs with Tomatoes and Peppers	\n"; }
					if (lesson == 10) { missingLessons.text += "	Lunch: Middle Eastern Chickpea Salad with Grilled Shrimp	\n"; }
					if (lesson == 11) { missingLessons.text += "	Dinner: Japanese Teriyaki Chicken with Steamed Brown Rice and Stir-Fried Vegetables	\n"; }
					if (lesson == 12) { missingLessons.text += "	Dessert: Greek Yogurt Parfait with Honey and Nuts	\n"; }
					if (lesson == 13) { missingLessons.text += "	Breakfast: Indian Masala Oats with Spinach and Turmeric	\n"; }
					if (lesson == 14) { missingLessons.text += "	Lunch: Mexican Chicken Fajita Bowl with Quinoa	\n"; }
					if (lesson == 15) { missingLessons.text += "	Dinner: Moroccan Spiced Grilled Lamb Chops with Roasted Cauliflower Couscous	\n"; }
					if (lesson == 16) { missingLessons.text += "	Dessert: Colombian tropical Fruit Salad	\n"; }
					if (lesson == 17) { missingLessons.text += "	Breakfast: Swedish Rye Bread with Smoked Salmon and Avocado	\n"; }
					if (lesson == 18) { missingLessons.text += "	Lunch: Vietnamese Vermicelli Noodle Salad with Grilled Shrimp	\n"; }
					if (lesson == 19) { missingLessons.text += "	Dinner: Greek Lemon Herb Roasted Chicken with Greek Salad	\n"; }
					if (lesson == 20) { missingLessons.text += "	Dessert: Baked Pear with Cinnamon and Greek Yogurt	\n"; }
					if (lesson == 21) { missingLessons.text += "	Breakfast: Indian Spiced Chickpea Pancakes with Mint Chutney	\n"; }
					if (lesson == 22) { missingLessons.text += "	Lunch: Thai Coconut Curry Soup with Tofu and Vegetables	\n"; }
					if (lesson == 23) { missingLessons.text += "	Dinner: Spanish Paella with Seafood and Saffron	\n"; }
					if (lesson == 24) { missingLessons.text += "	Dessert: Brazilian acai berry bowl	\n"; }
					if (lesson == 25) { missingLessons.text += "	Breakfast: Mexican Chilaquiles with Salsa and Guacamole	\n"; }
					if (lesson == 26) { missingLessons.text += "	Lunch: Greek Turkey Meatball Lettuce Wraps with Tzatziki Sauce	\n"; }
					if (lesson == 27) { missingLessons.text += "	Dinner: Moroccan Spiced Baked Fish with Roasted Vegetables	\n"; }
					if (lesson == 28) { missingLessons.text += "	Dessert: Banana berry smoothie	\n"; }
					if (lesson == 29) { missingLessons.text += "	Breakfast - Peruvian Vegetable Omelet	\n"; }
					if (lesson == 30) { missingLessons.text += "	Lunch - Thai Peanut Chicken Soup	\n"; }
					if (lesson == 31) { missingLessons.text += "	Dinner - Mexican Stuffed Bell Peppers	\n"; }
					if (lesson == 32) { missingLessons.text += "	Dessert - Greek yogurt berry ice cream	\n"; }
					if (lesson == 33) { missingLessons.text += "	Breakfast - Indian Spiced Lentil Scramble	\n"; }
					if (lesson == 34) { missingLessons.text += "	Lunch - Middle Eastern Quinoa Salad	\n"; }
					if (lesson == 35) { missingLessons.text += "	Dinner - Chinese orange chicken with teriyaki rice	\n"; }
					if (lesson == 36) { missingLessons.text += "	Dessert - Thai Coconut Cream Ice Cream	\n"; }
					if (lesson == 37) { missingLessons.text += "	Mexican Avocado Breakfast Toast	\n"; }
					if (lesson == 38) { missingLessons.text += "	Lunch - Greek Chicken Souvlaki Wrap	\n"; }
					if (lesson == 39) { missingLessons.text += "	Dinner - Moroccan Spiced Lentil Stew	\n"; }
					if (lesson == 40) { missingLessons.text += "	Dessert - Hawaiian Grilled Pineapple with Cinnamon	\n"; }
					if (lesson == 41) { missingLessons.text += "	Breakfast - Italian Caprese Frittata	\n"; }
					if (lesson == 42) { missingLessons.text += "	Lunch - Vietnamese Vermicelli Noodle Bowl	\n"; }
					if (lesson == 43) { missingLessons.text += "	Dinner - Indian Tandoori Chicken with Cauliflower Rice	\n"; }
					if (lesson == 44) { missingLessons.text += "	Dessert - Georgia Baked Peaches with Caramel Sauce (sugar-free)	\n"; }
					if (lesson == 45) { missingLessons.text += "	Breakfast - Spanish Tortilla with Spinach	\n"; }
					if (lesson == 46) { missingLessons.text += "	Lunch - Japanese Sushi Bowl with Seared Tuna	\n"; }
					if (lesson == 47) { missingLessons.text += "	Dinner - Lebanese Grilled Shrimp Skewers with Tabouli	\n"; }
					if (lesson == 48) { missingLessons.text += "	Dessert - Greek Yogurt Parfait with Pistachios and Honey	\n"; }
					if (lesson == 49) { missingLessons.text += "	Breakfast - Mexican Chia Seed Pudding with Tropical Fruit	\n"; }
					if (lesson == 50) { missingLessons.text += "	Lunch - Thai Coconut Curry Soup with Shrimp	\n"; }
					if (lesson == 51) { missingLessons.text += "	Dinner - Mediterranean Baked Cod with Lemon and Olives	\n"; }
					if (lesson == 52) { missingLessons.text += "	Dessert - Brazilian Lemon Cake	\n"; }
					if (lesson == 53) { missingLessons.text += "	Breakfast - Indian Masala Omelette with Spinach	\n"; }
					if (lesson == 54) { missingLessons.text += "	Lunch - Middle Eastern Falafel Salad	\n"; }
					if (lesson == 55) { missingLessons.text += "	Dinner - Italian Zucchini Noodles with Turkey Meatballs	\n"; }
					if (lesson == 56) { missingLessons.text += "	Dessert - Italian Berry Sorbet (sugar-free)	\n"; }
					if (lesson == 57) { missingLessons.text += "	Breakfast: German Fruit and Nut Oatmeal	\n"; }
					if (lesson == 58) { missingLessons.text += "	Lunch: Mexican Grilled Chicken Salad	\n"; }
					if (lesson == 59) { missingLessons.text += "	Dinner: Thai Shrimp Curry with Brown Rice	\n"; }
					if (lesson == 60) { missingLessons.text += "	Dessert: Greek Yogurt Parfait with Fresh Berries	\n"; }
					if (lesson == 61) { missingLessons.text += "	Breakfast: Spanish Tortilla with Spinach and Feta	\n"; }
					if (lesson == 62) { missingLessons.text += "	Lunch: Japanese Edamame and Tofu Salad	\n"; }
					if (lesson == 63) { missingLessons.text += "	Dinner: Moroccan Spiced Salmon with Quinoa Pilaf	\n"; }
					if (lesson == 64) { missingLessons.text += "	Dessert: French Napoleon	\n"; }
					if (lesson == 65) { missingLessons.text += "	Breakfast: Indian Masala Oats with Vegetables	\n"; }
					if (lesson == 66) { missingLessons.text += "	Lunch: Israeli Couscous and Vegetables	\n"; }
					if (lesson == 67) { missingLessons.text += "	Dinner: Italian Grilled Chicken Breast with Ratatouille	\n"; }
					if (lesson == 68) { missingLessons.text += "	Dessert: English Strawberries and cream	\n"; }
					if (lesson == 69) { missingLessons.text += "	Breakfast: Mexican Huevos Rancheros with Avocado Salsa	\n"; }
					if (lesson == 70) { missingLessons.text += "	Lunch: Vietnamese Vermicelli Salad with Grilled Shrimp	\n"; }
					if (lesson == 71) { missingLessons.text += "	Dinner: Greek Lemon Herb Chicken with Roasted Vegetables	\n"; }
					if (lesson == 72) { missingLessons.text += "	Dessert: Colombian Coconut Lime Sorbet	\n"; }
					if (lesson == 73) { missingLessons.text += "	Breakfast: Lebanese Za'atar Omelet	\n"; }
					if (lesson == 74) { missingLessons.text += "	Lunch: Thai Beef Salad with Peanut Dressing	\n"; }
					if (lesson == 75) { missingLessons.text += "	Dinner: Indian Tandoori Fish with Cauliflower Rice	\n"; }
					if (lesson == 76) { missingLessons.text += "	Dessert: Portuguese Pastel de Nata	\n"; }
					if (lesson == 77) { missingLessons.text += "	Breakfast: Belgium Waffles with Berries	\n"; }
					if (lesson == 78) { missingLessons.text += "	Lunch: Japanese Miso Soup with Tofu and Seaweed	\n"; }
					if (lesson == 79) { missingLessons.text += "	Dinner: Moroccan Lamb Tagine with Couscous	\n"; }
					if (lesson == 80) { missingLessons.text += "	Dessert: African Malva Pudding	\n"; }
					if (lesson == 81) { missingLessons.text += "	Breakfast: Peruvian Humita	\n"; }
					if (lesson == 82) { missingLessons.text += "	Lunch: Middle Eastern Falafel Salad with Tahini Dressing	\n"; }
					if (lesson == 83) { missingLessons.text += "	Dinner: Italian Zucchini Noodles with Turkey Meatballs	\n"; }
					if (lesson == 84) { missingLessons.text += "	Dessert: Chilean Leche Asada	\n"; }
					if (lesson == 85) { missingLessons.text += "	Breakfast: German Potato Pancakes	\n"; }
					if (lesson == 86) { missingLessons.text += "	Lunch: Egyptian Fatteh	\n"; }
					if (lesson == 87) { missingLessons.text += "	Dinner: Thai Green Curry with Tofu and Vegetables	\n"; }
					if (lesson == 88) { missingLessons.text += "	Dessert: Chinese Soy Milk Pudding	\n"; }
					if (lesson == 89) { missingLessons.text += "	Breakfast: Mexican Egg Scramble with Black Beans and Avocado	\n"; }
					if (lesson == 90) { missingLessons.text += "	Breakfast: Peruvian Humita	\n"; }
					if (lesson == 91) { missingLessons.text += "	Lunch: Middle Eastern Falafel Salad with Tahini Dressing	\n"; }
					if (lesson == 92) { missingLessons.text += "	Dinner: Italian Zucchini Noodles with Turkey Meatballs	\n"; }
					if (lesson == 93) { missingLessons.text += "	Dessert: Chilean Leche Asada	\n"; }
					if (lesson == 94) { missingLessons.text += "	Breakfast: German Potato Pancakes	\n"; }
					if (lesson == 95) { missingLessons.text += "	Lunch: Egyptian Fatteh	\n"; }
					if (lesson == 96) { missingLessons.text += "	Dinner: Thai Green Curry with Tofu and Vegetables	\n"; }
					if (lesson == 97) { missingLessons.text += "	Dessert: Chinese Soy Milk Pudding	\n"; }
					if (lesson == 98) { missingLessons.text += "	Breakfast: Mexican Egg Scramble with Black Beans and Avocado	\n"; }
					if (lesson == 99) { missingLessons.text += "	Lunch: Vietnamese Vermicelli Noodle Salad with Shrimp	\n"; }
					if (lesson == 100) { missingLessons.text += "	Dinner: Indian Spiced Baked Salmon with Cauliflower Rice	\n"; }
					if (lesson == 101) { missingLessons.text += "	Dessert: Greek Orange Yogurt Cake	\n"; }
					if (lesson == 102) { missingLessons.text += "	Breakfast: Spanish Omelette with Spinach and Feta Cheese	\n"; }
					if (lesson == 103) { missingLessons.text += "	Lunch: American Avocado Black Bean Hamburger	\n"; }
					if (lesson == 104) { missingLessons.text += "	Dinner: Italian Spaghetti and Meatballs	\n"; }
					if (lesson == 105) { missingLessons.text += "	Breakfast: Egyptian Ful	\n"; }
					if (lesson == 106) { missingLessons.text += "	Lunch: Brazilian Black Bean and Vegetable Stew	\n"; }
					if (lesson == 107) { missingLessons.text += "	Dinner: Lebanese Grilled Chicken Kabobs with Tabbouleh	\n"; }
					if (lesson == 108) { missingLessons.text += "	Dessert: Turkish Baked Apples with Walnuts and Cinnamon	\n"; }
					if (lesson == 109) { missingLessons.text += "	Breakfast: Indian Masala Oatmeal with Spices and Raisins	\n"; }
					if (lesson == 110) { missingLessons.text += "	Lunch: Thai Beef Salad with Lime Dressing	\n"; }
					if (lesson == 111) { missingLessons.text += "	Dinner: Mexican Shrimp Fajitas with Whole Wheat Tortillas	\n"; }
					if (lesson == 112) { missingLessons.text += "	Dessert: Colombian Arroz Con Leche	\n"; }
					if (lesson == 113) { missingLessons.text += "	Breakfast: Scandinavian Smoked Salmon and Dill Scramble	\n"; }
					if (lesson == 114) { missingLessons.text += "	Lunch: Moroccan Quinoa Stuffed Bell Peppers	\n"; }
					if (lesson == 115) { missingLessons.text += "	Dinner: Chinese Stir-Fried Chicken with Vegetables and Brown Rice	\n"; }
					if (lesson == 116) { missingLessons.text += "	Dessert: Italian Baked Ricotta Cheesecake with Berries	\n"; }
					if (lesson == 117) { missingLessons.text += "	Breakfast: Mediterranean Vegetable Frittata with Feta Cheese	\n"; }
					if (lesson == 118) { missingLessons.text += "	Lunch: Japanese Sushi Bowl with Tuna and Avocado	\n"; }
					if (lesson == 119) { missingLessons.text += "	Dinner: Indian Tandoori Grilled Chicken with Cucumber Raita	\n"; }
					if (lesson == 120) { missingLessons.text += "	Dessert: Spanish Baked Pears with Almonds and Honey	\n"; }
					if (lesson == 121) { missingLessons.text += "	Breakfast: Mexican-Style Veggie Omelet	\n"; }
					if (lesson == 122) { missingLessons.text += "	Lunch: Greek Quinoa Salad with Grilled Chicken	\n"; }
					if (lesson == 123) { missingLessons.text += "	Dinner: Thai Yellow Curry with Chicken and Vegetables	\n"; }
					if (lesson == 124) { missingLessons.text += "	Dessert: Baked Apples with Cinnamon and Greek Yogurt	\n"; }
					if (lesson == 125) { missingLessons.text += "	Breakfast: Spanish Tortilla with Spinach and Mushrooms	\n"; }
					if (lesson == 126) { missingLessons.text += "	Lunch: Thai Coconut Shrimp Soup with Lemongrass and Vegetables	\n"; }
					if (lesson == 127) { missingLessons.text += "	Dinner: Italian Herb Baked Salmon with Asparagus	\n"; }
					if (lesson == 128) { missingLessons.text += "	Dessert: German Chocolate Cake with Fresh Strawberries	\n"; }
					if (lesson == 129) { missingLessons.text += "	Breakfast: Japanese Pancakes	\n"; }
					if (lesson == 130) { missingLessons.text += "	Lunch: Vietnamese Fresh Spring Rolls with Shrimp and Peanut Dipping Sauce	\n"; }
					if (lesson == 131) { missingLessons.text += "	Dinner: Moroccan Spiced Chicken with Roasted Vegetables	\n"; }
					if (lesson == 132) { missingLessons.text += "	Dessert - French Apple Tarte Tatin (Sugar-Free)	\n"; }
					if (lesson == 133) { missingLessons.text += "	Breakfast: Mediterranean Egg Muffins with Spinach and Feta	\n"; }
					if (lesson == 134) { missingLessons.text += "	Lunch: Thai Beef Salad with Lime Dressing	\n"; }
					if (lesson == 135) { missingLessons.text += "	Dinner: Italian Baked Eggplant Parmesan with Quinoa	\n"; }
					if (lesson == 136) { missingLessons.text += "	Dessert - Italian Affogato (Espresso with Vanilla Ice Cream)	\n"; }
					if (lesson == 137) { missingLessons.text += "	Breakfast - Lebanese Labneh and Vegetable Wrap	\n"; }
					if (lesson == 138) { missingLessons.text += "	Lunch - Middle Eastern Lentil Soup with Spinach	\n"; }
					if (lesson == 139) { missingLessons.text += "	Dinner - Greek Lemon Chicken with Roasted Vegetables	\n"; }
					if (lesson == 140) { missingLessons.text += "	Dessert: Thai Tropical Fruit Salad with Coconut Milk	\n"; }
					if (lesson == 141) { missingLessons.text += "	Breakfast: Middle Eastern Shakshuka with Spinach and Feta	\n"; }
					if (lesson == 142) { missingLessons.text += "	Lunch: Greek Chicken Souvlaki Skewers with Tzatziki Sauce	\n"; }
					if (lesson == 143) { missingLessons.text += "	Dinner: Thai Basil Beef Stir-Fry with Cauliflower Rice	\n"; }
					if (lesson == 144) { missingLessons.text += "	Dessert - Greek Baklava Bites (Sugar-Free)	\n"; }
					if (lesson == 145) { missingLessons.text += "	Breakfast: Scandinavian Smoked Salmon and Dill Omelette	\n"; }
					if (lesson == 146) { missingLessons.text += "	Lunch - Mexican Chicken Fajita Bowl	\n"; }
					if (lesson == 147) { missingLessons.text += "	Dinner - African Piri Piri Chicken	\n"; }
					if (lesson == 148) { missingLessons.text += "	Dessert - Italian Lemon Ricotta Cake (Sugar-Free)	\n"; }
					if (lesson == 149) { missingLessons.text += "	Breakfast: Mexican Chilaquiles	\n"; }
					if (lesson == 150) { missingLessons.text += "	Breakfast: Middle Eastern Shakshuka	\n"; }
					if (lesson == 151) { missingLessons.text += "	Breakfast: Indian Vegetable Upma	\n"; }
					if (lesson == 152) {missingLessons.text +=  "	Breakfast: Japanese Tamagoyaki	\n"; }
					if (lesson == 153) { missingLessons.text += "	Breakfast: Russian cottage cheese pancakes (Syrniki)	\n"; }
					if (lesson == 154) { missingLessons.text += "	Breakfast: Mediterranean Greek Yogurt Parfait	\n"; }
					if (lesson == 155) { missingLessons.text += "	Breakfast: American Veggie Omelet with Spinach and Feta	\n"; }
					if (lesson == 156) { missingLessons.text += "	Breakfast: Chinese Congee	\n"; }
					if (lesson == 157) { missingLessons.text += "	Breakfast: Israeli Shakshuka	\n"; }
					if (lesson == 158) { missingLessons.text += "	Breakfast: Bulgarian Banitsa	\n"; }
					if (lesson == 159) { missingLessons.text += "	Lunch: Greek Salad with Grilled Chicken	\n"; }
					if (lesson == 160) { missingLessons.text += "	Lunch: Japanese Sashimi Salad	\n"; }
					if (lesson == 161) { missingLessons.text += "	Lunch: Mexican Chicken Fajita Bowl	\n"; }
					if (lesson == 162) { missingLessons.text += "	Lunch: Indian Chana Masala	\n"; }
					if (lesson == 163) { missingLessons.text += "	Lunch: Italian Caprese Stuffed Portobello Mushrooms	\n"; }
					if (lesson == 164) { missingLessons.text += "	Lunch: Thai Chicken Satay with Peanut Sauce	\n"; }
					if (lesson == 165) { missingLessons.text += "	Lunch: Moroccan Quinoa Salad	\n"; }
					if (lesson == 166) { missingLessons.text += "	Lunch: French Ratatouille	\n"; }
					if (lesson == 167) { missingLessons.text += "	Lunch: Middle Eastern Falafel Salad	\n"; }
					if (lesson == 168) { missingLessons.text += "	Lunch: Spanish Shrimp and Chorizo Skewers	\n"; }
					if (lesson == 169) { missingLessons.text += "	Lunch: Vietnamese Shrimp Summer Rolls	\n"; }
					if (lesson == 170) { missingLessons.text += "	Lunch: Caribbean Jerk Chicken Lettuce Wraps	\n"; }
					if (lesson == 171) { missingLessons.text += "	Lunch: Lebanese Tabbouleh with Grilled Halloumi	\n"; }
					if (lesson == 172) { missingLessons.text += "	Lunch: Korean Bibimbap	\n"; }
					if (lesson == 173) { missingLessons.text += "	Lunch: Brazilian Fish Moqueca	\n"; }
					if (lesson == 174) { missingLessons.text += "	Dinner: Ethiopian Misir Wot (Spicy Lentil Stew)	\n"; }
					if (lesson == 175) { missingLessons.text += "	Dinner: Thai Larb Gai (Spicy Chicken Salad)	\n"; }
					if (lesson == 176) { missingLessons.text += "	Dinner: Lebanese Mujaddara (Lentils and Rice)	\n"; }
					if (lesson == 177) { missingLessons.text += "	Dinner: Indian Palak Paneer (Spinach and Cottage Cheese Curry)	\n"; }
					if (lesson == 178) { missingLessons.text += "	Dinner: Mexican Chicken Tinga	\n"; }
					if (lesson == 179) { missingLessons.text += "	Dinner: Bolivian Quinoa Soup	\n"; }
					if (lesson == 180) { missingLessons.text += "	Dinner: Moroccan Vegetable Tagine	\n"; }
					if (lesson == 181) { missingLessons.text += "	Dinner: Brazilian Moqueca de Camarão (Shrimp Stew)	\n"; }
					if (lesson == 182) { missingLessons.text += "	Dinner: Turkish Imam Bayildi (Stuffed Eggplant)	\n"; }
					if (lesson == 183) { missingLessons.text += "	Dinner: Greek Spanakorizo (Spinach and Rice)	\n"; }
					if (lesson == 184) { missingLessons.text += "	Dessert: French Raspberry Clafoutis	\n"; }
					if (lesson == 185) { missingLessons.text += "	Dessert: Paraguayan Mbeyu	\n"; }
					if (lesson == 186) { missingLessons.text += "	Dessert: Japanese Matcha Green Tea Mochi	\n"; }
					if (lesson == 187) { missingLessons.text += "	Dessert: Spanish Orange Flan	\n"; }
					if (lesson == 188) { missingLessons.text += "	Dessert: Indian Saffron Cardamom Lassi	\n"; }
					if (lesson == 189) { missingLessons.text += "	Dessert: Turkish Walnut Baklava	\n"; }
					if (lesson == 190) { missingLessons.text += "	Dessert: Danish Almond Raspberry Tart	\n"; }
					if (lesson == 191) { missingLessons.text += "	Dessert: Brazilian Coconut Brigadeiros	\n"; }
					if (lesson == 192) { missingLessons.text += "	Dessert: Argentinean Quince and Cheese Tart	\n"; }
					if (lesson == 193) { missingLessons.text += "	Dessert: Swedish Cardamom Almond Cake	\n"; }
					if (lesson == 194) { missingLessons.text += "	Dessert: British Summer Berry Trifle	\n"; }
					if (lesson == 195) { missingLessons.text += "	Blackberry Greek Yogurt Cheesecake	\n"; }
				}//next2

                numMissingLessons++;

			}
		}

		var textSize = missingLessons.GetComponent<RectTransform> ();
		var parentSize = missingLessons.transform.parent.GetComponent<RectTransform> ();
		parentSize.offsetMax = new Vector2(parentSize.offsetMax.x, numMissingLessons * 20);

	}

}