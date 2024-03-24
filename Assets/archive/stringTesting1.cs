using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//make list in excel, make them all true
public class stringTesting1 : MonoBehaviour 
{

    public bool selectAllBool;

	public GameObject ButtonPrefab;
	public GameObject Parent;

    private string[] allItems = new string[]{
        //quickly consumed + recipes
        "Apple*C",
        //"Apricots*C",
        //"DriedApricots*C",
        "Avocado*F",
        "Bagelx",
        "Bananas*C",
        //"Basil*",
        "Blueberries*C",
        "Bread*C",
        "Cereal*C",
        //"Cantaloupe*C",
        "Carrot*C",
        "CherryTomatoes*",
        //"ChickenWingsx",
        "CocoaPowder*",
        //"Corn*C",
        "CousCous*C",
        "Eggs* *F w/ yolk",
        "FishSauce*",
        "FlankSteak*",
        //"FreshBasil*",
        "FreshCilantro*",
        "FreshMint*",
        //"FreshMozzarella*F",
        "FreshRosemary*", 
        //"FreshParmesan*F",
        "FreshParsley*",
        "FreshGinger*",
        "FreshGarlic*",
        //"GoatCheese*F",
        //"GreenOnions*",
        //"GrannySmithApple*C",
        //"GroundBeef*",
        "HalfandHalf*F",
        "JalapenoPeppers*",
        "KidneyBeans*C",
        //"Grapes*",
        "GreenBeans*",
        "GroundTurkey*",
        //"Ham*",
        "Iceberg*",
        //"KiwiI*",
        "Lemons*",
        "Lentils*C",
        "Limes*",
        "LimaBeans*C",
        //"Nectarines*C",
        "Oats*C",
        "Onions*",
        //"Oranges*C",
        "Orzo*C",
        //"Peaches*",
        "Pears*",
        //"Pineapple*",
        "PintoBeans*C",
        //"Plums*",
        "PorkChops*",
        "PorkTenderloin*",//added
        "Potatoes*C",
        //"PizzaSaucex",
        "RedBellPepper*",
        "RedOnions*",
        "SaladGreens*",
        "SoyMilk",
        "Spinach",
        //"SweetPotatoes*",
        //"Tofu*",
        "Tomato*",
        "TomatoSauce*",
        "TomatoJuice*",
        "TomatoPaste*",
        //"Watermelon*",
        "YellowBellPepper*",
        //"Yams*",
        "Yogurt*",

        //staples
        "A1*", 
        "AllPurposeFlour*C",
        "Almonds*C",
        //"Amaranth*",
        "AppleCiderVinegar*",
        "BakingPowder*",
        "BakingSoda*",
        "BalsamicVinegar*",
        "BananaPeppers*",
        //"Barley*",
        "BayLeaves*",
        "Beerx",
        "BBQSaucex",
        "BlackBeans*",
        "BlackOlives*",
        "BlackPepper*",
        "BlockCheddarCheese*F",
        "BlueCheese*F",
        "Breadcrumbs*C",
        "BrownMustard*",
        "BrownSugarx",
        //"Buckwheat*",
        "Butterx",
        "ButterSpray*",
        "Caesar*",
        "CajunSeasoning*",
        "Candyx",
        "CanGreenChiles*",
        "Cannelini Beans*",
        "CanolaOil*F",
        "Cardamom*",
        "CayennePepper*",
        "CelerySeed*",
        "ChickenBreast*",
        "ChickenBroth*",
        "ChiliPaste*",
        "ChiliPowder*",
        "Chinese5Spice*",
        "Cinnamon*",
        "Cloves*",
        "CocktailSaucex",
        "CoconutOil*F",
        "Cod*",
        "CookingSpray*",//added
        "Coriander*",
        //"CornTortillas*C",
        "CornMealx",
        "Cornstarch*",
        "CourseDijon*",
        "CreamCheese*",
        "CreamOfTartar*",
        "CrushedRedPepper*",
        "CucumberRanch*",
        "Cumin*",
        "Curry*",
        "DicedTomatoes*",
        "Dijon*",
        "DrySherry*",
        "DryWhiteWine*",
        "DryYeast*",
        "EvaporatedFFMilkx",
        "Fennel*",
        "FetaCheese*F",
        "Figsx",
        "Flaxseed*",
        "FlourTortilla*C",
        "GarlicPowder*",
        "GarlicSalt*",
        "Ginger*",
        "GroundMustard*",
        "GroundRedPepper*",
        "HomemadeBreadcrumbs*",
        //"Horseradish*",
        "HotPepperSauce*",
        "InstantOats*",
        "Ketchup*M",
        "LasagnaNoodles*Rec",
        "LemonPepper*",
        "MacadamiaNuts*F",
        "MaltVinegar*",
        "Mango*C",
        "MapleSyrupx",
        "Mayonnaise*",
        "Meatballs",
        "Milk",
        "MincedGarlic",
        "MincedOnion",
        "MixedBerryBerries*",
        "MixedBerryTropical*",
        "Molasses*",
        "MrsDashLemon*",
        "MrsDashTable*",
        "Mushrooms*",
        "Nutmeg*",
        "OldBaySeasoning*",
        "OliveOil*F",
        "OnionPowder*",
        "OnionSalt*",
        "Oregano*",
        "PankoBreadcrumbs*C", //added
        "Paprika*",
        "Parmesan*F",
        "PastaSaucex*Rec",
        "ParsleyFlakes*",
        "PeanutButter*F",
        "PeanutOil*F",
        "Peanuts*F",
        "PearlOnions*",
        "Peas*C", 
        "Penne*C",
        "Peppercorn*",
        "Pepperoni x",
        "Pesto x",
        "PineNuts*F",
        "PizzaDough*Rec",
        "PoultrySeasoning*",
        "Popcorn*",
        "PumpkinSeeds*F",
        "Quinoa*C",
        "Raisins *C",
        "Ranch *LF",
        "RaspberryVinaigrette *LF",
        "RedCurryPaste*",
        "RedWineVinegar*",
        "RefriedBeans*C",
        "Rice*C",
        "RiceVinegar*",
        "Ricotta*F",
        "Rosemary*",
        "SafflowerOil*F",
        "Salsa*",
        "Salt*",
        "Sausage*",
        "SesameOil*F",
        "Shrimp*",
        "SmokedPaprika*", //added
        "SourCream*",
        "SoyCheese*",
        "SoySauce*",
        "Spaghetti*M",
        //"Spelt",
        "SpiralPasta*M",
        "SteakSeasoning*",
        "Stevia*",
        "Strawberries*C",
        "SunflowerOil*F",
        "Tapioca x",
        "Tarragon*",
        "TartarSauce *Rec",
        "ThousandIsland*LF",
        "Thyme*",
        "Tuna*",
        "TurkeyDogs*",
        "Turmeric*",
        "UnbleachedFlour*",
        "VanillaExtract*",
        "VeggieBurgers*",
        "Vermicelli*WW",
        "Water*",
        "Waffle*WW",
        "WheatBran*",
        "WhiteBread x",//Added
        "WhitePepper*",
        "WhiteWineVinegar*",
        "WholeWheatFlour*",
        "WingSauce x",
        "Worcestershire*",
    };
        
	private bool[] itemStates;

