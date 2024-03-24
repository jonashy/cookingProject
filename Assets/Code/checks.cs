using UnityEngine;
using System.Collections;

public class checks : MonoBehaviour 

{
//add foods and their bools here

	public bool breadBool;
	public bool cheeseBool;
	public bool lettuceBool;
	public bool meatBool;

	public string bread;
	public string cheese;
	public string lettuce;
	public string meat;

	void Update () {}

	public void breadButton () 
	{
		breadBool = !breadBool;
		if (breadBool) 
		{
			bread = "bread";
		}

		if (!breadBool) 
		{
			bread = "";
		}
	}

	public void meatButton () 
	{
		meatBool = !meatBool;
		if (meatBool) 
		{
			meat = "meat";
		}

		if (!meatBool) 
		{
			meat = "";
		}

	}

	public void cheeseButton () 
	{
		cheeseBool = !cheeseBool;
		if (cheeseBool) 
		{
			cheese = "cheese";
		}

		if (!cheeseBool) 
		{
			cheese = "";
		}

	}

	public void lettuceButton () 
	{
		lettuceBool = !lettuceBool;
		if (lettuceBool) 
		{
			lettuce = "bread";
		}

		if (!lettuceBool) 
		{
			lettuce = "";
		}

	}
}
