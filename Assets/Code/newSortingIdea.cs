using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class newSortingIdea {

	public Text checklist1Text;

	public static string Process(string wearing, string items) 
	{
		var wordsNotFound = new List<string> ();
		var wordsToCheck = items.Split(' ');
		foreach (var cw in wordsToCheck) {
			var ncw = cw.Replace(",","");
			// ignore and
			if (ncw == "and")
				continue;

			// check if word to check is in the clothes list
			if (wearing.IndexOf (ncw) < 0) {
				wordsNotFound.Add (ncw);
			}
		}

		var result = "";
		if (wordsNotFound.Count > 0) {
			for(var i = 0; i < wordsNotFound.Count; i++) {
				var w = wordsNotFound [i];
				result += w;
				if (i < wordsNotFound.Count - 2) {
					result += ", ";
				} else if(i < wordsNotFound.Count - 1) {
					result += " and ";
				}
			}
		}

		return result;

	}
}