    private string[][] lessons = new string[][] {
        //1. Crispy Potato Skin Wedges Phillips6
        new string[] {"BlackPepper", "CanolaOil","Paprika","Potatoes","Salt"},
        //2. French Fries  Phillips7
        new string[] {"OliveOil", "Potatoes"},
        //3. Potato Croquettes Phillips 8
        new string[] {"AllPurposeFlour", "BlackPepper", "Breadcrumbs", "FreshChives", "Eggs", "Nutmeg", "Parmesan", "Potatoes", "VegetableOil"},
        //4. Potato Au Gratin  Phillips9
        new string[] {"BlackPepper", "Gruyere", "Milk", "Nutmeg", "Potatoes"},
        //5. Rosemary Russet Potato Potato Chips   Phillips10
        new string[] {"OliveOil","Potatoes","Rosemary","Salt"},
        //6. Roasted Winter Veggies Phillips11
        new string[] {"BlackPepper", "ButternutSquash", "Celery", "FreshThyme", "OliveOil", "Parsnips", "RedOnions", "Salt"},
        //7. Fried Meatballs in Tomato Sauce   Phillips12
        new string[] {"BlackPepper","Breadcrumbs","Eggs","FreshParsley","FreshThyme","GroundBeef","Onions","Salt"},
        //8. Bacon Wrapped Shrimp   Phillips13
        new string[] {"Bacon","Shrimp"},
        //9. Cheddar Bacon Croquette    Phillips14
        new string[] {"AllPurposeFlour","Bacon","BlockCheddarCheese","Breadcrumbs","Eggs","OliveOil"},
        //10. Crispy Fried Spring Rolls Phillips15
        new string[] {"Carrot","Celery","ChickenBreast","ChickenStockPowder","Cornstarch","Eggs","FreshGinger","Mushrooms","SpringRollWrappers","VegetableOil"},
        //11. Crab Croquettes   Phillips16
        new string[] {"AllPurposeFlour","CayennePepper","Celery","Eggs","EggWhites","FreshChives","FreshParsley","FreshTarragon","LumpCrab","Mayonnaise","OliveOil","PankoBreadcrumbs","RedBellPepper","RedOnions","Salt","SourCream"},
        //12. FetaTriangles  Phillips17
        new string[] {"BlackPepper","EggYolk","FetaCheese","FiloPastry","FreshParsley","OliveOil","Scallion"},
        //13. Korean BBQ Satay Phillips18
        new string[] {"BlackPepper","BonelessChickenBreast","FreshGarlic","FreshGinger","LowSodiumSoySauce","PineappleJuice","Scallion","SesameOil"},
        //14. Jerk Chicken Wings    Phillips19
        new string[] {"AllSpice","BrownSugar","CayennePepper","ChickenWings","Cinnamon","FreshGarlic","FreshGinger","FreshThyme","HabaneroPepper","LimeJuice","OliveOil","RedWineVinegar","Salt","Scallion","SoySauce","WhitePepper"},
        //15. Morrocon Meatballs with Mint Yogurt   Phillips21
        new string [] {"Buttermilk",
            "Corriander",
            "Cumin",
            "EggWhites",
            "FreshGarlic",
            "FreshMint",
            "FreshMint",
            "FreshParsley",
            "GroundLamb",
            "GroundTurkey",
            "Yogurt",
            "OliveOil",
            "RedChiliPaste",
            "Salt",
            "SourCream"
            },

        //16. Pigs in a Blanket Phillips21
        new string[] {"CanCrescentRolls",
            "CocktailFranks",
            },

        //17.  Stuffed Garlic Mushrooms Phillips22
        new string[] {"BlackPepper",
            "ButtonMushrooms",
            "FreshGarlic",
            "FreshParsley",
            "OliveOil",
            "WhiteBread"
            },

        //18. Chimichurri Skirt Steak   Phillips23
        new string[] {
            "BlackPepper",
            "CayennePepper",
            "CrushedRedPepper",
            "Cumin",
            "FreshGarlic",
            "FreshMint",
            "FreshOregano",
            "FreshParsley",
            "OliveOil",
            "RedWineVinegar",
            "Salt",
            "SkirtSteak",
            "SmokedPaprika"
        },

        //19. Roasted Heirloom Tomato with Baked Feta   Phillips24
        new string[] {"BlockFetaCheese",
            "Cloves",
            "FreshBasil",
            "FreshParmesan",
            "FreshParsley",
            "HeirloomTomatoes",
            "OliveOil",
            "OliveOil",
            "PineNuts",
            "RedOnions",
            "Salt"
            },

        //20. Portabella Pepperoni Pizza    Phillips25
        new string[] {"ItalianSeasonings",
            "OliveOil",
            "Pepperoni",
            "PortabellaMushrooms",
            "Salt",
            "ShreddedMozzarella",
            "TomatoSauce"
            },

        //21. Mushroom Onion and Feta Frittata  Phillips26
        new string [] {"ButtonMushrooms",
            "Eggs",
            "FetaCheese",
            "OliveOil",
            "RedOnions",
            "Salt"
            },

        //22.Roasted Rack of Lmab with Macadamia Crust  Phillips27
        new string [] {"BlackPepper",
            "Cloves",
            "Eggs",
            "FreshRosemary",
            "HomemadeBreadcrumbs",
            "MacadamiaNuts",
            "OliveOil",
            "RackOfLamb",
            "Salt"
            },

        //23.Salmon with Dill Sauce Phillips28
        new string []{"FreshDill",
            "Yogurt",
            "OliveOil",
            "Salmon",
            "Salt",
            "SourCream"
            },

        //24. Teriyaki Glazed Halibut Steak Phillips29
        new string [] {"FreshGarlic",
            "Ginger",
            "HalibutSteak",
            "LimeJuice",
            "Mirin",
            "OrangeJuice",
            "RedPepperFlakes",
            "SoySauce",
            "Sugar"
            },

        //25. Cajun Shrimp  Phillips30
        new string [] {"CayennePepper",
            "OldBaySeasoning",
            "OliveOil",
            "Salt",
            "Shrimp",
            "SmokedPaprika"
            },

        //26.Cod Fish Nuggets   Phillips31
        new string [] {"AllPurposeFlour",
            "Cod",
            "Eggs",
            "OliveOil",
            "PankoBreadcrumbs",
            "Salt"
            },

        //27. Country Chicken Tenders Phillips32
        new string []{"AllPurposeFlour",
            "BlackPepper",
            "ChickenBreast",
            "Eggs",
            "OliveOil",
            "Salt",
            "Breadcrumbs"
            },

        //29. Grilled Cheese   Phillips33
        new string []{"BlockCheddarCheese",
            "Butter",
            "WhiteBread"
            },

        //30. Mini Cheeseburger Sliders Phillips34 
        new string []{"BlackPepper",
            "DinnerRolls",
            "GroundBeef",
            "Salt",
            "SliceCheddar"
            },

        //31. Peanut Butter Marshamllow Fluff Turnovers Phillips35
        new string []{"Butter",
            "ChunkyPeanutButter",
            "FiloPastry",
            "MarshmallowFluff",
            "SeaSalt"
            },

        //32. Chocolate Cake    Phillips36
        new string []{"BakingPowder",
            "BakingSoda",
            "CasterSugar",
            "Chocolate",
            "CocoaPowder",
            "Eggs",
            "Flour",
            "IcingSugar",
            "SourCream",
            "UnsaltedButter",
            "Vanilla"
            },

        //33. Apricot BlackBerry CRumble Phillips37
        new string []{"Butter",
            "Flour",
            "Apricots",
            "FreshBlackberries",
            "Lemons",
            "Sugar"
            },

        //34. Vanilla Souffle   Phillips38
        new string []{"AllPurposeFlour",
            "Butter",
            "CreamOfTartar",
            "EggWhites",
            "EggYolk",
            "Sugar",
            "VanillaBean",
            "VanillaExtract",
            "WholeMilk"
            },

        //35. Roasted Cabbage Rolls CL12
        new string []{"2PMilk",
            "Bacon",
            "BlackPepper",
            "Cabbage",
            "CookingSpray",
            "DarkCornSyrup",
            "Eggs",
            "GarlicSalt",
            "GrannySmithApple",
            "GreenOnions",
            "LongGrainRice",
            "Nutmeg",
            "Onions",
            "Sage",
            "Salt",
            "TomatoSauce",
            "Water"
            },

        //36. Chocolate Espresso Pudding    CL12
        new string []{"BitterSweetChoclolate",
            "BrownSugar",
            "Cornstarch",
            "FatFreeSoyMilk",
            "InstantCoffee",
            "Salt",
            "UnsweetenedCocoa",
            "VanillaExtract"
            },

        //36. Confetti Basmati Rice Pilaf with Toasted Flaxseed CL14
        new string []{"BasmatiRice",
            "BlackPepper",
            "Flaxseed",
            "FreshParsley",
            "Lemons",
            "LemonZest",
            "LowSodiumChickenBroth",
            "OliveOil",
            "Onions",
            "Salt"
            },

        //37. Confetti Bismati Rice Pilaf with Toasted Flaxseed  CL14
        new string []{"BlackPepper",
            "Flaxseed",
            "FreshParsley",
            "Lemons",
            "LemonZest",
            "BasmatiRice",
            "LowSodiumChickenBroth",
            "OliveOil",
            "Onions",
            "Salt"
        },
        //38. Confetti Long Grain Rice Pilaf with Toasted Flaxseed  CL14
        new string []{"BlackPepper",
            "Flaxseed",
            "FreshParsley",
            "Lemons",
            "LemonZest",
            "LongGrainRice",
            "LowSodiumChickenBroth",
            "OliveOil",
            "Onions",
            "Salt"
            },

        //39. Mango Coconut Bread Pudding   CL14
        new string []{"ApricotNectar",
            "Butter",
            "CookingSpray",
            "Cornstarch",
            "Eggs",
            "EggWhites",
            "EvaporatedFFMilk",
            "FFMilk",
            "FlakedCoconut",
            "FrenchBread",
            "Honey",
            "LightCoconutMilk",
            "Mango",
            "Sugar",
            "VanillaExtract"

            },

        //40. Churrasco with Pebre (beef with cilantro sauce) LC
        new string[]{"BeefTenderloin",
            "BlackPepper",
            "BlackPepper",
            "Cilantro",
            "CrushedRedPepper",
            "Cumin",
            "Garlic",
            "GarlicPowder",
            "MincedOnion",
            "MincedRedBellPepper",
            "OliveOil",
            "Onions",
            "Oregano",
            "Salt",
            "Sugar",
            "VegetableBroth",
            "WhiteVinegar"
            },

        //41. Garbanzo Stew (FD)
        new string []{"BasmatiRice",
            "Cilantro",
            "Curry",
            "DryRoastedPeanuts",
            "GaramMasala",
            "GarbanzoBeans",
            "OliveOil",
            "Onions",
            "Peas",
            "RedPepper",
            "Salt",
            "Sugar",
            "Tomato",
            "Turmeric",
            "Water"
            },

        //42. Noodle Salad with Shrimp and Chile Dressing (HCM)
        new string []{"BeanVermicelli",
            "BrownSugar",
            "ChilePaste",
            "Cilantro",
            "DryRoastedPeanuts",
            "FishSauce",
            "FreshLemonGrass",
            "GreenOnions",
            "Limes",
            "Mint",
            "Romaine",
            "SerranoChile",
            "Shrimp",
            "Water"
            },

        //43. Hot Beans and Cheese (HCM)
        new string []{"BlockCheddarCheese",
            "CanGreenChiles",
            "Cumin",
            "DicedTomatoes",
            "HotPepperSauce",
            "Oregano",
            "PintoBeans",
            "RefriedBeans",
            "Salt"
            },

        //44. Indian Egg Roll Stirps (HC)
        new string []{"BlackPepper",
            "CookingSpray",
            "Cumin",
            "Curry",
            "EggRollWrappers",
            "GarlicPowder",
            "Paprika",
            "Salt"
            },

        //45. Creamy Feta Spinach Dip (LC)
        new string []{"BlackPepper",
            "CreamCheese",
            "Dill",
            "FetaCheese",
            "FreshGarlic",
            "SourCream",
            "Spinach",
            "Yogurt"
            },

        //46. Cajun Tortilla Chips (HCM)
        new string []{"BlackPepper",
            "CookingSpray",
            "FlourTortilla",
            "GarlicPowder",
            "GroundRedPepper",
            "OnionPowder",
            "Paprika",
            "Salt",
            "Sugar",
            "Thyme"
            },

        //47. Spicy Caribbean Black Benas and Rice (HCM)
        new string []{"BalsamicVinegar",
            "BayLeaves",
            "BlackBeans",
            "BlackPepper",
            "Carrot",
            "DrySherry",
            "FreshGarlic",
            "OliveOil",
            "Onions",
            "Rice",
            "Salt",
            "Thyme"
            },

        //48. Linguine with Red Clam Sauce (HCM)
        new string []{"CanClams",
            "CrushedRedPepper",
            "Linguine",
            "Marinara",
            "MincedGarlic",
            "OliveOil",
            "TomatoPaste"
            },

        //49. Tropical Tofu Smoothie (HCM)
        new string []{"Nutmeg",
            "OrangeJuice",
            "Pineapple",
            "Strawberries",
            "Sugar",
            "Tofu",
            "Yogurt"
            },

        //50. Deluxe Roast Beef Sandwhich (HC) cl19
        new string []{"ChiliSauce",
            "DeliRoastBeef",
            "Horseradish",
            "Mayonnaise",
            "RedOnions",
            "Romaine",
            "RyeBread",
            "Tomato",
            },

        //51. Bueno Breakfast Burrito (LCM)
        new string []{"BlackPepper",
            "Cilantro",
            "CookingSpray",
            "CreamCheese",
            "Eggs",
            "FlourTortilla",
            "GreenOnions",
            "RedBellPepper",
            "Salsa",
            "Salt"
            },

        //52. Pork and Pear Sauce with Lemon Vodka Sauce (HCM)
        new string []{"Pears",
            "BlackPepper",
            "Chives",
            "DryWhiteWine",
            "Lemons",
            "OliveOil",
            "PorkChops",
            "Salt"
            },

        //53. White Bean Soup with Peppers and Bacon HCM
        new string []{"Bacon",
            "BlackPepper",
            "Carrot",
            "ChickenBroth",
            "FreshParsley",
            "NavyBeans",
            "OnionPowder",
            "Onions",
            "RedBellPepper",
            "RedPepper",
            "Sugar"
            },

        //54. Tortilla Casserole with Swiss Chard (LCM)
        new string []{"BlockCheddarCheese",
            "ButterMushrooms",
            "CornTortillas",
            "DicedTomatoes",
            "FreshParsley",
            "Garlic",
            "JalapenoPeppers",
            "Onions",
            "SourCream",
            "SwissChard",
            "VegetableOil"
            },

        //55. Scotch Broth HC
        new string []{"BlackPepper",
            "Carrot",
            "Celery",
            "ChickenBroth",
            "LambLeg",
            "Leek",
            "PearlBarley",
            "Salt",
            "SplitPeas",
            "Turnips"
            },

        //56. Roast Pork with Dried Fruits and Squash HCM
        new string []{"BlackPepper",
            "ButternutSquash",
            "Cinnamon",
            "DriedApricots",
            "FreshGinger",
            "PorkLoin",
            "Prunes",
            "Salt",
            "Sugar",
            "Water"
            },

        //57. Stir Fried Vegetables and Tofu LCM
        new string []{"BeanSprouts",
            "BlackPepper",
            "Carrot",
            "CreminiMushrooms",
            "DryWhiteWine",
            "FreshGarlic",
            "LongGrainRice",
            "OliveOil",
            "Salt",
            "SoySauce",
            "Tofu",
            "YellowSquash",
            "Zucchini"
            },

        //58. Miso Chicken with Brown Rice HC
        new string []{"BrownRice",
            "Carrot",
            "ChickenBreast",
            "CookingSpray",
            "Eggs",
            "FishSauce",
            "FreshGarlic",
            "FreshGinger",
            "FreshParsley",
            "GreenOnions",
            "Miso",
            "Onions",
            "ShitakeMushrooms",
            "SoySauce",
            "Spinach"
            },

        //59. SpicySteakFries HCM
        new string []{"Potatoes",
            "Salt",
            "SteakSeasoning",
            "VegetableOil"
            },

        //59. Baked Triple Bean Pot
        new string []{"BlackPepper",
            "BrownSugar",
            "Dijon",
            "Ketchup",
            "LimaBeans",
            "PintoBeans"
            },

        //61. Hearty Navy Bean Soup
        new string []{"BayLeaves",
            "BlackPepper",
            "Carrot",
            "FreshGarlic",
            "Ham",
            "NavyBeans",
            "Onion",
            "Salt"
            },

        //62. Onion-Smothered Brisket and Veggies
        new string []{"BeefBrisket",
            "Beer",
            "BrownSugar",
            "Carrot",
            "ChiliSauce",
            "GarlicPowder",
            "Onions",
            "RedPotato",
            "Salt",
            "Worcestershire"
            },

        //63. BBQ Pork Chops
        new string []{"BrownSugar",
            "CookingSpray",
            "GarlicSalt",
            "Ketchup",
            "PorkChops",
            "RedPepper",
            "SoySauce",
            "Thyme",
            "Worcestershire"
            },

        //64. Lentil Potage with Spinach and Yogurt HCM
        new string []{"AllSpice",
            "BayLeaves",
            "BlackPepper",
            "Bulger",
            "ChickPeas",
            "Cumin",
            "Lentils",
            "OliveOil",
            "Onions",
            "Paprika",
            "PearlBarley",
            "Salt",
            "Spinach",
            "Turmeric",
            "Water",
            "Yogurt"
            },

        //65. Huevos Rancheros LCM
        new string []{"Eggs",
            "CookingSpray",
            "CornTortillas",
            "BlockCheddarCheese",
            "RedOnions",
            "TomatoJuice",
            "Salsa"
            },

        //66. Caldo de Res (B)
        new string []{"BeefShank",
            "Boullion",
            "Cabbage",
            "Carrot",
            "Celery",
            "FreshCilantro",
            "Garlic",
            "Limes",
            "Onions",
            "Water",
            "Zucchini"
            },

        //67.Marinated Veggies HC
        new string []{"BayLeaves",
            "Carrot",
            "Cauliflower",
            "CiderVinegar",
            "FreshGarlic",
            "JalapenoPeppers",
            "Jicama",
            "Marjoram",
            "Onions",
            "Oregano",
            "Peppercorns",
            "Thyme",
            "VegetableOil",
            "Water",
            "Zucchini"
            },

        //68. Chicken Salpicon (LC)
        new string []{"Avocado",
            "BlackPepper",
            "ChickenBreast",
            "FreshCilantro",
            "Iceberg",
            "JalapenoPeppers",
            "Onions",
            "Salt",
            "Tomato",
            "VegetableOil",
            "WhiteVinegar"
            },

        //69. Green Sauced Chicken Enchiladas HCM
        new string []{"BlockCheddarCheese",
            "CanGreenChiles",
            "ChickenBreast",
            "CookingSpray",
            "CornTortillas",
            "Cumin",
            "FreshGarlic",
            "Onions",
            "Salt",
            "Tomato",
            "Water"
            },

        //70. Salsa Manuela B
        new string []{"JalapenoPeppers",
            "Onions",
            "Salt",
            "Tomato",
            "Water"
            },

        //71 Four Alarm Red Salsa B
        new string []{"ChileArbols",
            "Cumin",
            "Garlic",
            "Onions",
            "Oregano",
            "Salt",
            "Tomatillos",
            "TomatoSauce",
            "Water"
            },

        //72. GreenSalsa B
        new string []{"Cumin",
            "Garlic",
            "JalapenoPeppers",
            "Salt",
            "Tomato",
            "VidaliaOnion",
            "Water"
            },

        //73. All Purpose Pizza Dough
        new string []{"AllPurposeFlour",
            "CookingSpray",
            "DryYeast",
            "Salt",
            "Water"
            },


        //74. Lemon Basil Snapper with Roasted Peppers
        new string []{"BalsamicVinegar",
            "BlackPepper",
            "Chives",
            "CookingSpray",
            "FreshBasil",
            "Lemons",
            "OliveOil",
            "RedBellPepper",
            "RedSnapperFilet",
            "Salt",
            "Water"
            },

        //75. Beef Carbonnade HCM
        new string []{"AllPurposeFlour",
            "Bacon",
            "BayLeaves",
            "BeefBroth",
            "Beer",
            "BlackPepper",
            "ChuckRoast",
            "DryWhiteWine",
            "EggNoodles",
            "Garlic",
            "Onions",
            "Salt",
            "Sugar",
            "Thyme"
            },

        //76. Broiled Salmon with Sweet and Sour Cucumbers LCM
        new string []{"BrownSugar",
            "CiderVinegar",
            "CookingSpray",
            "Cucumber",
            "Dijon",
            "Dill",
            "Salmon",
            "Salt",
            "Sugar"
            },

        //77. Smoked Fish Spread LCM
        new string []{"BlackPepper",
            "Crackers-Saltine",
            "CreamCheese",
            "Horseradish",
            "Lemons",
            "SourCream",
            "WhiteFish",
            "Worcestershire"
            },

        //78. Strawberry Lemon Syrup HC
        new string []{"Lemons",
            "Strawberries",
            "Sugar",
            "Water"
            },

        //79. Lemony Orzo Salad LCM
        new string []{"Basil",
            "BlackPepper",
            "DicedTomatoes",
            "FetaCheese",
            "FreshMint",
            "FreshParsley",
            "KalamataOlives",
            "Lemons",
            "OliveOil",
            "Orzo",
            "RedOnions",
            "Salt",
            "Zucchini"
            },

        //Honey Left me in a cruch chicken with linguine
        new string []{"AllPurposeFlour",
            "BlackPepper",
            "ChickenBreast",
            "Dijon",
            "Eggs",
            "Garlic",
            "ItalianSeasonings",
            "Linguine",
            "OliveOil",
            "PastaSauce",
            "Salt",
            "WheatGerm"
            },

        //Veal Mediterranean
        new string []{"Basil",
            "BayLeaves",
            "CookingSpray",
            "Cornstarch",
            "DryRedWine",
            "Garlic",
            "Linguine",
            "PimentoOlives",
            "StewedTomatoes",
            "VealCutlets",
            "Water"
            },

        //Linguine with Clams and Artichokes in Red Sauce
        new string []{"ArtichokeHearts",
            "BabyClams",
            "Basil",
            "BlackPepper",
            "DryWhiteWine",
            "FreshParsley",
            "Garlic",
            "Linguine",
            "OliveOil",
            "PastaSauce",
            "Shallots"
            },

        //Tuscan Chicken Stew
        new string []{"BlackPepper",
            "CannelliniBeans",
            "ChickenBreast",
            "ChickenBroth",
            "MincedGarlic",
            "OliveOil",
            "RoastedRedBellPeppers",
            "Rosemary",
            "Salt",
            "Spinach"
            },

        //Curried Chicken CousCous
        new string []{"AllPurposeFlour",
            "Carrot",
            "ChickenBreast",
            "CoconutMilk",
            "CousCous",
            "Curry",
            "FreshCilantro",
            "Raisins",
            "Salt",
            "VegetableOil",
            "Water"
            },

        //Greek Shrimp and Spinach with Penne
        new string []{"BlackPepper",
            "CookingSpray",
            "DicedTomatoes",
            "FetaCheese",
            "Lemons",
            "MincedGarlic",
            "OliveOil",
            "Oregano",
            "Penne",
            "Shrimp",
            "Spinach"
            },

        //Pork and Pineapple Stir Fry
        new string []{"BeefBroth",
            "BrownSugar",
            "CanPineapple",
            "ChiliPowder",
            "Cornstarch",
            "Curry",
            "FreshGinger",
            "GreenBellPepper",
            "MincedGarlic",
            "Onions",
            "PorkTenderloin",
            "Rice",
            "SoySauce",
            "TomatoPaste",
            "VegetableOil"
            },

        //Cavatappi with Kale and Fava Beans
        new string []{"BlackPepper",
            "ChickenBroth",
            "CrushedRedPepper",
            "FavaBeans",
            "FreshParmesan",
            "Garlic",
            "Kale",
            "OliveOil",
            "Salt",
            "SpiralPasta"
            },

        //Cavatappi with Kale and Kidney Beans
        new string []{"BlackPepper",
            "ChickenBroth",
            "CrushedRedPepper",
            "KidneyBeans",
            "FreshParmesan",
            "Garlic",
            "Kale",
            "OliveOil",
            "Salt",
            "SpiralPasta"
            },

        //Collard Greens with Lima Beans and Smoked Turkey
        new string []{"BayLeaves",
            "BlackPepper",
            "ChickenBroth",
            "CollardGreens",
            "CrushedRedPepper",
            "DicedTomatoes",
            "FreshThyme",
            "Garlic",
            "LimaBeans",
            "OliveOil",
            "RedOnions",
            "RedWineVinegar",
            "Salt",
            "Thyme",
            "Turkey"
            },

        //Halibut Wrapped in Greens lc
        new string []{"BlackPepper",
            "ChickenBroth",
            "Cornstarch",
            "Dijon",
            "DryWhiteWine",
            "FishStock",
            "Garlic",
            "HalibutSteak",
            "Lemons",
            "Salt",
            "Shallots",
            "Turnips"
            },

        //Creamy Polenta and Saute of Mixed Greens lc
        new string []{"BlackPepper",
            "ChickenBroth",
            "Cornmeal",
            "FreshParmesan",
            "Garlic",
            "Kale",
            "OliveOil",
            "Onions",
            "RedBellPepper",
            "SunDriedTomatoes",
            "Water"
            },

        //Pork, Kale and Bok Choy Stir Fry HCM
        new string []{"BokChoy",
            "ChickenBroth",
            "Cornstarch",
            "CrushedRedPepper",
            "FreshGinger",
            "Garlic",
            "GreenOnions",
            "Hoisin",
            "Kale",
            "PorkTenderloin",
            "Rice",
            "ShitakeMushrooms",
            "SoySauce",
            "VegetableOil"
            },

        //Miso Salmon with Asparagus LCM
        new string []{"Asparagus",
            "CookingSpray",
            "DryWhiteWine",
            "FreshGinger",
            "GreenOnions",
            "Lemons",
            "Miso",
            "Salmon",
            "Salt",
            "SesameOil",
            "SesameSeeds",
            "Sugar"
            },

        //Shrimp and Squash Penne LCM
        new string []{"Basil",
            "BlackPepper",
            "FreshParmesan",
            "Garlic",
            "GreenOnions",
            "Lemons",
            "OliveOil",
            "Oregano",
            "Penne",
            "Salt",
            "Shrimp",
            "YellowSquash",
            "Zucchini"
            },

        //Shrimp and Asparagus with Ginger Sesame Sauce HCM
        new string []{"Asparagus",
            "BlackPepper",
            "ButtonMushrooms",
            "Cornstarch",
            "DryWhiteWine",
            "FreshGinger",
            "FreshParsley",
            "Garlic",
            "LongGrainRice",
            "Salt",
            "SesameOil",
            "SesameSeeds",
            "ShitakeMushrooms",
            "Shrimp",
            "SoySauce",
            "VegetableOil",
            "Water"
            },

        //Soft Shrimp Tacos with Tropical Salsa HCM
        new string []{"CanGreenChiles",
            "ChiliPowder",
            "CookingSpray",
            "Cumin",
            "FlourTortilla",
            "FreshCilantro",
            "Garlic",
            "GreenOnions",
            "Lemons",
            "MandarinOranges",
            "MonterayJackCheese",
            "Pineapple",
            "RedOnions",
            "Shrimp",
            "Tomato",
            "YellowBellPepper"
            },

        //Savory Braised Pork Supper HCM
        new string []{"BlackPepper",
            "Carrot",
            "ChickenBroth",
            "CookingSpray",
            "DryMustard",
            "Garlic",
            "Leek",
            "Paprika",
            "PorkButt",
            "RedPotato",
            "Sage",
            "Salt",
            "Thyme",
            "VegetableOil"
            },

        //Osso Buco HCM
        new string []{"AllPurposeFlour",
            "BeefBroth",
            "BlackPepper",
            "Carrot",
            "DryWhiteWine",
            "EggNoodles",
            "FreshParsley",
            "Garlic",
            "Garlic",
            "HerbesDeProvence",
            "Lemons",
            "OliveOil",
            "Onions",
            "Salt",
            "VealShanks",
            "Water"
            },

        //Tuscan Lamb Shanks HCM
        new string []{"AllPurposeFlour",
            "BeefBroth",
            "BlackPepper",
            "DryRedWine",
            "EggNoodles",
            "FreshParsley",
            "Garlic",
            "LambShanks",
            "NorthernBeans",
            "OliveOil",
            "Rosemary",
            "Salt",
            "Shallots",
            "SunDriedTomatoes",
            "Water",
            "Worcestershire"
            },

        //Beef Bourguignonne HC
        new string []{"AllPurposeFlour",
            "Bacon",
            "BeefBroth",
            "BlackPepper",
            "Carrot",
            "ChuckRoast",
            "DryRedWine",
            "EggNoodles",
            "Garlic",
            "Salt",
            "Shallots",
            "ShitakeMushrooms",
            "Thyme"
            },

        //Pasta with Mussels and Monteray Jack LCM
        new string []{"BlackPepper",
            "DryWhiteWine",
            "Garlic",
            "GreenOnions",
            "HalfandHalf",
            "MonterayJackCheese",
            "Mussels",
            "OliveOil",
            "Pasta",
            "RedBellPepper",
            "Salt",
            "Spinach"
            },

        //Caramalized Corn Saute LCM
        new string []{"BlackPepper",
            "Butter",
            "Corn",
            "GreenOnions",
            "HalfandHalf",
            "RedBellPepper",
            "Salt"
            },

        //Tomato Sauce B
        new string []{"Basil",
            "BayLeaves",
            "BlackPepper",
            "CanPlumTomatoes",
            "DryRedWine",
            "Garlic",
            "GreenBellPepper",
            "OliveOil",
            "Onions",
            "Oregano",
            "Salt",
            "TomatoPaste"
            },

        //Pepper Steak with Port Wine Mushroom Suace HC
        new string []{"AllPurposeFlour",
            "BalsamicVinegar",
            "BeefBroth",
            "Dijon",
            "Rosemary",
            "Shallots",
            "ShitakeMushrooms",
            "SweetRedWine",
            "TomatoPaste",
            "Worcestershire",
            "BeefTenderloin",
            "Peppercorns",
            "Salt"
            },

        //Beef Bourguignonne Topped Potatoes
        new string []{"AllPurposeFlour",
            "BeefBroth",
            "BeefTenderloin",
            "BlackPepper",
            "Butter",
            "DryRedWine",
            "FreshThyme",
            "MincedGarlic",
            "Mushrooms",
            "Potatoes",
            "Salt",
            "Shallots",
            "Thyme"
            },

        //Chili-Cheese Rice Burritos LCM
        new string []{"BlackPepper",
            "CanGreenChiles",
            "FlourTortilla",
            "GreenOnions",
            "Iceberg",
            "MonterayJackCheese",
            "Rice",
            "Salsa",
            "Salt",
            "SourCream",
            "Tomato",
            "Zucchini"
            },

        //Crispy Sesame Shrimp HC
        new string []{"BlackPepper",
            "CookingSpray",
            "Eggs",
            "GarlicPowder",
            "Paprika",
            "Salt",
            "SesameSeeds",
            "Shrimp",
            "StuffingMix"
            },

        //Meat Sauce Macaroni HCM
        new string []{"BlackPepper",
            "BlockCheddarCheese",
            "ElbowMacaroni",
            "GroundBeef",
            "PizzaSauce",
            "Salt"
            },

        //Spaghetti with Broccoli and Ham lcm
        new string []{"AlfredoSauce",
            "BlackPepper",
            "Broccoli",
            "Ham",
            "Parmesan",
            "Pasta"
            },

        //White Bean salad with Shrimp and Arugala HCM
        new string []{"Arugula",
            "BlackPepper",
            "Garlic",
            "Lemons",
            "NorthernBeans",
            "OliveOil",
            "RedOnions",
            "Salt",
            "Shrimp"
            },

        //Tabbouleh with arugula and Chicken LC
        new string []{"Arugula",
            "BlackPepper",
            "Bulger",
            "ChickenBreast",
            "FreshParsley",
            "Lemons",
            "Mint",
            "OliveOil",
            "RedOnions",
            "Salt",
            "Tomato",
            "Water"
            },

        //Field Salad with Roasted Leeks, mushrooms and Feta
        new string []{"Arugula",
            "CookingSpray",
            "DillMustardDressing",
            "FetaCheese",
            "Leek",
            "Mushrooms",
            "OliveOil",
            "Spinach"
            },

        //Potato Salad with Arugula Pesto, Peas, Zucchini HCM
        new string []{"Arugula",
            "BlackPepper",
            "FreshBasil",
            "FreshParmesan",
            "GreenOnions",
            "Lemons",
            "OliveOil",
            "Peas",
            "RedPotato",
            "Salt",
            "Spinach",
            "Water",
            "Zucchini"
            },

        //Indian Chicken Curry HCM
        new string []{"BasmatiRice",
            "Butter",
            "ChickenBreast",
            "ChiliPowder",
            "Cinnamon",
            "Coriander",
            "Cumin",
            "Curry",
            "Garlic",
            "Ginger",
            "GroundRedPepper",
            "Onions",
            "Potatoes",
            "Salt",
            "Tomato",
            "TomatoPaste",
            "Yogurt"
            },

        //Savory Roasted Vegetable Pitas LCM, HCM
        new string []{"BalsamicVinegar",
            "BlackPepper",
            "CookingSpray",
            "DicedTomatoes",
            "Dijon",
            "Eggplant",
            "Garlic",
            "Lemons",
            "MozzarellaCheese",
            "Mushrooms",
            "OliveOil",
            "Onions",
            "Oregano",
            "Pitas",
            "RoastedRedBellPeppers",
            "Salt",
            "Water",
            "YellowSquash",
            "Zucchini"
            },

        //Grilled Asparagus LC
        new string []{"Asparagus",
            "BalsamicVinegar",
            "BlackPepper",
            "CookingSpray",
            "Lemons",
            "OliveOil",
            "SoySauce"
            },

        //Warm Scallop Salad with Lime and Cilantro LCM
        new string []{"Avocado",
            "Cilantro",
            "Garlic",
            "JalapenoPeppers",
            "Limes",
            "OliveOil",
            "Pitas",
            "PlumTomato",
            "RedOnions",
            "Salt",
            "Scallops",
            "Watercress",
            "YellowBellPepper"
            },
        //Suquet of Cod HCM
        new string []{"AllPurposeFlour",
            "Almonds",
            "BlackPepper",
            "ClamJuice",
            "Cod",
            "DryWhiteWine",
            "FreshParsley",
            "Garlic",
            "Lemons",
            "OliveOil",
            "Onions",
            "Paprika",
            "Peas",
            "Potatoes",
            "Saffron",
            "Salt",
            "Water"
            },

        //Vegetable Donburi over Seasoned Rice HCM
        new string []{"Carrot",
            "Eggs",
            "Garlic",
            "Ginger",
            "GreenOnions",
            "Miso",
            "Rice",
            "ShitakeMushrooms",
            "SoySauce",
            "Sugar",
            "VegetableBroth",
            "Water"
            },

        //Cuban Chicken and Plantain Stew HCM
        new string []{"Carrot",
            "Eggs",
            "FreshGinger",
            "Garlic",
            "GreenOnions",
            "Miso",
            "Rice",
            "ShitakeMushrooms",
            "SoySauce",
            "Sugar",
            "VegetableBroth",
            "Water"
            },

        //Spring Pasole LC
        new string []{"BlackPepper",
            "ChickenBreast",
            "ChickenBroth",
            "Cumin",
            "DrySherry",
            "FreshParsley",
            "Garlic",
            "GreenBellPepper",
            "OliveOil",
            "Onion",
            "Oregano",
            "Paprika",
            "Plantains",
            "PlumTomato",
            "Salt"
            },

        //Risotto with Asparagus Fennel and Leeks hcm
        new string []{"Asparagus",
            "BlackPepper",
            "ChickenBroth",
            "DryWhiteWine",
            "FennelBulb",
            "FreshParmesan",
            "Leek",
            "OliveOil",
            "Rice",
            "Rosemary"
            },

        //Chunky Minestrone Primavera with Clams HCM
        new string []{"BlackPepper",
            "CanClams",
            "Carrot",
            "ChickenBroth",
            "FennelBulb",
            "FreshBasil",
            "FreshParmesan",
            "FreshParsley",
            "Garlic",
            "NorthernBeans",
            "OliveOil",
            "Onion",
            "Oregano",
            "Peas",
            "Potatoes",
            "Rice",
            "Salt",
            "Water",
            "Zucchini"
            },

        //White Beans hummus Dip HC
        new string []{"BlackPepper",
            "CannelliniBeans",
            "Cumin",
            "Garlic",
            "GreenOnions",
            "Lemons",
            "Oregano",
            "Salt",
            "Tahini"
            },

        //Shrimp with Roasted pepper Horseradish Dip LC
        new string []{"BlackPepper",
            "Garlic",
            "Horseradish",
            "Lemons",
            "OliveOil",
            "RedBellPepper",
            "Salt",
            "Shrimp",
            "SourCream",
            "Water"
            },

        //Apricot Stuffed Spice Rubbed Pork Loin HC
        new string []{"Apricots",
            "BrownSugar",
            "Capers",
            "Chinese5Spice",
            "CookingSpray",
            "Cumin",
            "GarlicPowder",
            "Ginger",
            "GroundRedPepper",
            "PorkLoin",
            "Salt"
            },

        //Sweet and Hot Onion Salsa HC
        new string []{"BlackPepper",
            "Garlic",
            "GrannySmithApple",
            "JalapenoPeppers",
            "Limes",
            "Oranges",
            "Plum",
            "Salt",
            "Sugar",
            "VidaliaOnion",
            "Water",
            "WhiteWineVinegar"
            },

        //SpicyChickenBreasts with Caramelized Onion Red Pepper Relish LC
        new string []{"BalsamicVinegar",
            "ChickenBreast",
            "ChiliPowder",
            "Cinnamon",
            "Coriander",
            "FreshBasil",
            "GarlicPowder",
            "GroundRedPepper",
            "OliveOil",
            "PineNuts",
            "RedBellPepper",
            "Salt",
            "VidaliaOnion"
            },

        //Creole Catfish with Vidalia Olvie Relish LC
        new string []{"Catfish",
            "GarlicPowder",
            "GreenOlives",
            "GroundRedPepper",
            "KalamataOlives",
            "OliveOil",
            "Paprika",
            "RedBellPepper",
            "Salt",
            "Thyme",
            "VidaliaOnion",
            "Water"
            },

        //Shrimp Creole Potpie HCM
        new string [] { "AllPurposeFlour",
"Basil",
"BlackPepper",
"Breadsticks",
"Celery",
"DicedTomatoes",
"FreshParsley",
"Garlic",
"GreenBellPepper",
"GreenOnions",
"HotPepperSauce",
"Lemons",
"OliveOil",
"Onions",
"Rice",
"Salt",
"Shrimp",
"Sugar",
"Thyme",
"TomatoPaste",
"Water",
"Worcestershire"
},
        
        //Pepper Slaw B
        new string [] { "Carrot",
"GreenBellPepper",
"GreenCabbage",
"RedCabbage",
"RedWineVinegar",
"Salt",
"Sugar",
"Water"
},

        //White Gazpacho B

        new string [] { "ChickenBroth",
"Cucumber",
"DicedTomatoes",
"Garlic",
"GreenOnions",
"Salt",
"SourCream",
"WhiteWineVinegar"
},

        //Darcy's Veggie Chili HCM

        new string [] { "AllSpice",
"BlockCheddarCheese",
"BrownSugar",
"ChiliPowder",
"Cloves",
"Coriander",
"Cumin",
"DicedTomatoes",
"Garlic",
"GreenBellPepper",
"JalapenoPeppers",
"KidneyBeans",
"OliveOil",
"Onions",
"Oregano",
"RedBellPepper",
"TomatoPaste",
"Water"
},

        //Mary's Salsa B
        new string [] { "DicedTomatoes",
"Garlic",
"JalapenoPeppers",
"Limes",
"Onions"
},

        //Traditional Spanish Paella HCM
        new string [] { "ChickenBroth",
"ChickenThigh",
"DicedTomatoes",
"FreshParsley",
"Garlic",
"Garlic",
"Ham",
"Lemons",
"Lemons",
"Mussels",
"OliveOil",
"Onions",
"Paprika",
"Peas",
"RedBellPepper",
"Rice",
"Shrimp",
"TurkeySausage",
"Water"
},

        //Spicy Paella with Chile, Lime and cilantro HCM
        new string [] {"ChickenBroth",
"ChickenSausage",
"Chiles",
"Cilantro",
"Cinnamon",
"Corn",
"Cumin",
"DicedTomatoes",
"Garlic",
"Limes",
"Limes",
"OliveOil",
"Onions",
"Paprika",
"RedBellPepper",
"Rice",
"Salt",
"Shrimp",
"Zucchini"
 },

        //Seafood Paella HCM
        new string [] { "ClamJuice",
"Clams",
"CrushedRedPepper",
"DicedTomatoes",
"DryWhiteWine",
"FreshParsley",
"Garlic",
"Lemons",
"OliveOil",
"Onions",
"Paprika",
"Peas",
"Pimento",
"RedBellPepper",
"Rice",
"Saffron",
"Shrimp",
"Tarragon",
"Water",
"WhiteFish"
},

        //Pad Thai (HCM)
        new string [] { "BeanSprouts",
"BrownSugar",
"ChickenBreast",
"Cilantro",
"Eggs",
"FishStock",
"Garlic",
"GreenOnions",
"Limes",
"Paprika",
"Peanuts",
"Vermicelli",
"Shrimp",
"SoySauce",
"VegetableOil",
"Water"
},

        //Shrimp and Broccoli in Chili Sauce (HCM)
        new string [] { "Broccoli",
"ChiliSauce",
"Cornstarch",
"DrySherry",
"Garlic",
"GroundRedPepper",
"JalapenoPeppers",
"Paprika",
"Salt",
"Shrimp",
"Sugar",
"VegetableOil",
"Vermicelli",
"Water"
},

        //Chicken Cashew (HCM)
        new string [] { "Carrot",
"Cashews",
"ChickenBreast",
"ChickenBroth",
"Cornstarch",
"CrushedRedPepper",
"GreenOnions",
"Honey",
"Mushrooms",
"Onions",
"OysterSauce",
"Pineapple",
"RedBellPepper",
"Rice",
"Salt",
"SnowPeas",
"SoySauce",
"VegetableOil",
"WhiteWineVinegar"
},

        //Asian Vegetable Stir Fry (HCM)
        new string [] { "BlackPepper",
"Celery",
"Curry",
"GreenBellPepper",
"NapaCabbage",
"PineNuts",
"RiceVinegar",
"Salt",
"SoySauce",
"TomatoPaste",
"VegetableOil",
"VidaliaOnion",
"Water",
"WaterChesnuts",
"YellowSquash",
"Zucchini"
},

        //Fried Rice with Smoked Ham (HC)
        new string [] { "Cilantro",
"Corn",
"Eggs",
"Garlic",
"GroundWhitePepper",
"Ham",
"Onion",
"Peas",
"Rice",
"Salt",
"SesameOil",
"SoySauce",
"VegetableOil"
},

        //Creamy Caesar Salad with Spicy Croutons (LCM)
        new string [] { "AnchovyPaste",
"BlackPepper",
"Bread",
"CajunSeasoning",
"Dijon",
"DryWhiteWine",
"Garlic",
"Mayonnaise",
"OliveOil",
"Parmesan",
"RedWineVinegar",
"Romaine",
"Worcestershire"
},

        //Super Duper Sunrise Shake (HC)
        new string [] { "Apricots",
"Bananas",
"OrangeJuice",
"Raspberries",
"WheatGerm"
},

        //Pan Seared Cod over Vegetable Ragout (LCM)
        new string [] { "AllPurposeFlour",
"BlackPepper",
"FreshBasil",
"Garlic",
"Leek",
"OliveOil",
"PlumTomato",
"Prosciutto",
"Salt",
"ShitakeMushrooms",
"Spinach",
"WhiteFish"
},

        //Fresh Fruit Compote with Orange Lime Drizze (HC)
        new string [] { "Bananas",
"Kiwi",
"Limes",
"Mango",
"Mint",
"OrangeJuice",
"Papaya",
"Strawberries"
},

        //Chicken with Mushrooms and Leeks (HCM)
        new string [] { "BlackPepper",
"Breadcrumbs",
"ChickenBroth",
"Garlic",
"Leek",
"Mushrooms",
"OliveOil",
"Salt",
"Thyme",
"TomatoPaste"
},

        //Spring Salad with Asparagus and Radishes (LC)
        new string [] { "Asparagus",
"Dijon",
"FetaCheese",
"Greens",
"Radishes",
"Vinaigrette"
},

        //Skillet Roasted Potatos with Lemon and Mint (HCM)
        new string [] { "BlackPepper",
"Butter",
"Lemons",
"Mint",
"OliveOil",
"Potatoes",
"Salt",
},

        //Risi e Bisi HCM
        new string [] { "BlackPepper",
"Butter",
"ChickenBroth",
"DryWhiteWine",
"FreshParmesan",
"FreshParsley",
"Ham",
"Onions",
"Peas",
"Rice"
},

        //Pasta Primavera HCM
        new string [] { "Asparagus",
"BlackPepper",
"ChickenBroth",
"DryWhiteWine",
"FreshBasil",
"FreshOregano",
"FreshParmesan",
"GreenOnions",
"Ham",
"OliveOil",
"Peas",
"Salt",
"Vermicelli",
"Zucchini"
},

        //Fresh Peas with Lettuce HCM
        new string [] { "BlackPepper",
"Butter",
"Celery",
"ChickenBroth",
"FreshParsley",
"Peas",
"Romaine",
"Salt",
"Sugar",
"Thyme",
"VidaliaOnion"
},

        //Curried Chicken with Spring Peas HCM
        new string [] { "AllPurposeFlour",
"BasmatiRice",
"BlackPepper",
"ChickenBreast",
"ChickenBroth",
"Cinnamon",
"Cumin",
"Curry",
"FreshGinger",
"Garlic",
"GrannySmithApple",
"Onions",
"Peas",
"RedPotato",
"Salt",
"SourCream",
"Sugar",
"TomatoPaste",
"VegetableOil"
},

        //Tofu with Red Curry Paste Peas and Yellow Tomatoes LCM
        new string [] { "BlackPepper",
"CoconutMilk",
"Limes",
"OliveOil",
"Onions",
"Peas",
"RedCurryPaste",
"Rice",
"Salt",
"Tofu",
"Turmeric",
"YellowTomato"
},

        //Tofu Triangles with Spciy Onion Sauce HCM
        new string [] { "AllPurposeFlour",
"BlackPepper",
"BrownSugar",
"CanolaOil",
"Cumin",
"Curry",
"FreshCilantro",
"Onions",
"PlumTomato",
"RedWineVinegar",
"Rice",
"Salt",
"Tofu",
"Turmeric",
"Water"
},

        //Creamy Potato and Leek Soup HCM
        new string [] { "BayLeaves",
"BlackPepper",
"CanolaOil",
"FreshParsley",
"FreshThyme",
"Leek",
"RedPotato",
"Salt",
"Tofu",
"Water"
},

        //Glazed Tofu Sandwhich LCM
        new string [] { "BlackPepper",
"Bread",
"FreshBasil",
"Garlic",
"Mayonnaise",
"OliveOil",
"Salt",
"Tofu",
"Tomato",
"Worcestershire"
},

        //Barbecued Tofu Sandwhich LCRec
        new string [] { "AllPurposeFlour",
"BarbecueSauce",
"HamburgerBuns",
"Salt",
"Tofu",
"VegetableOil"
},

        //Tofu Coleslaw B
        new string [] { "Carrot",
"Celery",
"FreshParsley",
"Garlic",
"GreenCabbage",
"GroundRedPepper",
"Mayonnaise",
"Mustard",
"RiceVinegar",
"Salt",
"Sugar"
},

        //Confetti Pasta with Chicken HC
        new string [] { "BlackPepper",
"BrownMustard",
"Carrot",
"Celery",
"ChickenBreast",
"CiderVinegar",
"DryWhiteWine",
"FreshParsley",
"Garlic",
"GarlicPowder",
"GreenBellPepper",
"Lemons",
"Mayonnaise",
"Oregano",
"Pasta",
"RedBellPepper",
"Salt",
"Water",
"Yogurt"
},

        //Tangy Lentil Salad HCM
        new string [] { "BayLeaves",
"Celery",
"Cucumber",
"Dijon",
"FetaCheese",
"Lentils",
"Oranges",
"RedOnions",
"Salt",
"Water",
"WhiteWineVinegar"
},

        //Shrimp Avocado and Farfalle Salad lCM
        new string [] { "Avocado",
"CherryTomatoes",
"Corn",
"Cumin",
"FreshCilantro",
"GreenOnions",
"GroundRedPepper",
"Limes",
"OliveOil",
"Pasta",
"RedBellPepper",
"RedWineVinegar",
"Salt",
"Shrimp",
"TomatoJuice"
},

        //Tomato Panzanella with Provolone and Ham HCM
        new string [] { "BalsamicVinegar",
"BlackPepper",
"Bread",
"Capers",
"DicedTomatoes",
"FreshBasil",
"Garlic",
"Ham",
"Provolone",
"Salt"
},

        //Cajun Catfish Wraps with Slaw
        new string [] { "AllPurposeFlour",
"BlackPepper",
"Butter",
"Cabbage",
"Catfish",
"CiderVinegar",
"FlourTortilla",
"GarlicPowder",
"GroundRedPepper",
"Mayonnaise",
"Oregano",
"Paprika",
"Salt",
"Sugar",
"Thyme"
},

        //Ginger-Peanut Chicken Salad Wraps lCM
        new string [] { "ChickenBreast",
"Cucumber",
"FlourTortilla",
"FreshCilantro",
"Garlic",
"Ginger",
"GroundRedPepper",
"Limes",
"OliveOil",
"PeanutButter",
"RedBellPepper",
"Romaine",
"Salt",
"SoySauce",
"Sugar",
"Water"
},

        //Blue Cheese Pepper Steak Wraps LCM
        new string [] { "BlackPepper",
"CookingSpray",
"DryMustard",
"FetaCheese",
"FlourTortilla",
"GarlicPowder",
"Mushrooms",
"Onions",
"RedBellPepper",
"RedWineVinegar",
"Romaine",
"RoundSteak",
"Salt",
"Water"
},

        //Steamed Vegetables with Cantonese Dipping Sauce (LCM)
        new string [] { "BokChoy",
"Broccoli",
"Cauliflower",
"Cornstarch",
"DrySherry",
"SesameOil",
"SoySauce",
"Sugar",
"Water"
},

        //Steamed Lemon Grass with Shrimp LC
        new string [] { "FreshCilantro",
"Ginger",
"GreenOnions",
"LemonGrass",
"Limes",
"SerranoChile",
"Shrimp",
"YellowBellPepper"
},

        //Steamed Snapper with Tomatoes and Feta (LCM, HCM)
        new string [] { "BlackPepper",
"CousCous",
"CrushedRedPepper",
"DryWhiteWine",
"FetaCheese",
"Garlic",
"Lemons",
"Onions",
"Oregano",
"Parsley",
"Salt",
"Tomato",
"WhiteFish"
},

        //Tomato Pizza with Capers, Basil and Garlic LCM
        new string [] { "BlackPepper",
"Capers",
"CookingSpray",
"Cornmeal",
"FreshBasil",
"Garlic",
"MozzarellaCheese",
"OliveOil",
"PizzaDough",
"Salt",
"Tomato"
},

        //Mushroom Pizza with Thyme LCM
        new string [] { "BlackPepper",
"CookingSpray",
"Cornmeal",
"CreminiMushrooms",
"FreshParmesan",
"FreshParsley",
"Garlic",
"Lemons",
"OliveOil",
"PizzaDough",
"Salt",
"Thyme"
},

        //Caramalized Onion Pizza with Gorgonzola and Arugula LCM
        new string [] { "Arugula",
"BlackPepper",
"CookingSpray",
"Cornmeal",
"FetaCheese",
"OliveOil",
"Onions",
"PizzaDough",
"Rosemary",
"Salt",
"Walnuts"
},

        //Pizza with sauteed Radicchio LCM
        new string [] { "BalsamicVinegar",
"BlackPepper",
"CookingSpray",
"Cornmeal",
"Garlic",
"MozzarellaCheese",
"OliveOil",
"PizzaDough",
"Radicchio",
"Ricotta",
"Salt",
"VidaliaOnion"
},

        //Indian Spiced Roast Salmon LC
        new string [] { "BlackPepper",
"Cinnamon",
"Cloves",
"Coriander",
"Cumin",
"FennelSeeds",
"Lemons",
"OliveOil",
"Salmon",
"Salt",
"Thyme",
"Turmeric",
"Yogurt"
},

        //Broiled Salmon over Parmesan Grits LCM
        new string [] { "BlackPepper",
"ChickenBroth",
"CookingSpray",
"FreshParmesan",
"FreshParsley",
"Garlic",
"Grits",
"Mushrooms",
"OliveOil",
"Onions",
"Salmon",
"Salt",
"Salt",
"Thyme",
"Water"
},

        //Grilled Salmon Salad HC
        new string [] { "BlackPepper",
"Chives",
"CookingSpray",
"Cucumber",
"FreshBasil",
"FreshParsley",
"Garlic",
"Greens",
"Lemons",
"Mango",
"Salmon",
"Salt",
"Yogurt"
},

        //Spicy Herb Grilled Salmon Steaks B
        new string [] { "BlackPepper",
"CookingSpray",
"FishStock",
"FreshBasil",
"FreshGinger",
"FreshMint",
"Garlic",
"JalapenoPeppers",
"Limes",
"Salmon",
"Salt",
"Sugar",
"WhiteVinegar"
},

        //Roast Salmon with Tomatoes and Tarragon B
        new string [] { "BlackPepper",
"Dijon",
"Salmon",
"Salt",
"SoySauce",
"Tarragon",
"Tomato"
},

        //Salmon with dill citrus sauce HC
        new string [] { "BlackPepper",
"Dill",
"Lemons",
"Limes",
"Oranges",
"RedBellPepper",
"Salmon",
"Salt",
"Shallots"
},

        //avocado alfredo LC
        new string [] { "Basil",
"BlackPepper",
"Garlic",
"Lemons",
"OliveOil",
"Parsley",
"Salt",
"Spaghetti"
},

        ///roasted veggie bisque LCM
        new string [] { "BlackPepper",
"Broccoli",
"Carrot",
"Cauliflower",
"OliveOil",
"Onions",
"Salt",
"Squash"
},

        //Oven Poached Salmon with Vegetables B
        new string [] { "BlackPepper",
"Carrot",
"ChickenBroth",
"DryWhiteWine",
"FennelBulb",
"Garlic",
"GreenBellPepper",
"RedBellPepper",
"Salmon",
"Salt",
"Thyme"
},

        //Teriyaki Burgers B
        new string [] { "BlackPepper",
"FreshGinger",
"Garlic",
"GreenOnions",
"GroundBeef",
"SoySauce"
},

        //Grilled Italian Vegetables with Pasta LCM
        new string [] { "CookingSpray",
"Eggplant",
"FreshBasil",
"FreshParmesan",
"GreenOnions",
"Lemons",
"OliveOil",
"Penne",
"PlumTomato",
"RedBellPepper",
"Salt",
"Zucchini"
},

        //Indonesian Shrimp Sate with Creamy Peanut Butter Sauce LCM
        new string [] { "Cilantro",
"CoconutMilk",
"CookingSpray",
"Garlic",
"Ginger",
"Limes",
"PeanutButter",
"RedBellPepper",
"SerranoChile",
"Shrimp",
"SoySauce",
"Sugar",
"Water"
},

        //Beef and Chicken Fajitas LCM
        new string [] { "BeefBroth",
"BlackPepper",
"ChickenBreast",
"Cilantro",
"CookingSpray",
"Cumin",
"FlankSteak",
"FlourTortilla",
"Garlic",
"GreenBellPepper",
"Limes",
"OliveOil",
"Oregano",
"RedBellPepper",
"Salsa",
"Salt",
"SourCream",
"VidaliaOnion",
"Worcestershire"
},

        //Texass Dry Rub Slow Grilled Turkey Breast LCM
        new string [] { "BlackPepper",
"BrownSugar",
"Cloves",
"CookingSpray",
"GarlicPowder",
"GroundRedPepper",
"HickoryWoodChips",
"OnionPowder",
"Paprika",
"Salt",
"TurkeyBreast"
},

        //Chipotle Marinated Pork Chops with Chimichurri Sauce LC
        new string [] { "BlackPepper",
"CanChipotleChile",
"Carrot",
"ChickenBroth",
"ChickenBroth",
"CookingSpray",
"FreshParsley",
"Garlic",
"OliveOil",
"Onions",
"Oregano",
"PorkChops",
"Salt",
"WhiteWineVinegar"
},

        //Hot and Spicy Asian Rubbed Chicken B
        new string [] { "ChickenBreast",
"Chinese5Spice",
"CookingSpray",
"GarlicPowder",
"GroundRedPepper",
"Salt",
"Sugar"
},

        //Sesame Shrimp and Couscous Salad LCM
        new string [] { "Cilantro",
"CousCous",
"Garlic",
"Peanuts",
"Peas",
"RedBellPepper",
"RiceVinegar",
"Romaine",
"SesameOil",
"Shrimp",
"SoySauce",
"VegetableOil",
"Water"
},

        //Fresh Mozzarella, tomato and Basil CousCous Salad LCM
        new string [] { "BlackPepper",
"CousCous",
"FreshBasil",
"Garlic",
"MozzarellaCheese",
"OliveOil",
"Salt",
"Shallots",
"Tomato",
"Water"
},

        //Vanilla Glazed Pork Chops with Cipollini Onions LCM
        new string [] { "BalsamicVinegar",
"BlackPepper",
"BrownSugar",
"CookingSpray",
"Cornstarch",
"MadeiraWine",
"Onions",
"PorkLoin",
"Salt",
"VanillaBean",
"VegetableOil"
},

        //Barbecued Chicken Quesadillas HCRec
        new string [] { "BarbecueSauce",
"BlockCheddarCheese",
"ChickenBreast",
"CookingSpray",
"FlourTortilla",
"FreshCilantro",
"Onions",
"Tomato"
},

        //Jagershncitzel HCM
        new string [] { "AllPurposeFlour",
"BlackPepper",
"Carrot",
"CookingSpray",
"DicedTomatoes",
"FreshParsley",
"Garlic",
"Mushrooms",
"Onions",
"Paprika",
"Pasta",
"PorkTenderloin",
"RedBellPepper",
"Salt",
"VegetableOil",
"Water"
},

        //Linzertorte HCM
        new string [] { "AllPurposeFlour",
"Almonds",
"BakingPowder",
"Cinnamon",
"CookingSpray",
"CreamCheese",
"Eggs",
"Jam",
"PowderedSugar",
"Salt",
"Sugar",
"VanillaExtract"
},

        //Marinated Tomatoes and Green Beans LC
        new string [] { "BlackPepper",
"BostonLettuce",
"Dijon",
"FreshParsley",
"GreenBeans",
"Onions",
"Salt",
"Sugar",
"Tomato",
"VegetableOil",
"WhiteWineVinegar"
},

        //Viennese Potato Cucumber Salad HC
        new string [] { "BlackPepper",
"BostonLettuce",
"CeleryRoot",
"Chives",
"Cucumber",
"DryMustard",
"Eggs",
"RedPotato",
"Salt",
"SourCream",
"Sugar",
"WhiteWineVinegar"
},

        //Cool Summer Berry Soup HC
        new string [] { "Blueberries",
"Cinnamon",
"CranberryJuice",
"DryWhiteWine",
"Raspberries",
"Strawberries",
"Sugar",
"Yogurt"
},

        //Raspberry Champagne Graita HCM
        new string [] { "Champagne",
"Limes",
"Raspberries",
"Sugar",
"Water"
},

        //Herb Oat Crusted Chicken HCM
        new string [] { "BlackPepper",
"Butter",
"ChickenBreast",
"CookingSpray",
"Eggs",
"Oats",
"Parsley",
"Sage",
"Salt",
"Thyme"
},

        //Garlic Herb Meat Loaf HC
        new string [] { "Basil",
"BlackPepper",
"CookingSpray",
"Eggs",
"Garlic",
"GroundBeef",
"GroundTurkey",
"Ketchup",
"Oats",
"Onions",
"Parsley",
"Salt"
        },

        //Baked Shrimp with Feta Cheese LCM
        new string [] { "CookingSpray",
"CrushedRedPepper",
"DryWhiteWine",
"FetaCheese",
"FreshParsley",
"Garlic",
"Linguine",
"OliveOil",
"Oregano",
"PlumTomato",
"Salt",
"Shrimp"
},

        //Raosted Eggplant and Onion Pasta LCM
        new string [] { "Basil",
"BlackPepper",
"CookingSpray",
"Eggplant",
"FetaCheese",
"FreshParmesan",
"Garlic",
"OliveOil",
"Onions",
"Penne",
"PineNuts",
"PlumTomato",
"Salt"
        },

        //Chipotle Black Bean Soup LCM
        new string [] { "BlackBeans",
"ChickenBroth",
"Chiles",
"Cumin",
"DicedTomatoes",
"Garlic",
"GroundRedPepper",
"OliveOil",
"Onions",
"Oregano",
"Water"
},

        //Creamy Asparagus Soup LC
        new string [] { "Asparagus",
"BlackPepper",
"Lemons",
"OliveOil",
"Onions",
"SoyMilk",
"Tofu",
"VegetableBroth"},

        //Marinated Vegetable Salad LC
        new string [] { "Basil",
"BlackPepper",
"Carrot",
"FreshParmesan",
"FreshParsley",
"OliveOil",
"Oregano",
"RedBellPepper",
"RedOnions",
"RedWineVinegar",
"Salt",
"Water",
"Zucchini"
},

        //Open Faced Burgers with Onion Mushroom toppings LCM
        new string [] { "BalsamicVinegar",
"EnglishMuffins",
"GroundBeef",
"GroundRedPepper",
"Mushrooms",
"OliveOil",
"Paprika",
"Salt",
"SweetOnions",
"Thyme"
},

        //Curried Beef with Potatoes and Peas HC
        new string [] { "BlackPepper",
"ChickenBroth",
"Curry",
"FreshCilantro",
"GroundBeef",
"MangoChutney",
"OliveOil",
"Onions",
"Peas",
"RedPotato",
"Salt"
},

        //Meatballs and Peppers HCM
        new string [] { "AllPurposeFlour",
"Basil",
"BeefConsomme",
"BlackPepper",
"Bread",
"Eggs",
"Garlic",
"GreenBellPepper",
"OliveOil",
"Onions",
"Oregano",
"RedBellPepper",
"Salt",
"Water",
"WhiteWineVinegar",
"YellowBellPepper"
},

        //Quick Chili Con Carne HCM
        new string [] { "BeefBroth",
"BlackBeans",
"BlockCheddarCheese",
"Corn",
"FreshCilantro",
"GroundBeef",
"Onions",
"RedBellPepper",
"SourCream",
"TomatoJuice"
},

        //Carribean Styel Beef Soft Tacos LCM HCM
        new string [] { "BlackPepper",
"CornTortillas",
"Cumin",
"DicedTomatoes",
"Garlic",
"GreenBellPepper",
"GroundBeef",
"PimentoOlives",
"Plantain",
"Romaine",
"Salt"
},

        //Spicy Melon Salad HC
        new string [] { "Cantaloupe",
"Cumin",
"FreshMint",
"JalapenoPeppers",
"Sugar",
"Water"
},

        //Lavendar Lemonade B
        new string [] { "Lavender",
"Lemons",
"Sugar",
"Water"
},

        //Lavendar Pineapple Granita HCM
        new string [] { "Lavender",
"Pineapple",
"Sugar",
"Water"
},

        //Roasted Corn, Black Bean and Mango Salad HCM
        new string [] { "BlackBeans",
"Chiles",
"Cilantro",
"Corn",
"Cumin",
"Garlic",
"Greens",
"Limes",
"Mango",
"RedBellPepper",
"RedOnions",
"Salt",
"VegetableOil"
},

        //Corn and Shrimp Tortilla Soup HCM
        new string [] { "BlackPepper",
"ChickenBroth",
"Corn",
"CornTortillas",
"Cumin",
"DicedTomatoes",
"FishStock",
"FreshCilantro",
"Garlic",
"GreenOnions",
"JalapenoPeppers",
"Limes",
"Oregano",
"RedBellPepper",
"Shrimp",
"VegetableOil"
},

        //Cumin Spiked Popcorn HCM
        new string [] { "Coriander",
"Cumin",
"GroundRedPepper",
"OliveOil",
"Popcorn",
"Salt"
},

        //Mussels steamed in White Wine LCM
        new string [] { "BlackPepper",
"DryWhiteWine",
"FreshParsley",
"Mussels",
"OliveOil",
"Onions"
},

        //Summer Squash, Carrot, Green Pea Ragout over Polenta HCM
        new string [] { "AsiagoCheese",
"BlackPepper",
"Butter",
"Carrot",
"FreshBasil",
"FreshParsley",
"Garlic",
"Lemons",
"OliveOil",
"Onions",
"Peas",
"Polenta",
"Salt",
"Water",
"YellowSquash"
},

        //Bell Pepper and Potato Tagine over CousCous HCM
        new string [] {"ChickPeas",
"CousCous",
"CrushedRedPepper",
"FreshParsley",
"Harissa",
"Mint",
"OliveOil",
"Onions",
"Potatoes",
"RedBellPepper",
"Salt",
"Tomato",
"TomatoPaste",
"Water"
 },

        //Cosmire Crab Salad with Corn Chips LCM
        new string [] { "Corn",
"CornTortillas",
"Crab",
"CreamCheese",
"FreshCilantro",
"Limes",
"Mayonnaise",
"Salt",
"TacoSeasoning",
"VegetableOil"
},

        //Celestial Chicken, Mint, Cucumebr skewers with spring onion sauce LC
        new string [] { "BlackPepper",
"FreshGinger",
"Garlic",
"Miso",
"OrangeJuice",
"Salt",
"SesameOil",
"SesameSeeds",
"Shrimp",
"VegetableOil",
"Water"
},

        //Grilled Chicken Salad with Cherries HC
        new string [] { "BlackPepper",
"Cherries",
"ChickenBreast",
"CookingSpray",
"Dijon",
"Greens",
"OliveOil",
"RedWineVinegar",
"Salt",
"Sugar",
"Thyme",
"Water"
},

        //Thai Steak with Basil and Mint B
        new string [] { "BlackPepper",
"CherryTomatoes",
"ChiliPaste",
"CookingSpray",
"Cucumber",
"FishStock",
"FlankSteak",
"FreshBasil",
"FreshMint",
"Limes",
"RedBellPepper",
"RedOnions",
"Romaine",
"Salt",
"Sugar",
"Water"
},

        //Indonesian Coriander Honey Chicken LC
        new string [] { "ChickenThighs",
"ChiliPaste",
"Coriander",
"FreshGinger",
"Garlic",
"Honey",
"Peanuts",
"SoySauce"
},

        //Steamed Bali Style Sea Bass LC
        new string [] { "ChiliPaste",
"FreshGinger",
"Garlic",
"MacadamiaNuts",
"Salt",
"SeaBass",
"Shallots",
"Tomato",
"VegetableOil",
"Watercress"
},

        //Malaysian Lime-Coconut Swordfish LC
        new string [] { "BrownSugar",
"ChiliPaste",
"CoconutMilk",
"CookingSpray",
"FishStock",
"FreshCilantro",
"Garlic",
"LemonGrass",
"Lemons",
"Limes",
"Shallots",
"SwordFish"
},

        //Chinese BBQ pork tenderloin LC
        new string [] { "BrownSugar",
"Chinese5Spice",
"CookingSpray",
"GroundRedPepper",
"Hoisin",
"OrangeJuice",
"PorkTenderloin",
"Salt",
"SesameOil"
},

        //Singarpore Spicy Shrimp over spinach
        new string [] { "BrownSugar",
"ChiliPaste",
"MincedGarlic",
"OysterSauce",
"RedBellPepper",
"Sake",
"Shrimp",
"Spinach",
"VegetableOil"
},

        //Chicken Caesar Salad LCM
        new string [] { "BlackPepper",
"Croutons",
"Dijon",
"Garlic",
"Lemons",
"OliveOil",
"Parmesan",
"RedBellPepper",
"Romaine",
"Salt",
"Sugar",
"WholeChicken",
"Worcestershire"
},

        //Mediterranean Shrimp Salad LCM
        new string [] { "BlackPepper",
"FrenchBread",
"FreshBasil",
"FreshParsley",
"GreenOlives",
"Greens",
"Lemons",
"OliveOil",
"PlumTomato",
"RedOnions",
"Shrimp"
},

        //Vegetable Panzanella with Tuna LCM
        new string [] { "BlackPepper",
"Bread",
"Cucumber",
"FreshBasil",
"FreshParsley",
"Garlic",
"KalamataOlives",
"OliveOil",
"RedBellPepper",
"RedOnions",
"RedWineVinegar",
"Salt",
"Tomato",
"Tuna",
"Zucchini"
},

        //Minted Strawberries and Bananas in Cantaloupe Cups HC
        new string [] { "Bananas",
"Cantaloupe",
"FreshMint",
"Lemons",
"OrangeJuice",
"Strawberries",
"Sugar",
"VanillaExtract"
},

        //Sweet and Spciy BBQ Beans HCRec
        new string [] { "BarbecueSauce",
"CiderVinegar",
"Dijon",
"Garlic",
"HotPepperSauce",
"Kale",
"KidneyBeans",
"OliveOil",
"Onions",
"Water"
},

        //Pork Ragout HCM
        new string [] { "BlackPepper",
"CanWholeTomatoes",
"ChickenBroth",
"DryRedWine",
"FreshRomano",
"Onions",
"Penne",
"PorkTenderloin",
"Rosemary",
"Salt",
"TurkeySausage"
},

        //Short Sharp Chops HCM
        new string [] { "BlackPepper",
"FreshGinger",
"Garlic",
"GreenOnions",
"OliveOil",
"OrangeJuice",
"PorkChops",
"SoySauce"
},

        //Greek Lamb Burgers with Cucumber Sauce HC LCM
        new string [] { "Bread",
"RedOnions",
"FreshMint",
"Lemons",
"Salt",
"GroundRedPepper",
"GroundLamb",
"Spinach",
"Garlic",
"Cucumber",
"Yogurt",
"FreshParsley",
"Garlic",
"CookingSpray"
},

        //Chunky Chipotle Chicken Chili HC
        new string [] { "Bacon",
"CanChipotleChile",
"ChickenBreast",
"Coriander",
"Corn",
"Garlic",
"PintoBeans",
"RedOnions",
"RoastedRedPeppers",
"Salsa"
},

        //Gazpacho Shrimp Salad LC
        new string [] { "BlackPepper",
"Cucumber",
"FreshBasil",
"Garlic",
"GreenBeans",
"GreenBellPepper",
"GreenOnions",
"Greens",
"HotPepperSauce",
"OliveOil",
"RedWineVinegar",
"Salt",
"Shrimp",
"Sugar",
"Tomato",
"TomatoJuice"
},

        //Lemon-Dill CousCous with Chicken and Vegetables HC
        new string [] { "BlackPepper",
"ChickenBreast",
"ChickenBroth",
"CousCous",
"Dill",
"FreshParsley",
"Lemons",
"OliveOil",
"RedBellPepper",
"Salt",
"Water",
"YellowSquash"
},

        //Flank Steak with Corn Tomato Relish and Grilled Garlic Bread HC
        new string [] { "BlackPepper",
"Bread",
"CookingSpray",
"Corn",
"CrushedRedPepper",
"DryRedWine",
"FlankSteak",
"FreshBasil",
"Garlic",
"Limes",
"OliveOil",
"Onions",
"Salt",
"SoySauce",
"Sugar",
"Tomato"
},

        //Garden Vegetable Stir Fry with Tofu and Brown Rice LCM
        new string [] { "Carrot",
"Cornstarch",
"CrushedRedPepper",
"Onions",
"OysterSauce",
"RedBellPepper",
"Rice",
"RiceVinegar",
"SesameOil",
"SnowPeas",
"SoySauce",
"Sugar",
"Tofu",
"VegetableBroth",
"VegetableOil",
"Water",
"WaterChestnuts",
"Zucchini"
},

        //Tomato Chutney LC
        new string [] { "Cumin",
"FreshGinger",
"Garlic",
"Salt",
"Sugar",
"Tomato",
"Turmeric",
"VegetableOil"
},

        //Kale Cabbage Saute LC
        new string [] { "Cumin",
"FreshGinger",
"GreenCabbage",
"JalapenoPeppers",
"Kale",
"Onions",
"Salt",
"Sugar",
"Turmeric",
"VegetableOil",
"Water"
},

        //Fragrant Chicken in Creamy Almond Sauce LC
        new string [] { "AllPurposeFlour",
"Almonds",
"Almonds",
"BayLeaves",
"Cardamom",
"ChickenBreast",
"ChickenBroth",
"Cinnamon",
"Cinnamon",
"Curry",
"Garlic",
"OliveOil",
"Onions",
"RedBellPepper",
"Salt",
"SourCream",
"Sugar",
"Turmeric"
},

        //Hearty Kidney Beans and Spinach HCM
        new string [] { "Coriander",
"Cumin",
"FreshCilantro",
"GaramMasala",
"Garlic",
"JalapenoPeppers",
"KidneyBeans",
"Lemons",
"Onions",
"Salt",
"Spinach",
"Turmeric",
"VegetableOil"
},

        //Spicy Garlic Roasted Potatoes HCM
        new string [] { "CookingSpray",
"Cumin",
"Garlic",
"GroundRedPepper",
"RedPotato",
"Salt",
"VegetableOil"
},

        //Red Lentil Soup HCM
        new string [] { "Cumin",
"FreshCilantro",
"Garlic",
"GroundRedPepper",
"Limes",
"MincedOnion",
"RedLentils",
"Salt",
"Sugar",
"Turmeric",
"VegetableBroth",
"VegetableOil",
"Water"
},

        //Fresh Cherry Orange Soup
        new string [] { "Cherries",
"CherryJuice",
"Oranges",
"SourCream",
"Sugar",
"Yogurt"
},

        //Whole Wheat Spaghetti with Arugula  HCM
        new string [] { "Arugula",
"BlackPepper",
"CrushedRedPepper",
"Garlic",
"OliveOil",
"Parmesan",
"RedWineVinegar",
"Salt",
"Spaghetti",
"Tomato"
},

        //Summer Garden Pasta HC
        new string [] { "BlackPepper",
"Carrot",
"FreshMint",
"FreshParsley",
"Garlic",
"OliveOil",
"RedBellPepper",
"RedOnions",
"Salt",
"Spaghetti",
"Thyme",
"Tomato",
"YellowSquash"
},

        //Swiss Chard with Onions LC
        new string [] { "BlackPepper",
"OliveOil",
"Onions",
"Salt",
"SwissChard",
"Worcestershire"
},

        //Sesame Asparagus with Garlic LC
        new string [] { "Asparagus",
"Garlic",
"RiceVinegar",
"SesameOil",
"SesameSeeds",
"SoySauce",
"Water"
},

        //Filet Mignon with Mushroom Wine Sauce LCM
        new string [] { "BeefConsomme",
"BlackPepper",
"Butter",
"Cornstarch",
"DryRedWine",
"FiletMignon",
"Shallots",
"ShitakeMushrooms",
"SoySauce",
"Thyme"
},

        //Double Vanilla Meringue Cookies BM
        new string [] { "CreamOfTartar",
"Eggs",
"Salt",
"Sugar",
"VanillaBean",
"VanillaExtract"
},

        //Chicken Pasta Salad HC
        new string [] { "BlackBeans",
"Carrot",
"ChickenBreast",
"Corn",
"Cumin",
"Dijon",
"GreenOnions",
"HotPepperSauce",
"OliveOil",
"Pasta",
"Peas",
"RedBellPepper",
"RiceVinegar",
"Salt",
"YellowSquash"
},

        //Chicken Bruschetta LC
        new string [] { "BalsamicVinegar",
"BlackPepper",
"ChickenBreast",
"CookingSpray",
"FreshBasil",
"FreshParmesan",
"Garlic",
"GarlicPowder",
"Mushrooms",
"OliveOil",
"PlumTomato",
"RedOnions",
"Salt",
"Zucchini"
},

        //Marsala Shrimp HCM
new string [] { "AllPurposeFlour",
"BlackPepper",
"Garlic",
"Linguine",
"Marsala",
"Mushrooms",
"PlumTomato",
"Salt",
"Shrimp",
"VegetableOil",
"Water"
},

//Pineapple Brown Sugar Frozen Yogurt HC
new string [] { "BrownSugar",
"Pineapple",
"Yogurt",
"VanillaExtract"
},

//Eggplant and Portobellow Mushroom Melts LCM
new string [] { "Bread",
"Eggplant",
"FreshBasil",
"PortabellaMushrooms",
"Provolone",
"RoastedRedPeppers",
"Spinach",
"Vinaigrette"
},

//Watermelon Canteloupe Sorbet HCM
new string [] { "Cantaloupe",
"Watermelon",
"Yogurt"
},

//Italian Beef Subs HCM
new string [] { "BeefBroth",
"Bread",
"Garlic",
"GreenBellPepper",
"OliveOil",
"Oregano",
"PickledVeggies",
"RoastBeef"
},

//Greek Meatball Pitas LCM
new string [] { "BlackPepper",
"Cucumber",
"Dill",
"Garlic",
"Greens",
"GroundLamb",
"Onions",
"Onions",
"Oregano",
"Pitas",
"PlumTomato",
"Salt",
"Sugar",
"Yogurt"
},

//BBQ Pork and Coleslaw Hoagies LCM
new string [] { "BarbecueSauce",
"Bread",
"Cabbage",
"Carrot",
"CookingSpray",
"Horseradish",
"Mayonnaise",
"Pickles",
"PorkTenderloin",
"SourCream",
"Sugar"
},

//Tuna Melt LC/HC 
new string [] { "BlockCheddarCheese",
"EnglishMuffins",
"GreenOnions",
"Horseradish",
"Mayonnaise",
"Mustard",
"RedBellPepper",
"Tomato",
"Tuna",
"Worcestershire"
},

//Tuscan Seared Tuna Sandwhiches LCM/HC
new string [] { "ArtichokeHearts",
"BlackPepper",
"Bread",
"CookingSpray",
"Mayonnaise",
"MincedGarlic",
"Pimento",
"Rosemary",
"TunaSteaks"
},

//Pork Chop Suey LCM
new string [] { "AllPurposeFlour",
"BokChoy",
"Celery",
"ChickenBroth",
"Cornstarch",
"DrySherry",
"Garlic",
"GreenOnions",
"GroundGinger",
"Mushrooms",
"PorkTenderloin",
"RedBellPepper",
"Rice",
"SoySauce",
"VegetableOil",
"WaterChestnuts"
},

//Vichyssoise HCM
new string [] { "BlackPepper",
"ChickenBroth",
"Chives",
"HalfandHalf",
"Leeks",
"Potatoes",
"Salt",
"VegetableOil"
},

//Swiss Steak LCM
new string [] { "AllPurposeFlour",
"BlackPepper",
"ChuckRoast",
"Garlic",
"Onions",
"Salt",
"VegetableOil",
"Water"
},

//
        //watch those damn commas
        //do 100 in excel, sort, filter, copy here rinse repeat
        //be very specific - ex chickenBreast, chickenLeg, freshThyme, driedThyme

	}; 

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

