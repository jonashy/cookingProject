using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class colorChange : MonoBehaviour {

	public bool breadChecker;
	public bool cheeseChecker;
	public bool lettuceChecker;
	public bool meatChecker;


	public GameObject checkObject;

	public Button bread;
	public Button cheese;
	public Button lettuce;
	public Button meat;

	void Start () {}
	
	void Update () 
	{
		breadChecker = checkObject.GetComponent<checks> ().breadBool;
		cheeseChecker = checkObject.GetComponent<checks> ().cheeseBool;
		lettuceChecker = checkObject.GetComponent<checks> ().lettuceBool;
		meatChecker = checkObject.GetComponent<checks> ().meatBool;

		if (breadChecker) 
		{
			bread.GetComponent<Image> ().color = Color.cyan;
		}

		if (!breadChecker) 
		{
			bread.GetComponent<Image> ().color = Color.white;
		}

		if (cheeseChecker) 
		{
			cheese.GetComponent<Image> ().color = Color.cyan;
		}

		if (!cheeseChecker) 
		{
			cheese.GetComponent<Image> ().color = Color.white;
		}

		if (lettuceChecker) 
		{
			lettuce.GetComponent<Image> ().color = Color.cyan;
		}

		if (!lettuceChecker) 
		{
			lettuce.GetComponent<Image> ().color = Color.white;
		}

		if (meatChecker) 
		{
			meat.GetComponent<Image> ().color = Color.cyan;
		}

		if (!meatChecker) 
		{
			meat.GetComponent<Image> ().color = Color.white;
		}
	}
}