                if (lesson == 1)
                {
                    availableLessons.text += "Crispy Potato Skin Wedges Phillips p.6 (HCM)\n";
                }

                if (lesson == 2)
                {
                    availableLessons.text += "French Fries  Phillips p.7 (HCM)\n";
                }
                    
                if (lesson == 3)
                {
                    availableLessons.text += "Potato Croquettes Phillips p.8 (FD) \n";
                }
                        
               if (lesson == 4)
                {
                    availableLessons.text += "Potato Au Gratin  Phillips p.9 (FD)\n";
                        }

                    if (lesson == 5)
                    {
                    availableLessons.text += "Rosemary Russet Potato Potato Chips Phillips p.10 (HCM) \n";
                    }

                    if (lesson == 6)
                    {
                    availableLessons.text += "Roasted Winter Veggies Phillips p. 11 (LC)\n";
                    }

                    if (lesson == 7)
                    {
                    availableLessons.text += "Fried Meatballs in Tomato Sauce Phillips p.12 (HC)\n";
                    }

                    if (lesson == 8)
                    {
                    availableLessons.text += "Bacon Wrapped Shrimp Phillips p.13 (B)\n";
                    }

                    if (lesson == 9)
                    {
                    availableLessons.text += "Cheddar Bacon Croquette Phillips p.14 (FD)\n";
                    }

                    if (lesson == 10)
                    {
                    availableLessons.text += "Crispy Fried Spring Rolls Phillips p. 15 (HCM)\n";
                    }

                    if (lesson == 11)
                    {
                    availableLessons.text += "Crab Croquettes Phillips p.16 (FD)\n";
                    }

                    if (lesson == 12)
                    {
                    availableLessons.text += "FetaTriangles Phillips p.17 (FD)\n";
                    }

                    if (lesson == 13)
                    {
                    availableLessons.text += "Korean BBQ Satay Phillips p.18 (HCM)\n";
                    }

                    if (lesson == 14)
                    {
                    availableLessons.text += "Jerk Chicken Wings Phillips p.19 (LCM)\n";
                    }

                if (lesson == 15)
                {
                    availableLessons.text += "Morrocon Meatballs w/ Mint Yogurt Phillips p.20 (FD) \n";
                }

                if (lesson == 16)
                {
                    availableLessons.text += "Pigs in a Blanket Phillips p. 21 (HCRec)\n";
                }

                if (lesson == 17)
                {
                    availableLessons.text += "Stuffed Garlic Mushrooms Phillips p.22 (HCM) \n";
                }

                if (lesson == 18)
                {
                    availableLessons.text += "Chimichurri Steak Phillips p.23 (LC) \n";
                }

                if (lesson == 19)
                {
                    availableLessons.text += "Roasted Heirloom Tomato with Baked Feta Phillips p.24 (LC) \n";
                }

                if (lesson == 20)
                {
                    availableLessons.text += "Portabella Pepperoni Pizza Phillips p.25 (LC)\n";
                }

                if (lesson == 21)
                {
                    availableLessons.text += "Mushroom and Feta Frittata Phillips p.26 (LC)\n";
                }

                if (lesson == 22)
                {
                    availableLessons.text += "Roasted Rack of Lamb with Macadamia Crust Phillips p.23 (LC)\n";
                }

                if (lesson == 23)
                {
                    availableLessons.text += "Salmon with Dill Sauce Phillips p.28 (LC)\n";
                }

                if (lesson == 24)
                {
                    availableLessons.text += "Teriyaki Glazed Halibt Steak Phillips p.29 (HCM)\n";
                }

                if (lesson == 25)
                {
                    availableLessons.text += "Cajun Shrimp Phillips p.23 (LC)\n";
                }

                if (lesson == 26)
                {
                    availableLessons.text += "Cod Fish Nuggets Phillips p.31 (HCM)\n";
                }

                if (lesson == 27)
                {
                    availableLessons.text += "Country Chicken Tenders Phillips p.33 (HCM)\n";
                }

                if (lesson == 28)
                {
                    availableLessons.text += "Grilled Cheese Brioche Phillips p.33 (FD)\n";
                }

                if (lesson == 29)
                {
                    availableLessons.text += "Grilled Cheese Phillips p.33 (FD)\n";
                }

                if (lesson == 30)
                {
                    availableLessons.text += "Mini Cheeseburger Sliders Phillips p.34 (LCM)\n";
                }

                if (lesson == 31)
                {
                    availableLessons.text += "Peanut Butter Marshmellow Fluff Turnovers Phillips p.31 (FD)\n";
                }

                if (lesson == 32)
                {
                    availableLessons.text += "Chocolate Cake Phillips p.37 (FD)\n";
                }

                if (lesson == 33)
                {
                    availableLessons.text += "Apricot BlackBerry Crumble Phillips p.37 (FD) \n";
                }

                if (lesson == 34)
                {
                    availableLessons.text += "Vanilla Souffle Phillips p.38 (FD)\n";
                }

                if (lesson == 35)
                {
                    availableLessons.text += "Roasted Cabbage Rolls CL p.12 (FD)\n";
                }

                if (lesson == 36)
                {
                    availableLessons.text += "Chocolate Espresso Pudding CL p.12\n";
                }

                if (lesson == 37)
                {
                    availableLessons.text += "Confetti Basmati Rice Pilaf with Toasted Flaxeed CL p.14 (FD)\n";
                }

                if (lesson == 38)
                {
                    availableLessons.text += "Confetti Basmat Rice Pilaf with Toasted Flaxeed CL p.14 (FD) \n";
                }

                if (lesson == 39)
                {
                    availableLessons.text += "Confetti Long Grain Rice Pilaf with Toasted Flaxeed CL p.14 (FD) \n";
                }

                if (lesson == 40)
                {
                    availableLessons.text += "Mango Coconut Bread Pudding CL p.14 (FD)\n";
                }

                if (lesson == 41)
                {
                    availableLessons.text += "Garbanzo Stew CL.15 (FD) \n";
                }

                if (lesson == 42)
                {
                    availableLessons.text += "Noodle Salad with Shrimp and Chile Dressing CL p.15 (HCM)\n";
                }

                if (lesson == 43)
                {
                    availableLessons.text += "Hot Beans and Cheese CL p.16 (HCM)\n";
                }

                if (lesson == 44)
                {
                    availableLessons.text += "Indian Egg Roll Stirps CL p.17 (HC) \n";
                }

                if (lesson == 45)
                {
                    availableLessons.text += "Creamy Feta Spinach Dip CL p.16 (LC) \n";
                }

                if (lesson == 46)
                {
                    availableLessons.text += "Cajun Tortilla Chips CL 17 (HCM) \n";
                }

                if (lesson == 47)
                {
                    availableLessons.text += "Spicy Caribbean Black Benas and Rice CL p.18 (HCM)\n";
                }

                if (lesson == 48)
                {
                    availableLessons.text += "Linguine with Red Clam Sauce CL p.19 (HCM)\n";
                }

                if (lesson == 49)
                {
                    availableLessons.text += "Tropical Tofu Smoothie CL p.19 (HCM) \n";
                }

                if (lesson == 50)
                {
                    availableLessons.text += "Deluxe Roast Beef Sandwhich CL p.19 (HC) \n";
                }

                if (lesson == 51)
                {
                    availableLessons.text += "Bueno Breakfast Burrito CL p.22 (LCM) \n";
                }

                if (lesson == 52)
                {
                    availableLessons.text += "Pork and Pear Sauce with Lemon Vodka Sauce CL p.22 (HCM) \n";
                }

                if (lesson == 53)
                {
                    availableLessons.text += "White Bean Soup with Peppers and Bacon  CL p.25 (HCM)\n";
                }

                if (lesson == 54)
                {
                    availableLessons.text += "Tortilla Casserole with Swiss Chard CL p.28 (LCM) \n";
                }

                if (lesson == 55)
                {
                    availableLessons.text += "Scotch Broth CL p.31 (HC) \n";
                }

                if (lesson == 56)
                {
                    availableLessons.text += "Roast Pork with Dried Fruits and Squash CL p.31 (HCM) \n";
                }

                if (lesson == 57)
                {
                    availableLessons.text += "Stir Fried Vegetables and Tofu CL p.35 (LCM) \n";
                }

                if (lesson == 58)
                {
                    availableLessons.text += "Miso Chicken with Brown Rice CL p.35 (LCM) \n";
                }

                if (lesson == 59)
                {
                    availableLessons.text += "Spicy Steak Fries CL p.42 (LCM) \n";
                }

                if (lesson == 60)
                {
                    availableLessons.text += "Baked Triple Bean Pot CL p.43 (HCM) \n";
                }

                if (lesson == 61)
                {
                    availableLessons.text += "Hearty Navy Bean Soup CL p.44 (HC) \n";
                }

                if (lesson == 62)
                {
                    availableLessons.text += "Onion-Smothered Brisket and Veggies CL p.44 (HC) \n";
                }

                if (lesson == 63)
                {
                    availableLessons.text += "BBQ Pork Chops CL p.45 (LCM) \n";
                }

                if (lesson == 64)
                {
                    availableLessons.text += "Lentil Potage with Spinach and Yogurt CL p.47 (HCM) \n";
                }

                if (lesson == 65)
                {
                    availableLessons.text += "Huevos Rancheros CL p.48 (LCM) \n";
                }

                if (lesson == 66)
                {
                    availableLessons.text += "Caldo de Res CL p.48 (LCM) \n";
                }

                if (lesson == 67)
                {
                    availableLessons.text += "Marinated Veggies CL p.48 (HC) \n";
                }

                if (lesson == 68)
                {
                    availableLessons.text += "Chicken Salpicon CL p.49 (LC) \n";
                }

                if (lesson == 69)
                {
                    availableLessons.text += "Green Suaced Chicken Enchiladas CL p.49 (HCM) \n";
                }

                //
                if (lesson == 70)
                {
                    availableLessons.text += "Salsa Manuela CL p.51 (B) \n";
                }

                if (lesson == 71)
                {
                    availableLessons.text += "Four Alarm Red Salsa CL p.51 (B) \n";
                }

                if (lesson == 72)
                {
                    availableLessons.text += "Green Salsa  CL p.51 (B) \n";
                }

                if (lesson == 73)
                {
                    availableLessons.text += "All Purpose Pizza Dough CL p.52 (HCM) \n";
                }

                if (lesson == 74)
                {
                    availableLessons.text += "Lemon Basil Snapper with Roasted Peppers  CL p.55 (LCM) \n";
                }

                if (lesson == 75)
                {
                    availableLessons.text += "Beef Carbonnade CL p.56 (HCM) \n";
                }

                if (lesson == 76)
                {
                    availableLessons.text += "Broiled Salmon with Sweet and Sour Cucumbers CL p.62 (LCM) \n";
                }

                if (lesson == 77)
                {
                    availableLessons.text += "Smoked Fish Spread CL p.62 (LCM) \n";
                }

                if (lesson == 78)
                {
                    availableLessons.text += "Strawberry Lemon Syrup CL p.64 (HCM) \n";
                }

                if (lesson == 79)
                {
                    availableLessons.text += "Lemony Orzo Salad CL p.65 (LCM) \n";
                }

                if (lesson == 80)
                {
                    availableLessons.text += "Honey Left me in a cruch chicken with linguine p.66 (HCM) \n";
                }

                if (lesson == 81)
                {
                    availableLessons.text += "Veal Mediterranean p.66 (HCM) \n";
                }

                if (lesson == 82)
                {
                    availableLessons.text += "Linguine with Clams and Artichokes in Red Sauce p.67 (HCM) \n";
                }

                if (lesson == 83)
                {
                    availableLessons.text += "Tuscan Chicken Stew p.67 (HCM) \n";
                }

                if (lesson == 84)
                {
                    availableLessons.text += "Curried Chicken CousCous p.68 (LCM) \n";
                }

                if (lesson == 85)
                {
                    availableLessons.text += "Greek Shrimp and Spinach with Penne p.68 (HCM) \n";
                }

                if (lesson == 86)
                {
                    availableLessons.text += "Pork and Pineapple Stir Fry p.69 (HCM) \n";
                }

                if (lesson == 87)
                {
                    availableLessons.text += "Cavatappi with Kale and Fava Beans p.71 (HCM) \n";
                }

                if (lesson == 88)
                {
                    availableLessons.text += "Cavatappi with Kale and Kidney Beans p.71 (HCM) \n";
                }

                if (lesson == 89)
                {
                    availableLessons.text += "Collard Greens with Lima Beans and Smoked Turkey p.71 (HCM) \n";
                }

                if (lesson == 90)
                {
                    availableLessons.text += "Halibut Wrapped in Greens p.72 (LC) \n";
                }

                if (lesson == 91)
                {
                    availableLessons.text += "Creamy Polenta and Saute of Mixed Greens p.72 (LC) \n";
                }

                if (lesson == 92)
                {
                    availableLessons.text += "Pork, Kale and Bok Choy Stir Fry p.72 (HCM) \n";
                }

                if (lesson == 93)
                {
                    availableLessons.text += "Miso Salmon with Asparagus p.74 (LCM) \n";
                }

                if (lesson == 94)
                {
                    availableLessons.text += "Shrimp and Squash Penne p.77 (HCM) \n";
                }

                if (lesson == 95)
                {
                    availableLessons.text += "Shrimp and Asparagus with Ginger Sesame Sauce p.78 (HCM) \n";
                }

                if (lesson == 96)
                {
                    availableLessons.text += "Soft Shrimp Tacos with Tropical Salsa  p.78 (HCM) \n";
                }

                if (lesson == 97)
                {
                    availableLessons.text += "Savory Braised Pork Supper HCM p.79 (HCM) \n";
                }

                if (lesson == 98)
                {
                    availableLessons.text += "Osso Buco p.79 (HCM) \n";
                }

                if (lesson == 99)
                {
                    availableLessons.text += "Tuscan Lamb Shanks p.80 (HCM) \n";
                }

                if (lesson == 100)
                {
                    availableLessons.text += "Beef Bourguignonne HC p.80 (HCM) \n";
                }

                if (lesson == 101)
                {
                    availableLessons.text += "Pasta with Mussels and Monteray Jack LCM p.83 (LCM) \n";
                }

                if (lesson == 102)
                {
                    availableLessons.text += "Caramalized Corn Saute LCM p.84 (LCM) \n";
                }

                if (lesson == 103)
                {
                    availableLessons.text += "Tomato Sauce B p.84 (B) \n";
                }

                if (lesson == 104)
                {
                    availableLessons.text += "Pepper Steak with Port Wine Mushroom Suace HC p.85 (HC) \n";
                }

                if (lesson == 105)
                {
                    availableLessons.text += "Beef Bourguignonne Topped Potatoes p.87 (HCM) \n";
                }

                if (lesson == 106)
                {
                    availableLessons.text += "Chili-Cheese Rice Burritos LCM p.97 (LCM) \n";
                }

                if (lesson == 107)
                {
                    availableLessons.text += "Crispy Sesame Shrimp HC p.97 (HCM) \n";
                }

                if (lesson == 108)
                {
                    availableLessons.text += "Meat Sauce Macaroni HCM p.97 (HCM) \n";
                }

                if (lesson == 109)
                {
                    availableLessons.text += "Spaghetti with Broccoli and Ham p.97 (LCM) \n";
                }

                if (lesson == 110)
                {
                    availableLessons.text += "White Bean salad with Shrimp and Arugala HCM p.98 (HCM) \n";
                }

                if (lesson == 111)
                {
                    availableLessons.text += "Tabbouleh with arugula and Chicken LC p.98 (LC) \n";
                }

                if (lesson == 112)
                {
                    availableLessons.text += "Field Salad with Roasted Leeks, mushrooms and Feta p.97 (LCM) \n";
                }

                if (lesson == 113)
                {
                    availableLessons.text += "Potato Salad with Arugula Pesto, Peas, Zucchini p.97 (HCM) \n";
                }

                if (lesson == 114)
                {
                    availableLessons.text += "Indian Chicken Curry p.97 (HCM) \n";
                }

                if (lesson == 115)
                {
                    availableLessons.text += "Savory Roasted Vegetable Pitas  p.97 (LCM, HCM) \n";
                }

                if (lesson == 116)
                {
                    availableLessons.text += "Grilled Asparagus p.97 (LC) \n";
                }

                if (lesson == 117)
                {
                    availableLessons.text += "Warm Scallop Salad with Lime and Cilantro  p.97 (LCM) \n";
                }

                if (lesson == 118)
                {
                    availableLessons.text += "Suquet of Cod p.97 (HCM) \n";
                }

                if (lesson == 119)
                {
                    availableLessons.text += "Vegetable Donburi over Seasoned Rice p.97 (HCM) \n";
                }

                if (lesson == 120)
                {
                    availableLessons.text += "Cuban Chicken and Plantain Stew  CL p.104 (HCM) \n";
                }

                if (lesson == 121)
                {
                    availableLessons.text += "Spring Pasole CL p.121 (LC) \n";
                }

                if (lesson == 122)
                {
                    availableLessons.text += "Risotto with Asparagus Fennel and Leeks CL p.105 (HCM) \n";
                }

                if (lesson == 123)
                {
                    availableLessons.text += "Chunky Minestrone Primavera with Clams CL p.107 (HCM) \n";
                }

                if (lesson == 124)
                {
                    availableLessons.text += "White Beans hummus Dip  CL p.110 (HC) \n";
                }

                if (lesson == 125)
                {
                    availableLessons.text += "Shrimp with Roasted pepper Horseradish Dip CL p.97 (LC) \n";
                }

                if (lesson == 126)
                {
                    availableLessons.text += "Apricot Stuffed Spice Rubbed Pork Loin CL p.111 (HC) \n";
                }

                if (lesson == 127)
                {
                    availableLessons.text += "Sweet and Hot Onion Salsa CL p.97 (HC) \n";
                }

                if (lesson == 128)
                {
                    availableLessons.text += "Spicy Chicken Breasts with Caramelized Onion Red Pepper Relish CL p. (LC) \n";
                }

                if (lesson == 129)
                {
                    availableLessons.text += "Creole Catfish with Vidalia Olvie Relish CL p.113 (LC) \n";
                }

                if (lesson == 130)
                {
                    availableLessons.text += "Shrimp Creole Potpie HCM CL p.117 (HCM) \n";
                }

                if (lesson == 131)
                {
                    availableLessons.text += "Pepper Slaw CL p. 118 (B) \n";
                }

                if (lesson == 132)
                {
                    availableLessons.text += "White Gazpacho CL p.119 (B) \n";
                }

                if (lesson == 133)
                {
                    availableLessons.text += "Darcy's Veggie Chili CL p.119 (HCM) \n";
                }

                if (lesson == 134)
                {
                    availableLessons.text += "Mary's Salsa CL p.119 (B) \n";
                }

                if (lesson == 135)
                {
                    availableLessons.text += "Traditional Spanish Paella  CL p. 121 (HCM) \n";
                }

                if (lesson == 136)
                {
                    availableLessons.text += "Spicy Paella with Chile, Lime and cilantro  CL p. 136 (HCM) \n";
                }

                if (lesson == 137)
                {
                    availableLessons.text += "Seafood Paella  CL p. 122 (HCM) \n";
                }

                if (lesson == 138)
                {
                    availableLessons.text += "Pad Thai CL p.123 (HCM) \n";
                }

                if (lesson == 139)
                {
                    availableLessons.text += "Shrimp and Broccoli in Chili Sauce CL p.123 (HCM) \n";
                }

                if (lesson == 140)
                {
                    availableLessons.text += "Chicken Cashew CL p. 124 (HCM) \n";
                }

                if (lesson == 141)
                {
                    availableLessons.text += "Asian Vegetable Stir Fry CL p.125 (HCM) \n";
                }

                if (lesson == 142)
                {
                    availableLessons.text += "Fried Rice with Smoked Ham CL p.142 (HC) \n";
                }

                if (lesson == 143)
                {
                    availableLessons.text += "Creamy Caesar Salad with Spicy Croutons CL p.128 (LCM) \n";
                }

                if (lesson == 144)
                {
                    availableLessons.text += "Super Duper Sunrise Shake CL p. 133 (HC) \n";
                }

                if (lesson == 145)
                {
                    availableLessons.text += "Pan Seared Cod over Vegetable Ragout CL p. 135 (LCM) \n";
                }

                if (lesson == 146)
                {
                    availableLessons.text += "Fresh Fruit Compote with Orange Lime Drizze CL p. 135 (HC) \n";
                }

                if (lesson == 147)
                {
                    availableLessons.text += "Chicken with Mushrooms and Leeks CL p. 136 (HCM) \n";
                }

                if (lesson == 148)
                {
                    availableLessons.text += "Spring Salad with Asparagus and Radishes CL p. 136 (LC) \n";
                }

                if (lesson == 149)
                {
                    availableLessons.text += "Skillet Roasted Potatos with Lemon and Mint CL p. 137 (HCM) \n";
                }

                if (lesson == 150)
                {
                    availableLessons.text += " Risi e Bisi CL p.140  (HCM) \n";
                }

                if (lesson == 151)
                {
                    availableLessons.text += " Pasta Primavera  CL p.151  (HCM) \n";
                }

                if (lesson == 152)
                {
                    availableLessons.text += " Fresh Peas with Lettuce  CL p.140  (HCM) \n";
                }

                if (lesson == 153)
                {
                    availableLessons.text += " Curried Chicken with Spring Peas  CL p.141  (HCM) \n";
                }

                if (lesson == 154)
                {
                    availableLessons.text += " Tofu with Red Curry Paste Peas and Yellow Tomatoes  CL p.142  (LCM) \n";
                }

                if (lesson == 155)
                {
                    availableLessons.text += " Tofu Triangles with Spciy Onion Sauce  CL p.142 (HCM) \n";
                }

                if (lesson == 156)
                {
                    availableLessons.text += " Creamy Potato and Leek Soup  CL p.142  (HCM) \n";
                }

                if (lesson == 157)
                {
                    availableLessons.text += " Glazed Tofu Sandwhich  CL p.143  (LCM) \n";
                }

                if (lesson == 158)
                {
                    availableLessons.text += " Barbecued Tofu Sandwhich CL p.143  (LCRec) \n";
                }

                if (lesson == 159)
                {
                    availableLessons.text += " Tofu Coleslaw CL p.143 (B) \n";
                }

                if (lesson == 160)
                {
                    availableLessons.text += "  Confetti Pasta with Chicken  CL p.145 (HC) \n";
                }

                if (lesson == 161)
                {
                    availableLessons.text += "  Tangy Lentil Salad  CL p. 146 (HCM) \n";
                }

                if (lesson == 162)
                {
                    availableLessons.text += "  Shrimp Avocado and Farfalle Salad  CL p.146 (lCM) \n";
                }

                if (lesson == 163)
                {
                    availableLessons.text += "  Tomato Panzanella with Provolone and Ham  CL p.146 (HCM) \n";
                }

                if (lesson == 164)
                {
                    availableLessons.text += "  Cajun Catfish Wraps with Slaw  CL p.148 (LCM) \n";
                }

                if (lesson == 165)
                {
                    availableLessons.text += " Ginger-Peanut Chicken Salad Wraps CL p.148 (lCM) \n";
                }

                if (lesson == 166)
                {
                    availableLessons.text += " Blue Cheese Pepper Steak Wraps  CL p. 148 (LCM) \n";
                }

                if (lesson == 167)
                {
                    availableLessons.text += "  Steamed Vegetables with Cantonese Dipping Sauce CL p. 150 (LCM) \n";
                }

                if (lesson == 168)
                {
                    availableLessons.text += "  Steamed Lemon Grass with Shrimp CL p.150 (LC) \n";
                }

                if (lesson == 169)
                {
                    availableLessons.text += "  Steamed Snapper with Tomatoes and Feta CL p. 152 (LCM, HCM) \n";
                }

                if (lesson == 170)
                {
                    availableLessons.text += "  Tomato Pizza with Capers, Basil and Garlic  CL p. (LCM) \n";
                }

                if (lesson == 171)
                {
                    availableLessons.text += "  Mushroom Pizza with Thyme CL p. 152 (LCM) \n";
                }

                if (lesson == 172)
                {
                    availableLessons.text += " Caramalized Onion Pizza with Gorgonzola and Arugula  CL p. 152 (LCM) \n";
                }

                if (lesson == 173)
                {
                    availableLessons.text += "  Pizza with sauteed Radicchio  CL p.152 (LCM) \n";
                }

                if (lesson == 174)
                {
                    availableLessons.text += "  Indian Spiced Roast Salmon  CL p.153 (LC) \n";
                }

                if (lesson == 175)
                {
                    availableLessons.text += " Broiled Salmon over Parmesan Grits  CL p.153 (LCM) \n";
                }

                if (lesson == 176)
                {
                    availableLessons.text += "  Grilled Salmon Salad CL p.154 (HC) \n";
                }

                if (lesson == 177)
                {
                    availableLessons.text += "  Spicy Herb Grilled Salmon Steaks CL p.154 (B) \n";
                }

                if (lesson == 178)
                {
                    availableLessons.text += "  Roast Salmon with Tomatoes and Tarragon CL p.155 (B) \n";
                }

                if (lesson == 179)
                {
                    availableLessons.text += "  Salmon with dill citrus sauce  CL p.155 (HC) \n";
                }

                if (lesson == 180)
                {
                    availableLessons.text += " Avocado Alfredo  nb p.141 (LC) \n";
                }

                if (lesson == 181)
                {
                    availableLessons.text += " Roasted Veggie Bisque  CL p. (LCM) \n";
                }

                if (lesson == 182)
                {
                    availableLessons.text += " Oven Poached Salmon with Vegetables CL p.155 (B) \n";
                }

                if (lesson == 183)
                {
                    availableLessons.text += "  Teriyaki Burgers CL p. 156 (B) \n";
                }

                if (lesson == 184)
                {
                    availableLessons.text += "  Grilled Italian Vegetables with Pasta  CL p.157 (LCM) \n";
                }

                if (lesson == 185)
                {
                    availableLessons.text += " Indonesian Shrimp Sate with Creamy Peanut Butter Sauce  CL p.157 (LCM) \n";
                }

                if (lesson == 186)
                {
                    availableLessons.text += "  Beef and Chicken Fajitas  CL p.157 (LCM) \n";
                }

                if (lesson == 187)
                {
                    availableLessons.text += " Texass Dry Rub Slow Grilled Turkey Breast   CL p. 158 (LCM) \n";
                }

                if (lesson == 188)
                {
                    availableLessons.text += "  Chipotle Marinated Pork Chops with Chimichurri Sauce CL p.159 (LC) \n";
                }

                if (lesson == 189)
                {
                    availableLessons.text += "  Hot and Spicy Asian Rubbed Chicken CL p.159 (B) \n";
                }

                if (lesson == 190)
                {
                    availableLessons.text += "  Sesame Shrimp and Couscous Salad  CL p.161 (LCM) \n";
                }

                if (lesson == 191)
                {
                    availableLessons.text += "  Fresh Mozzarella, tomato and Basil CousCous Salad  CL p.161 (LCM) \n";
                }

                if (lesson == 192)
                {
                    availableLessons.text += "  Vanilla Glazed Pork Chops with Cipollini Onions  CL p.163 (LCM) \n";
                }

                if (lesson == 193)
                {
                    availableLessons.text += "  Barbecued Chicken Quesadillas  CL p.163 (HCRec) \n";
                }

                if (lesson == 194)
                {
                    availableLessons.text += "  Jagershncitzel  CL p.169 (HCM) \n";
                }

                if (lesson == 195)
                {
                    availableLessons.text += "  Linzertorte  CL p.169 (HCM) \n";
                }

                if (lesson == 196)
                {
                    availableLessons.text += "  Marinated Tomatoes and Green Beans  CL p.169 (LC) \n";
                }

                if (lesson == 197)
                {
                    availableLessons.text += "  Viennese Potato Cucumber Salad  CL p.170 (HC) \n";
                }

                if (lesson == 198)
                {
                    availableLessons.text += "  Cool Summer Berry Soup  CL p.172 (HC) \n";
                }

                if (lesson == 199)
                {
                    availableLessons.text += "  Raspberry Champagne Graita  CL p.172 (HCM) \n";
                }

                if (lesson == 200)
                {
                    availableLessons.text += "  Herb Oat Crusted Chicken  CL p.173 (HCM) \n";
                }

                if (lesson == 201)
                {
                    availableLessons.text += "  Garlic Herb Meat Loaf  CL p.174 (HC) \n";
                }

                if (lesson == 202)
                {
                    availableLessons.text += "  Baked Shrimp with Feta Cheese  CL p.175 (LCM) \n";
                }

                if (lesson == 203)
                {
                    availableLessons.text += "  Raosted Eggplant and Onion Pasta  CL p.176 (LCM) \n";
                }

                if (lesson == 204)
                {
                    availableLessons.text += "  Chipotle Black Bean Soup  CL p.176 (LCM) \n";
                }

                if (lesson == 205)
                {
                    availableLessons.text += "  Creamy Asparagus Soup  CL p.176 (LC) \n";
                }

                if (lesson == 206)
                {
                    availableLessons.text += "  Marinated Vegetable Salad  CL p.177 (LC) \n";
                }

                if (lesson == 207)
                {
                    availableLessons.text += "  Open Faced Burgers with Onion Mushroom toppings  CL p.181 (LCM) \n";
                }

                if (lesson == 208)
                {
                    availableLessons.text += " Curried Beef with Potatoes and Peas   CL p.181 (HC) \n";
                }

                if (lesson == 209)
                {
                    availableLessons.text += "  Meatballs and Peppers  CL p.182 (HCM) \n";
                }

                if (lesson == 210)
                {
                    availableLessons.text += "  Quick Chili Con Carne  CL p.182 (HCM) \n";
                }

                if (lesson == 211)
                {
                    availableLessons.text += "  Carribean Styel Beef Soft Tacos  CL p.183 (LCM HCM) \n";
                }

                if (lesson == 212)
                {
                    availableLessons.text += "  Spicy Melon Salad  CL p.184 (HC) \n";
                }

                if (lesson == 213)
                {
                    availableLessons.text += "  Lavendar Lemonade  CL p.186 (B) \n";
                }

                if (lesson == 214)
                {
                    availableLessons.text += "  Lavendar Pineapple Granita  CL p.186 (HCM) \n";
                }

                if (lesson == 215)
                {
                    availableLessons.text += "  Roasted Corn, Black Bean and Mango Salad  CL p.188 (HCM) \n";
                }

                if (lesson == 216)
                {
                    availableLessons.text += "  Corn and Shrimp Tortilla Soup CL p. (HCM) \n";
                }

                if (lesson == 217)
                {
                    availableLessons.text += "  Cumin Spiked Popcorn CL p.189 (HCM) \n";
                }

                if (lesson == 218)
                {
                    availableLessons.text += "  Mussels steamed in White Wine  CL p.190 (LCM) \n";
                }

                if (lesson == 219)
                {
                    availableLessons.text += "  Summer Squash, Carrot, Green Pea Ragout over Polenta  CL p.192 (HCM) \n";
                }

                if (lesson == 220)
                {
                    availableLessons.text += "  CL p. () \n";
                }

                if (lesson == 220)
                {
                    availableLessons.text += "  Bell Pepper and Potato Tagine over CousCous  CL p.193 (HCM) \n";
                }

                if (lesson == 221)
                {
                    availableLessons.text += "  Cosmire Crab Salad with Corn Chips  CL p.198 (LCM) \n";
                }

                if (lesson == 222)
                {
                    availableLessons.text += "  Celestial Chicken, Mint, Cucumebr skewers with spring onion sauce  CL p.198 (LC) \n";
                }

                if (lesson == 223)
                {
                    availableLessons.text += "  Grilled Chicken Salad with Cherries  CL p.206 (HC) \n";
                }

                if (lesson == 224)
                {
                    availableLessons.text += "  Thai Steak with Basil and Mint CL p.207 (B) \n";
                }

                if (lesson == 225)
                {
                    availableLessons.text += "  Indonesian Coriander Honey Chicken  CL p.208 (LC) \n";
                }

                if (lesson == 226)
                {
                    availableLessons.text += " Steamed Bali Style Sea Bass  CL p.208 (LC) \n";
                }

                if (lesson == 227)
                {
                    availableLessons.text += "  Malaysian Lime-Coconut Swordfish  CL p.209 (LC) \n";
                }

                if (lesson == 228)
                {
                    availableLessons.text += "  Chinese BBQ pork tenderloin CL p.209 (LC) \n";
                }

                if (lesson == 229)
                {
                    availableLessons.text += "  Singarpore Spicy Shrimp over spinach  CL p.210 (HCM) \n";
                }

                if (lesson == 230)
                {
                    availableLessons.text += " Chicken Caesar Salad  CL p.210 (LCM) \n";
                }

                if (lesson == 231)
                {
                    availableLessons.text += "  Mediterranean Shrimp Salad  CL p.211 (LCM) \n";
                }

                if (lesson == 232)
                {
                    availableLessons.text += "  Vegetable Panzanella with Tuna  CL p.211 (LCM) \n";
                }

                if (lesson == 233)
                {
                    availableLessons.text += "  Minted Strawberries and Bananas in Cantaloupe Cups  CL p.213 (HC) \n";
                }

                if (lesson == 234)
                {
                    availableLessons.text += "  Sweet and Spciy BBQ Beans  CL p.214 (HCRec) \n";
                }

                if (lesson == 235)
                {
                    availableLessons.text += " Pork Ragout  CL p.215 (HCM) \n";
                }

                if (lesson == 236)
                {
                    availableLessons.text += " Short Sharp Chops  CL p.215 (HCM) \n";
                }

                if (lesson == 237)
                {
                    availableLessons.text += "  Greek Lamb Burgers with Cucumber Sauce  CL p.215 (HC LCM) \n";
                }

                if (lesson == 238)
                {
                    availableLessons.text += "  Chunky Chipotle Chicken Chili  CL p.216 (HC) \n";
                }

                if (lesson == 239)
                {
                    availableLessons.text += "  Gazpacho Shrimp Salad  CL p.218 (LC) \n";
                }

                if (lesson == 240)
                {
                    availableLessons.text += " Lemon-Dill CousCous with Chicken and Vegetables  CL p.218 (HC) \n";
                }

                if (lesson == 241)
                {
                    availableLessons.text += "  Flank Steak with Corn Tomato Relish and Grilled Garlic Bread  CL p.219 (HC) \n";
                }

                if (lesson == 242)
                {
                    availableLessons.text += "  Garden Vegetable Stir Fry with Tofu and Brown Rice  CL p.219 (LCM) \n";
                }

                if (lesson == 243)
                {
                    availableLessons.text += "  Tomato Chutney  CL p.225 (LC) \n";
                }

                if (lesson == 244)
                {
                    availableLessons.text += "  Kale Cabbage Saute  CL p.225 (LC) \n";
                }

                if (lesson == 245)
                {
                    availableLessons.text += "  Fragrant Chicken in Creamy Almond Sauce  CL p.225 (LC) \n";
                }

                if (lesson == 246)
                {
                    availableLessons.text += "  Hearty Kidney Beans and Spinach  CL p.226 (HCM) \n";
                }

                if (lesson == 247)
                {
                    availableLessons.text += "  Spicy Garlic Roasted Potatoes  CL p.226 (HCM) \n";
                }

                if (lesson == 248)
                {
                    availableLessons.text += "  Red Lentil Soup  CL p.226 (HCM) \n";
                }

                if (lesson == 249)
                {
                    availableLessons.text += "  Fresh Cherry Orange Soup CL p.228 (HC) \n";
                }

                if (lesson == 250)
                {
                    availableLessons.text += "   Whole Wheat Spaghetti with Arugula   CL p.229 (HCM) \n";
                }

                if (lesson == 251)
                {
                    availableLessons.text += "  Summer Garden Pasta  CL p.230 (HC) \n";
                }

                if (lesson == 252)
                {
                    availableLessons.text += "   Swiss Chard with Onions CL p.232 (LC) \n";
                }

                if (lesson == 253)
                {
                    availableLessons.text += "   Sesame Asparagus with Garlic CL p.233 (LC) \n";
                }

                if (lesson == 254)
                {
                    availableLessons.text += "  Filet Mignon with Mushroom Wine Sauce  CL p.238 (LCM) \n";
                }

                if (lesson == 255)
                {
                    availableLessons.text += "  Double Vanilla Meringue Cookies  CL p.241 (BM) \n";
                }

                if (lesson == 256)
                {
                    availableLessons.text += "   Chicken Pasta Salad  CL p.243 (HC) \n";
                }

                if (lesson == 257)
                {
                    availableLessons.text += "   Chicken Bruschetta  CL p.243 (LC) \n";
                }

                if (lesson == 258)
                {
                    availableLessons.text += "   Marsala Shrimp  CL p.244 (HCM) \n";
                }

                if (lesson == 259)
                {
                    availableLessons.text += "    Pineapple Brown Sugar Frozen Yogurt  CL p.252 (HC) \n";
                }

                if (lesson == 260)
                {
                    availableLessons.text += "   Eggplant and Portobellow Mushroom Melts   CL p.251 (LCM) \n";
                }

                if (lesson == 261)
                {
                    availableLessons.text += "Watermelon Canteloupe Sorbet CL p.251 (HC) \n";
                }

                if (lesson == 262)
                {
                    availableLessons.text += "Italian Beef Subs CL p.250 (HCM) \n";
                }

                if (lesson == 263)
                {
                    availableLessons.text += "Greek Meatball Pitas CL p.250 (LCM) \n";
                }

                if (lesson == 264)
                {
                    availableLessons.text += "BBQ Pork and Coleslaw Hoagies  CL p.250 (LCM) \n";
                }

                if (lesson == 265)
                {
                    availableLessons.text += "Tuna Melt CL p.249 (LC/HC) \n";
                }

                if (lesson == 266)
                {
                    availableLessons.text += "Tuscan Seared Tuna Sandwhiches  CL p.249 (LCM/HC) \n";
                }

                if (lesson == 267)
                {
                    availableLessons.text += "Pork Chop Suey  CL p.249 (LCM) \n";
                }

                if (lesson == 268)
                {
                    availableLessons.text += "Vichyssoise  CL p.248 (HCM) \n";
                }

                if (lesson == 269)
                {
                    availableLessons.text += "Swiss Steak CL p.247 (LCM) \n";
                }

            } else {
				if (countMisses <= maximumMisses) {
                    missingLessons.text += "Buy " + missing + " to complete recipe " + lesson;

                    if (lesson == 1)
                    {
                        missingLessons.text += "Crispy Potato Skin Wedges Phillips p.6 (HCM)\n";
                    }

                    if (lesson == 2)
                    {
                        missingLessons.text += "French Fries  Phillips p.7 (HCM)\n";
                    }

                    if (lesson == 3)
                    {
                        missingLessons.text += "Potato Croquettes Phillips p.8 (FD) \n";
                    }

                    if (lesson == 4)
                    {
                        missingLessons.text += "Potato Au Gratin  Phillips p.9 (FD)\n";
                    }

                    if (lesson == 5)
                    {
                        missingLessons.text += "Rosemary Russet Potato Potato Chips Phillips p.10 (HCM) \n";
                    }

                    if (lesson == 6)
                    {
                        missingLessons.text += "Roasted Winter Veggies Phillips p. 11 (LC)\n";
                    }

                    if (lesson == 7)
                    {
                        missingLessons.text += "Fried Meatballs in Tomato Sauce Phillips p.12 (HC)\n";
                    }

                    if (lesson == 8)
                    {
                        missingLessons.text += "Bacon Wrapped Shrimp Phillips p.13 (B)\n";
                    }

                    if (lesson == 9)
                    {
                        missingLessons.text += "Cheddar Bacon Croquette Phillips p.14 (FD)\n";
                    }

                    if (lesson == 10)
                    {
                        missingLessons.text += "Crispy Fried Spring Rolls Phillips p. 15 (HCM)\n";
                    }

                    if (lesson == 11)
                    {
                        missingLessons.text += "Crab Croquettes Phillips p.16 (FD)\n";
                    }

                    if (lesson == 12)
                    {
                        missingLessons.text += "FetaTriangles Phillips p.17 (FD)\n";
                    }

                    if (lesson == 13)
                    {
                        missingLessons.text += "Korean BBQ Satay Phillips p.18 (HCM)\n";
                    }

                    if (lesson == 14)
                    {
                        missingLessons.text += "Jerk Chicken Wings Phillips p.19 (LCM)\n";
                    }

                    if (lesson == 15)
                    {
                        missingLessons.text += "Morrocon Meatballs w/ Mint Yogurt Phillips p.20 (FD) \n";
                    }

                    if (lesson == 16)
                    {
                        missingLessons.text += "Pigs in a Blanket Phillips p. 21 (HCRec)\n";
                    }

                    if (lesson == 17)
                    {
                        missingLessons.text += "Stuffed Garlic Mushrooms Phillips p.22 (HCM) \n";
                    }

                    if (lesson == 18)
                    {
                        missingLessons.text += "Chimichurri Steak Phillips p.23 (LC) \n";
                    }

                    if (lesson == 19)
                    {
                        missingLessons.text += "Roasted Heirloom Tomato with Baked Feta Phillips p.24 (LC) \n";
                    }

                    if (lesson == 20)
                    {
                        missingLessons.text += "Portabella Pepperoni Pizza Phillips p.25 (LC)\n";
                    }

                    if (lesson == 21)
                    {
                        missingLessons.text += "Mushroom and Feta Frittata Phillips p.26 (LC)\n";
                    }

                    if (lesson == 22)
                    {
                        missingLessons.text += "Roasted Rack of Lamb with Macadamia Crust Phillips p.23 (LC)\n";
                    }

                    if (lesson == 23)
                    {
                        missingLessons.text += "Salmon with Dill Sauce Phillips p.28 (LC)\n";
                    }

                    if (lesson == 24)
                    {
                        missingLessons.text += "Teriyaki Glazed Halibt Steak Phillips p.29 (HCM)\n";
                    }

                    if (lesson == 25)
                    {
                        missingLessons.text += "Cajun Shrimp Phillips p.23 (LC)\n";
                    }

                    if (lesson == 26)
                    {
                        missingLessons.text += "Cod Fish Nuggets Phillips p.31 (HCM)\n";
                    }

                    if (lesson == 27)
                    {
                        missingLessons.text += "Country Chicken Tenders Phillips p.33 (HCM)\n";
                    }

                    if (lesson == 28)
                    {
                        missingLessons.text += "Grilled Cheese Brioche Phillips p.33 (FD)\n";
                    }

                    if (lesson == 29)
                    {
                        missingLessons.text += "Grilled Cheese Phillips p.33 (FD)\n";
                    }

                    if (lesson == 30)
                    {
                        missingLessons.text += "Mini Cheeseburger Sliders Phillips p.34 (LCM)\n";
                    }

                    if (lesson == 31)
                    {
                        missingLessons.text += "Peanut Butter Marshmellow Fluff Turnovers Phillips p.31 (FD)\n";
                    }

                    if (lesson == 32)
                    {
                        missingLessons.text += "Chocolate Cake Phillips p.37 (FD)\n";
                    }

                    if (lesson == 33)
                    {
                        missingLessons.text += "Apricot BlackBerry Crumble Phillips p.37 (FD) \n";
                    }

                    if (lesson == 34)
                    {
                        missingLessons.text += "Vanilla Souffle Phillips p.38 (FD)\n";
                    }

                    if (lesson == 35)
                    {
                        missingLessons.text += "Roasted Cabbage Rolls CL p.12 (FD)\n";
                    }

                    if (lesson == 36)
                    {
                        missingLessons.text += "Chocolate Espresso Pudding CL p.12\n";
                    }

                    if (lesson == 37)
                    {
                        missingLessons.text += "Confetti Basmati Rice Pilaf with Toasted Flaxeed CL p.14 (FD)\n";
                    }

                    if (lesson == 38)
                    {
                        missingLessons.text += "Confetti Basmat Rice Pilaf with Toasted Flaxeed CL p.14 (FD) \n";
                    }

                    if (lesson == 39)
                    {
                        missingLessons.text += "Confetti Long Grain Rice Pilaf with Toasted Flaxeed CL p.14 (FD) \n";
                    }

                    if (lesson == 40)
                    {
                        missingLessons.text += "Mango Coconut Bread Pudding CL p.14 (FD)\n";
                    }

                    if (lesson == 41)
                    {
                        missingLessons.text += "Garbanzo Stew CL.15 (FD) \n";
                    }

                    if (lesson == 42)
                    {
                        missingLessons.text += "Noodle Salad with Shrimp and Chile Dressing CL p.15 (HCM)\n";
                    }

                    if (lesson == 43)
                    {
                        missingLessons.text += "Hot Beans and Cheese CL p.16 (HCM)\n";
                    }

                    if (lesson == 44)
                    {
                        missingLessons.text += "Indian Egg Roll Stirps CL p.17 (HC) \n";
                    }

                    if (lesson == 45)
                    {
                        missingLessons.text += "Creamy Feta Spinach Dip CL p.16 (LC) \n";
                    }

                    if (lesson == 46)
                    {
                        missingLessons.text += "Cajun Tortilla Chips CL 17 (HCM) \n";
                    }

                    if (lesson == 47)
                    {
                        missingLessons.text += "Spicy Caribbean Black Benas and Rice CL p.18 (HCM)\n";
                    }

                    if (lesson == 48)
                    {
                        missingLessons.text += "Linguine with Red Clam Sauce CL p.19 (HCM)\n";
                    }

                    if (lesson == 49)
                    {
                        missingLessons.text += "Tropical Tofu Smoothie CL p.19 (HCM) \n";
                    }

                    if (lesson == 50)
                    {
                        missingLessons.text += "Deluxe Roast Beef Sandwhich CL p.19 (HC) \n";
                    }

                    if (lesson == 51)
                    {
                        missingLessons.text += "Bueno Breakfast Burrito CL p.22 (LCM) \n";
                    }

                    if (lesson == 52)
                    {
                        missingLessons.text += "Pork and Pear Sauce with Lemon Vodka Sauce CL p.22 (HCM) \n";
                    }

                    if (lesson == 53)
                    {
                        missingLessons.text += "White Bean Soup with Peppers and Bacon  CL p.25 (HCM)\n";
                    }

                    if (lesson == 54)
                    {
                        missingLessons.text += "Tortilla Casserole with Swiss Chard CL p.28 (LCM) \n";
                    }

                    if (lesson == 55)
                    {
                        missingLessons.text += "Scotch Broth CL p.31 (HC) \n";
                    }

                    if (lesson == 56)
                    {
                        missingLessons.text += "Roast Pork with Dried Fruits and Squash CL p.31 (HCM) \n";
                    }

                    if (lesson == 57)
                    {
                        missingLessons.text += "Stir Fried Vegetables and Tofu CL p.35 (LCM) \n";
                    }

                    if (lesson == 58)
                    {
                        missingLessons.text += "Miso Chicken with Brown Rice CL p.35 (LCM) \n";
                    }

                    if (lesson == 59)
                    {
                        missingLessons.text += "Spicy Steak Fries CL p.42 (LCM) \n";
                    }

                    if (lesson == 60)
                    {
                        missingLessons.text += "Baked Triple Bean Pot CL p.43 (HCM) \n";
                    }

                    if (lesson == 61)
                    {
                        missingLessons.text += "Hearty Navy Bean Soup CL p.44 (HC) \n";
                    }

                    if (lesson == 62)
                    {
                        missingLessons.text += "Onion-Smothered Brisket and Veggies CL p.44 (HC) \n";
                    }

                    if (lesson == 63)
                    {
                        missingLessons.text += "BBQ Pork Chops CL p.45 (LCM) \n";
                    }

                    if (lesson == 64)
                    {
                        missingLessons.text += "Lentil Potage with Spinach and Yogurt CL p.47 (HCM) \n";
                    }

                    if (lesson == 65)
                    {
                        missingLessons.text += "Huevos Rancheros CL p.48 (LCM) \n";
                    }

                    if (lesson == 66)
                    {
                        missingLessons.text += "Caldo de Res CL p.48 (LCM) \n";
                    }

                    if (lesson == 67)
                    {
                        missingLessons.text += "Marinated Veggies CL p.48 (HC) \n";
                    }

                    if (lesson == 68)
                    {
                        missingLessons.text += "Chicken Salpicon CL p.49 (LC) \n";
                    }

                    if (lesson == 69)
                    {
                        missingLessons.text += "Green Suaced Chicken Enchiladas CL p.49 (HCM) \n";
                    }

                    //
                    if (lesson == 70)
                    {
                        missingLessons.text += "Salsa Manuela CL p.51 (B) \n";
                    }

                    if (lesson == 71)
                    {
                        missingLessons.text += "Four Alarm Red Salsa CL p.51 (B) \n";
                    }

                    if (lesson == 72)
                    {
                        missingLessons.text += "Green Salsa  CL p.51 (B) \n";
                    }

                    if (lesson == 73)
                    {
                        missingLessons.text += "All Purpose Pizza Dough CL p.52 (HCM) \n";
                    }

                    if (lesson == 74)
                    {
                        missingLessons.text += "Lemon Basil Snapper with Roasted Peppers  CL p.55 (LCM) \n";
                    }

                    if (lesson == 75)
                    {
                        missingLessons.text += "Beef Carbonnade CL p.56 (HCM) \n";
                    }

                    if (lesson == 76)
                    {
                        missingLessons.text += "Broiled Salmon with Sweet and Sour Cucumbers CL p.62 (LCM) \n";
                    }

                    if (lesson == 77)
                    {
                        missingLessons.text += "Smoked Fish Spread CL p.62 (LCM) \n";
                    }

                    if (lesson == 78)
                    {
                        missingLessons.text += "Strawberry Lemon Syrup CL p.64 (HCM) \n";
                    }

                    if (lesson == 79)
                    {
                        missingLessons.text += "Lemony Orzo Salad CL p.56 (LCM) \n";
                    }

                    if (lesson == 80)
                    {
                        missingLessons.text += "Honey Left me in a cruch chicken with linguine p.66 (HCM) \n";
                    }

                    if (lesson == 81)
                    {
                        missingLessons.text += "Veal Mediterranean p.66 (HCM) \n";
                    }

                    if (lesson == 82)
                    {
                        missingLessons.text += "Linguine with Clams and Artichokes in Red Sauce p.67 (HCM) \n";
                    }

                    if (lesson == 83)
                    {
                        missingLessons.text += "Tuscan Chicken Stew p.67 (HCM) \n";
                    }

                    if (lesson == 84)
                    {
                        missingLessons.text += "Curried Chicken CousCous p.68 (LCM) \n";
                    }

                    if (lesson == 85)
                    {
                        missingLessons.text += "Greek Shrimp and Spinach with Penne p.68 (HCM) \n";
                    }

                    if (lesson == 86)
                    {
                        missingLessons.text += "Pork and Pineapple Stir Fry p.69 (HCM) \n";
                    }

                    if (lesson == 87)
                    {
                        missingLessons.text += "Cavatappi with Kale and Fava Beans p.71 (HCM) \n";
                    }

                    if (lesson == 88)
                    {
                        missingLessons.text += "Cavatappi with Kale and Kidney Beans p.71 (HCM) \n";
                    }

                    if (lesson == 89)
                    {
                        missingLessons.text += "Collard Greens with Lima Beans and Smoked Turkey p.71 (HCM) \n";
                    }

                    if (lesson == 90)
                    {
                        missingLessons.text += "Halibut Wrapped in Greens p.72 (LC) \n";
                    }

                    if (lesson == 91)
                    {
                        missingLessons.text += "Creamy Polenta and Saute of Mixed Greens p.72 (LC) \n";
                    }

                    if (lesson == 92)
                    {
                        missingLessons.text += "Pork, Kale and Bok Choy Stir Fry p.72 (HCM) \n";
                    }

                    if (lesson == 93)
                    {
                        missingLessons.text += "Miso Salmon with Asparagus p.74 (LCM) \n";
                    }

                    if (lesson == 94)
                    {
                        missingLessons.text += "Shrimp and Squash Penne p.77 (HCM) \n";
                    }

                    if (lesson == 95)
                    {
                        missingLessons.text += "Shrimp and Asparagus with Ginger Sesame Sauce p.78 (HCM) \n";
                    }

                    if (lesson == 96)
                    {
                        missingLessons.text += "Soft Shrimp Tacos with Tropical Salsa  p.78 (HCM) \n";
                    }

                    if (lesson == 97)
                    {
                        missingLessons.text += "Savory Braised Pork Supper HCM p.79 (HCM) \n";
                    }

                    if (lesson == 98)
                    {
                        missingLessons.text += "Osso Buco p.79 (HCM) \n";
                    }

                    if (lesson == 99)
                    {
                        missingLessons.text += "Tuscan Lamb Shanks p.80 (HCM) \n";
                    }

                    if (lesson == 100)
                    {
                        missingLessons.text += "Beef Bourguignonne HC p.80 (HCM) \n";
                    }

                    if (lesson == 101)
                    {
                        missingLessons.text += "Pasta with Mussels and Monteray Jack LCM p.83 (LCM) \n";
                    }

                    if (lesson == 102)
                    {
                        missingLessons.text += "Caramalized Corn Saute LCM p.84 (LCM) \n";
                    }

                    if (lesson == 103)
                    {
                        missingLessons.text += "Tomato Sauce B p.84 (B) \n";
                    }

                    if (lesson == 104)
                    {
                        missingLessons.text += "Pepper Steak with Port Wine Mushroom Suace HC p.85 (HC) \n";
                    }

                    if (lesson == 105)
                    {
                        missingLessons.text += "Beef Bourguignonne Topped Potatoes p.87 (HCM) \n";
                    }

                    if (lesson == 106)
                    {
                        missingLessons.text += "Chili-Cheese Rice Burritos LCM p.97 (LCM) \n";
                    }

                    if (lesson == 107)
                    {
                        missingLessons.text += "Crispy Sesame Shrimp HC p.97 (HCM) \n";
                    }

                    if (lesson == 108)
                    {
                        missingLessons.text += "Meat Sauce Macaroni HCM p.97 (HCM) \n";
                    }

                    if (lesson == 109)
                    {
                        missingLessons.text += "Spaghetti with Broccoli and Ham lcm p.97 (LCM) \n";
                    }

                    if (lesson == 110)
                    {
                        missingLessons.text += "White Bean salad with Shrimp and Arugala HCM p.98 (HCM) \n";
                    }

                    if (lesson == 111)
                    {
                        missingLessons.text += "Tabbouleh with arugula and Chicken LC p.98 (LC) \n";
                    }

                    if (lesson == 112)
                    {
                        missingLessons.text += "Field Salad with Roasted Leeks, mushrooms and Feta p.97 (LCM) \n";
                    }

                    if (lesson == 113)
                    {
                        missingLessons.text += "Potato Salad with Arugula Pesto, Peas, Zucchini p.97 (HCM) \n";
                    }

                    if (lesson == 114)
                    {
                        missingLessons.text += "Indian Chicken Curry p.97 (HCM) \n";
                    }

                    if (lesson == 115)
                    {
                        missingLessons.text += "Savory Roasted Vegetable Pitas  p.97 (LCM, HCM) \n";
                    }

                    if (lesson == 116)
                    {
                        missingLessons.text += "Grilled Asparagus p.97 (LC) \n";
                    }

                    if (lesson == 117)
                    {
                        missingLessons.text += "Warm Scallop Salad with Lime and Cilantro  p.97 (LCM) \n";
                    }

                    if (lesson == 118)
                    {
                        missingLessons.text += "Suquet of Cod p.97 (HCM) \n";
                    }

                    if (lesson == 119)
                    {
                        missingLessons.text += "Vegetable Donburi over Seasoned Rice p.97 (HCM) \n";
                    }

                    if (lesson == 120)
                    {
                        missingLessons.text += "Cuban Chicken and Plantain Stew  CL p.104 (HCM) \n";
                    }

                    if (lesson == 121)
                    {
                        missingLessons.text += "Spring Pasole CL p.121 (LC) \n";
                    }

                    if (lesson == 122)
                    {
                        missingLessons.text += "Risotto with Asparagus Fennel and Leeks CL p.105 (HCM) \n";
                    }

                    if (lesson == 123)
                    {
                        missingLessons.text += "Chunky Minestrone Primavera with Clams CL p.107 (HCM) \n";
                    }

                    if (lesson == 124)
                    {
                        missingLessons.text += "White Beans hummus Dip  CL p.110 (HC) \n";
                    }

                    if (lesson == 125)
                    {
                        missingLessons.text += "Shrimp with Roasted pepper Horseradish Dip CL p.97 (LC) \n";
                    }

                    if (lesson == 126)
                    {
                        missingLessons.text += "Apricot Stuffed Spice Rubbed Pork Loin CL p.111 (HC) \n";
                    }

                    if (lesson == 127)
                    {
                        missingLessons.text += "Sweet and Hot Onion Salsa CL p.97 (HC) \n";
                    }

                    if (lesson == 128)
                    {
                        missingLessons.text += "Spicy Chicken Breasts with Caramelized Onion Red Pepper Relish CL p. (LC) \n";
                    }

                    if (lesson == 129)
                    {
                        missingLessons.text += "Creole Catfish with Vidalia Olvie Relish CL p.113 (LC) \n";
                    }

                    if (lesson == 130)
                    {
                        missingLessons.text += "Shrimp Creole Potpie HCM CL p.117 (HCM) \n";
                    }

                    if (lesson == 131)
                    {
                        missingLessons.text += "Pepper Slaw CL p. 118 (B) \n";
                    }

                    if (lesson == 132)
                    {
                        missingLessons.text += "White Gazpacho CL p.119 (B) \n";
                    }

                    if (lesson == 133)
                    {
                        missingLessons.text += "Darcy's Veggie Chili CL p.119 (HCM) \n";
                    }

                    if (lesson == 134)
                    {
                        missingLessons.text += "Mary's Salsa CL p.119 (B) \n";
                    }

                    if (lesson == 135)
                    {
                        missingLessons.text += "Traditional Spanish Paella  CL p. 121 (HCM) \n";
                    }

                    if (lesson == 136)
                    {
                        availableLessons.text += "Spicy Paella with Chile, Lime and cilantro  CL p. 136 (HCM) \n";
                    }

                    if (lesson == 137)
                    {
                        missingLessons.text += "Seafood Paella  CL p. 122 (HCM) \n";
                    }

                    if (lesson == 138)
                    {
                        availableLessons.text += "Pad Thai CL p.123 (HCM) \n";
                    }

                    if (lesson == 139)
                    {
                        missingLessons.text += "Shrimp and Broccoli in Chili Sauce CL p.123 (HCM) \n";
                    }

                    if (lesson == 140)
                    {
                        missingLessons.text += "Chicken Cashew CL p. 124 (HCM) \n";
                    }

                    if (lesson == 141)
                    {
                        missingLessons.text += "Asian Vegetable Stir Fry CL p.125 (HCM) \n";
                    }

                    if (lesson == 142)
                    {
                        missingLessons.text += "Fried Rice with Smoked Ham CL p.142 (HC) \n";
                    }

                    if (lesson == 143)
                    {
                        missingLessons.text += "Creamy Caesar Salad with Spicy Croutons CL p.128 (LCM) \n";
                    }

                    if (lesson == 144)
                    {
                        missingLessons.text += "Super Duper Sunrise Shake CL p. 133 (HC) \n";
                    }

                    if (lesson == 145)
                    {
                        missingLessons.text += "Pan Seared Cod over Vegetable Ragout CL p. 135 (LCM) \n";
                    }

                    if (lesson == 146)
                    {
                        missingLessons.text += "Fresh Fruit Compote with Orange Lime Drizze CL p. 135 (HC) \n";
                    }

                    if (lesson == 147)
                    {
                        missingLessons.text += "Chicken with Mushrooms and Leeks CL p. 136 (HCM) \n";
                    }

                    if (lesson == 148)
                    {
                        missingLessons.text += "Spring Salad with Asparagus and Radishes CL p. 136 (LC) \n";
                    }

                    if (lesson == 149)
                    {
                        missingLessons.text += "Skillet Roasted Potatos with Lemon and Mint CL p. 137 (HCM) \n";
                    }

                    if (lesson == 150)
                    {
                        missingLessons.text += " Risi e Bisi CL p.140  (HCM) \n";
                    }

                    if (lesson == 151)
                    {
                        missingLessons.text += " Pasta Primavera  CL p.151  (HCM) \n";
                    }

                    if (lesson == 152)
                    {
                        missingLessons.text += " Fresh Peas with Lettuce  CL p.140  (HCM) \n";
                    }

                    if (lesson == 153)
                    {
                        missingLessons.text += " Curried Chicken with Spring Peas  CL p.141  (HCM) \n";
                    }

                    if (lesson == 154)
                    {
                        missingLessons.text += " Tofu with Red Curry Paste Peas and Yellow Tomatoes  CL p.142  (LCM) \n";
                    }

                    if (lesson == 155)
                    {
                        missingLessons.text += " Tofu Triangles with Spciy Onion Sauce  CL p.142 (HCM) \n";
                    }

                    if (lesson == 156)
                    {
                        missingLessons.text += " Creamy Potato and Leek Soup  CL p.142  (HCM) \n";
                    }

                    if (lesson == 157)
                    {
                        missingLessons.text += " Glazed Tofu Sandwhich  CL p.143  (LCM) \n";
                    }

                    if (lesson == 158)
                    {
                        missingLessons.text += " Barbecued Tofu Sandwhich CL p.143  (LCRec) \n";
                    }

                    if (lesson == 159)
                    {
                        missingLessons.text += " Tofu Coleslaw CL p.143 (B) \n";
                    }

                    if (lesson == 160)
                    {
                        missingLessons.text += "  Confetti Pasta with Chicken  CL p.145 (HC) \n";
                    }

                    if (lesson == 161)
                    {
                        missingLessons.text += "  Tangy Lentil Salad  CL p. 146 (HCM) \n";
                    }

                    if (lesson == 162)
                    {
                        missingLessons.text += "  Shrimp Avocado and Farfalle Salad  CL p.146 (lCM) \n";
                    }

                    if (lesson == 163)
                    {
                        missingLessons.text += "  Tomato Panzanella with Provolone and Ham  CL p.146 (HCM) \n";
                    }

                    if (lesson == 164)
                    {
                        missingLessons.text += "  Cajun Catfish Wraps with Slaw  CL p.148 (LCM) \n";
                    }

                    if (lesson == 165)
                    {
                        missingLessons.text += " Ginger-Peanut Chicken Salad Wraps CL p.148 (lCM) \n";
                    }

                    if (lesson == 166)
                    {
                        missingLessons.text += " Blue Cheese Pepper Steak Wraps  CL p. 148 (LCM) \n";
                    }

                    if (lesson == 167)
                    {
                        missingLessons.text += "  Steamed Vegetables with Cantonese Dipping Sauce CL p. 150 (LCM) \n";
                    }

                    if (lesson == 168)
                    {
                        missingLessons.text += "  Steamed Lemon Grass with Shrimp CL p.150 (LC) \n";
                    }

                    if (lesson == 169)
                    {
                        missingLessons.text += "  Steamed Snapper with Tomatoes and Feta CL p. 152 (LCM, HCM) \n";
                    }

                    if (lesson == 170)
                    {
                        missingLessons.text += "  Tomato Pizza with Capers, Basil and Garlic  CL p. (LCM) \n";
                    }

                    if (lesson == 171)
                    {
                        missingLessons.text += "  Mushroom Pizza with Thyme CL p. 152 (LCM) \n";
                    }

                    if (lesson == 172)
                    {
                        missingLessons.text += " Caramalized Onion Pizza with Gorgonzola and Arugula  CL p. 152 (LCM) \n";
                    }

                    if (lesson == 173)
                    {
                        missingLessons.text += "  Pizza with sauteed Radicchio  CL p.152 (LCM) \n";
                    }

                    if (lesson == 174)
                    {
                        missingLessons.text += "  Indian Spiced Roast Salmon  CL p.153 (LC) \n";
                    }

                    if (lesson == 175)
                    {
                        missingLessons.text += " Broiled Salmon over Parmesan Grits  CL p.153 (LCM) \n";
                    }

                    if (lesson == 176)
                    {
                        missingLessons.text += "  Grilled Salmon Salad CL p.154 (HC) \n";
                    }

                    if (lesson == 177)
                    {
                        missingLessons.text += "  Spicy Herb Grilled Salmon Steaks CL p.154 (B) \n";
                    }

                    if (lesson == 178)
                    {
                        missingLessons.text += "  Roast Salmon with Tomatoes and Tarragon CL p.155 (B) \n";
                    }

                    if (lesson == 179)
                    {
                        missingLessons.text += "  Salmon with dill citrus sauce  CL p.155 (HC) \n";
                    }

                    if (lesson == 180)
                    {
                        missingLessons.text += " Avocado Alfredo  nb p.141 (LC) \n";
                    }

                    if (lesson == 181)
                    {
                        missingLessons.text += " Roasted Veggie Bisque  CL p. (LCM) \n";
                    }

                    if (lesson == 182)
                    {
                        missingLessons.text += " Oven Poached Salmon with Vegetables CL p.155 (B) \n";
                    }

                    if (lesson == 183)
                    {
                        missingLessons.text += "  Teriyaki Burgers CL p. 156 (B) \n";
                    }

                    if (lesson == 184)
                    {
                        missingLessons.text += "  Grilled Italian Vegetables with Pasta  CL p.157 (LCM) \n";
                    }

                    if (lesson == 185)
                    {
                        missingLessons.text += " Indonesian Shrimp Sate with Creamy Peanut Butter Sauce  CL p.157 (LCM) \n";
                    }

                    if (lesson == 186)
                    {
                        missingLessons.text += "  Beef and Chicken Fajitas  CL p.157 (LCM) \n";
                    }

                    if (lesson == 187)
                    {
                        missingLessons.text += " Texass Dry Rub Slow Grilled Turkey Breast   CL p. 158 (LCM) \n";
                    }

                    if (lesson == 188)
                    {
                        missingLessons.text += "  Chipotle Marinated Pork Chops with Chimichurri Sauce CL p.159 (LC) \n";
                    }

                    if (lesson == 189)
                    {
                        missingLessons.text += "  Hot and Spicy Asian Rubbed Chicken CL p.159 (B) \n";
                    }

                    if (lesson == 190)
                    {
                        missingLessons.text += "  Sesame Shrimp and Couscous Salad  CL p.161 (LCM) \n";
                    }

                    if (lesson == 191)
                    {
                        missingLessons.text += "  Fresh Mozzarella, tomato and Basil CousCous Salad  CL p.161 (LCM) \n";
                    }

                    if (lesson == 192)
                    {
                        missingLessons.text += "  Vanilla Glazed Pork Chops with Cipollini Onions  CL p.163 (LCM) \n";
                    }

                    if (lesson == 193)
                    {
                        missingLessons.text += "  Barbecued Chicken Quesadillas  CL p.163 (HCRec) \n";
                    }

                    if (lesson == 194)
                    {
                        missingLessons.text += "  Jagershncitzel  CL p.169 (HCM) \n";
                    }

                    if (lesson == 195)
                    {
                        missingLessons.text += "  Linzertorte  CL p.169 (HCM) \n";
                    }

                    if (lesson == 196)
                    {
                        missingLessons.text += "  Marinated Tomatoes and Green Beans  CL p.169 (LC) \n";
                    }

                    if (lesson == 197)
                    {
                        missingLessons.text += "  Viennese Potato Cucumber Salad  CL p.170 (HC) \n";
                    }

                    if (lesson == 198)
                    {
                        missingLessons.text += "  Cool Summer Berry Soup  CL p.172 (HC) \n";
                    }

                    if (lesson == 199)
                    {
                        missingLessons.text += "  Raspberry Champagne Graita  CL p.172 (HCM) \n";
                    }

                    if (lesson == 200)
                    {
                        missingLessons.text += "  Herb Oat Crusted Chicken  CL p.173 (HCM) \n";
                    }

                    if (lesson == 201)
                    {
                        missingLessons.text += "  Garlic Herb Meat Loaf  CL p.174 (HC) \n";
                    }

                    if (lesson == 202)
                    {
                        missingLessons.text += "  Baked Shrimp with Feta Cheese  CL p.175 (LCM) \n";
                    }

                    if (lesson == 203)
                    {
                        missingLessons.text += "  Raosted Eggplant and Onion Pasta  CL p.176 (LCM) \n";
                    }

                    if (lesson == 204)
                    {
                        missingLessons.text += "  Chipotle Black Bean Soup  CL p.176 (LCM) \n";
                    }

                    if (lesson == 205)
                    {
                        missingLessons.text += "  Creamy Asparagus Soup  CL p.176 (LC) \n";
                    }

                    if (lesson == 206)
                    {
                        missingLessons.text += "  Marinated Vegetable Salad  CL p.177 (LC) \n";
                    }

                    if (lesson == 207)
                    {
                        missingLessons.text += "  Open Faced Burgers with Onion Mushroom toppings  CL p.181 (LCM) \n";
                    }

                    if (lesson == 208)
                    {
                        missingLessons.text += " Curried Beef with Potatoes and Peas   CL p.181 (HC) \n";
                    }

                    if (lesson == 209)
                    {
                        missingLessons.text += "  Meatballs and Peppers  CL p.182 (HCM) \n";
                    }

                    if (lesson == 210)
                    {
                        missingLessons.text += "  Quick Chili Con Carne  CL p.182 (HCM) \n";
                    }

                    if (lesson == 211)
                    {
                        missingLessons.text += "  Carribean Styel Beef Soft Tacos  CL p.183 (LCM HCM) \n";
                    }

                    if (lesson == 212)
                    {
                        missingLessons.text += "  Spicy Melon Salad  CL p.184 (HC) \n";
                    }

                    if (lesson == 213)
                    {
                        missingLessons.text += "  Lavendar Lemonade  CL p.186 (B) \n";
                    }

                    if (lesson == 214)
                    {
                        missingLessons.text += "  Lavendar Pineapple Granita  CL p.186 (HCM) \n";
                    }

                    if (lesson == 215)
                    {
                        missingLessons.text += "  Roasted Corn, Black Bean and Mango Salad  CL p.188 (HCM) \n";
                    }

                    if (lesson == 216)
                    {
                        missingLessons.text += "  Corn and Shrimp Tortilla Soup CL p. (HCM) \n";
                    }

                    if (lesson == 217)
                    {
                        missingLessons.text += "  Cumin Spiked Popcorn CL p.189 (HCM) \n";
                    }

                    if (lesson == 218)
                    {
                        missingLessons.text += "  Mussels steamed in White Wine  CL p.190 (LCM) \n";
                    }

                    if (lesson == 219)
                    {
                        missingLessons.text += "  Summer Squash, Carrot, Green Pea Ragout over Polenta  CL p.192 (HCM) \n";
                    }

                    if (lesson == 220)
                    {
                        missingLessons.text += "  Bell Pepper and Potato Tagine over CousCous  CL p.193 (HCM) \n";
                    }

                    if (lesson == 221)
                    {
                        missingLessons.text += "  Cosmire Crab Salad with Corn Chips  CL p.198 (LCM) \n";
                    }

                    if (lesson == 222)
                    {
                        missingLessons.text += "  Celestial Chicken, Mint, Cucumebr skewers with spring onion sauce  CL p.198 (LC) \n";
                    }

                    if (lesson == 223)
                    {
                        missingLessons.text += "  Grilled Chicken Salad with Cherries  CL p.206 (HC) \n";
                    }

                    if (lesson == 224)
                    {
                        missingLessons.text += "  Thai Steak with Basil and Mint CL p.207 (B) \n";
                    }

                    if (lesson == 225)
                    {
                        missingLessons.text += "  Indonesian Coriander Honey Chicken  CL p.208 (LC) \n";
                    }

                    if (lesson == 226)
                    {
                        missingLessons.text += " Steamed Bali Style Sea Bass  CL p.208 (LC) \n";
                    }

                    if (lesson == 227)
                    {
                        missingLessons.text += "  Malaysian Lime-Coconut Swordfish  CL p.209 (LC) \n";
                    }

                    if (lesson == 228)
                    {
                        missingLessons.text += "  Chinese BBQ pork tenderloin CL p.209 (LC) \n";
                    }

                    if (lesson == 229)
                    {
                        missingLessons.text += "  Singarpore Spicy Shrimp over spinach  CL p.210 (HCM) \n";
                    }

                    if (lesson == 230)
                    {
                        missingLessons.text += " Chicken Caesar Salad  CL p.210 (LCM) \n";
                    }

                    if (lesson == 231)
                    {
                        missingLessons.text += "  Mediterranean Shrimp Salad  CL p.211 (LCM) \n";
                    }

                    if (lesson == 232)
                    {
                        missingLessons.text += "  Vegetable Panzanella with Tuna  CL p.211 (LCM) \n";
                    }

                    if (lesson == 233)
                    {
                        missingLessons.text += "  Minted Strawberries and Bananas in Cantaloupe Cups  CL p.213 (HC) \n";
                    }

                    if (lesson == 234)
                    {
                        missingLessons.text += "  Sweet and Spciy BBQ Beans  CL p.214 (HCRec) \n";
                    }

                    if (lesson == 235)
                    {
                        missingLessons.text += " Pork Ragout  CL p.215 (HCM) \n";
                    }

                    if (lesson == 236)
                    {
                        missingLessons.text += " Short Sharp Chops  CL p.215 (HCM) \n";
                    }

                    if (lesson == 237)
                    {
                        missingLessons.text += "  Greek Lamb Burgers with Cucumber Sauce  CL p.215 (HC LCM) \n";
                    }

                    if (lesson == 238)
                    {
                        missingLessons.text += "  Chunky Chipotle Chicken Chili  CL p.216 (HC) \n";
                    }

                    if (lesson == 239)
                    {
                        missingLessons.text += "  Gazpacho Shrimp Salad  CL p.218 (LC) \n";
                    }

                    if (lesson == 240)
                    {
                        missingLessons.text += " Lemon-Dill CousCous with Chicken and Vegetables  CL p.218 (HC) \n";
                    }

                    if (lesson == 241)
                    {
                        missingLessons.text += "  Flank Steak with Corn Tomato Relish and Grilled Garlic Bread  CL p.219 (HC) \n";
                    }

                    if (lesson == 242)
                    {
                        missingLessons.text += "  Garden Vegetable Stir Fry with Tofu and Brown Rice  CL p.219 (LCM) \n";
                    }

                    if (lesson == 243)
                    {
                        missingLessons.text += "  Tomato Chutney  CL p.225 (LC) \n";
                    }

                    if (lesson == 244)
                    {
                        missingLessons.text += "  Kale Cabbage Saute  CL p.225 (LC) \n";
                    }

                    if (lesson == 245)
                    {
                        missingLessons.text += "  Fragrant Chicken in Creamy Almond Sauce  CL p.225 (LC) \n";
                    }

                    if (lesson == 246)
                    {
                        missingLessons.text += "  Hearty Kidney Beans and Spinach  CL p.226 (HCM) \n";
                    }

                    if (lesson == 247)
                    {
                        missingLessons.text += "  Spicy Garlic Roasted Potatoes  CL p.226 (HCM) \n";
                    }

                    if (lesson == 248)
                    {
                        missingLessons.text += "  Red Lentil Soup  CL p.226 (HCM) \n";
                    }

                    if (lesson == 249)
                    {
                        missingLessons.text += "  Fresh Cherry Orange Soup CL p.228 (HC) \n";
                    }

                    if (lesson == 250)
                    {
                        missingLessons.text += "   Whole Wheat Spaghetti with Arugula   CL p.229 (HCM) \n";
                    }

                    if (lesson == 251)
                    {
                        missingLessons.text += "  Summer Garden Pasta  CL p.230 (HC) \n";
                    }

                    if (lesson == 252)
                    {
                        missingLessons.text += "   Swiss Chard with Onions CL p.232 (LC) \n";
                    }

                    if (lesson == 253)
                    {
                        missingLessons.text += "   Sesame Asparagus with Garlic CL p.233 (LC) \n";
                    }

                    if (lesson == 254)
                    {
                        missingLessons.text += "  Filet Mignon with Mushroom Wine Sauce  CL p.238 (LCM) \n";
                    }

                    if (lesson == 255)
                    {
                        missingLessons.text += "  Double Vanilla Meringue Cookies  CL p.241 (BM) \n";
                    }

                    if (lesson == 256)
                    {
                        missingLessons.text += "   Chicken Pasta Salad  CL p.243 (HC) \n";
                    }

                    if (lesson == 257)
                    {
                        missingLessons.text += "   Chicken Bruschetta  CL p.243 (LC) \n";
                    }

                    if (lesson == 258)
                    {
                        missingLessons.text += "   Marsala Shrimp  CL p.244 (HCM) \n";
                    }

                    if (lesson == 259)
                    {
                        missingLessons.text += "    Pineapple Brown Sugar Frozen Yogurt  CL p.252 (HC) \n";
                    }

                    if (lesson == 260)
                    {
                        missingLessons.text += "   Eggplant and Portobellow Mushroom Melts   CL p.251 (LCM) \n";
                    }

                    if (lesson == 261)
                    {
                        missingLessons.text += "Watermelon Canteloupe Sorbet CL p.251 (HC) \n";
                    }

                    if (lesson == 262)
                    {
                        missingLessons.text += "Italian Beef Subs CL p.250 (HCM) \n";
                    }

                    if (lesson == 263)
                    {
                        missingLessons.text += "Greek Meatball Pitas CL p.250 (LCM) \n";
                    }

                    if (lesson == 264)
                    {
                        missingLessons.text += "BBQ Pork and Coleslaw Hoagies  CL p.250 (LCM) \n";
                    }

                    if (lesson == 265)
                    {
                        missingLessons.text += "Tuna Melt CL p.249 (LC/HC) \n";
                    }

                    if (lesson == 266)
                    {
                        missingLessons.text += "Tuscan Seared Tuna Sandwhiches  CL p.249 (LCM/HC) \n";
                    }

                    if (lesson == 267)
                    {
                        missingLessons.text += "Pork Chop Suey  CL p.249 (LCM) \n";
                    }

                    if (lesson == 268)
                    {
                        missingLessons.text += "Vichyssoise  CL p.248 (HCM) \n";
                    }

                    if (lesson == 269)
                    {
                        missingLessons.text += "Swiss Steak CL p.247 (LCM) \n";
                    }

                }//here

                numMissingLessons++;

			}
		}

		var textSize = missingLessons.GetComponent<RectTransform> ();
		var parentSize = missingLessons.transform.parent.GetComponent<RectTransform> ();
		parentSize.offsetMax = new Vector2(parentSize.offsetMax.x, numMissingLessons * 20);

	}

}