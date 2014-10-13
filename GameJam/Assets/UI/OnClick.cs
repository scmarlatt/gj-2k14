using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	public enum Type {Water, Lightning, Earth};
	public enum Upgrade {Damage, Range, Special};

	public GameObject WMoney;
	public GameObject LMoney;
	public GameObject EMoney;
	
	int WDamage = 1;
	int WRange = 1;
	int WSpecial = 1;

	int LDamage = 1;
	int LRange = 1;
	int LSpecial = 1;

	int EDamage = 1;
	int ERange = 1;
	int ESpecial = 1;

//	bool hover = false;
//	Rect pos;

//	void OnMouseUpAsButton () {
//		TextMesh display = counter.GetComponent<TextMesh> ();
//		int level = int.Parse (display.text) + 1;
//		display.text = level.ToString ();
//	}

//	void OnMouseOver () {
//		hover = true;
//
//	}
//
//	void OnMouseExit () {
//		hover = false;
//	}

	void OnGUI () {

		//Water GUI
		GUILayout.BeginArea (new Rect (120, 100, 200, 200));
		if(GUILayout.Button(new GUIContent ("Damage", "Increase Water Damage \r\nPr: " + WDamage))) {
			process(Type.Water, Upgrade.Damage);
		}
		if(GUILayout.Button(new GUIContent ("Range", "Increase Water Range \r\nPr: " + WRange))) {
			process(Type.Water, Upgrade.Range);
		}
		if(GUILayout.Button(new GUIContent ("Slow", "Increase Water Slow \r\nPr: " + WSpecial))) {
			process(Type.Water, Upgrade.Special);
		}
		GUILayout.EndArea ();

		//Lightning GUI
		GUILayout.BeginArea (new Rect (430, 100, 200, 200));
		if(GUILayout.Button(new GUIContent ("Damage", "Increase Lightning Damage \r\nPr: " + LDamage))) {
			process(Type.Lightning, Upgrade.Damage);
		}
		if(GUILayout.Button(new GUIContent ("Range", "Increase Lightning Range \r\nPr: " + LRange))) {
			process(Type.Lightning, Upgrade.Range);
		}
		if(GUILayout.Button(new GUIContent ("DoT", "Increase Lightning Damage Over Time \r\nPr: " + LSpecial))) {
			process(Type.Lightning, Upgrade.Special);
		}
		GUILayout.EndArea ();

		//Earth GUI
		GUILayout.BeginArea (new Rect (750, 100, 200, 200));
		if(GUILayout.Button(new GUIContent ("Damage", "Increase Earth Damage \r\nPr: " + EDamage))) {
			process(Type.Earth, Upgrade.Damage);
		}
		if(GUILayout.Button(new GUIContent ("Range", "Increase Earth Range \r\nPr: " + ERange))) {
			process(Type.Earth, Upgrade.Range);
		}
		if(GUILayout.Button(new GUIContent ("AoE", "Increase Earth Area of Effect \r\nPr: " + ESpecial))) {
			process(Type.Earth, Upgrade.Special);
		}
		GUILayout.EndArea ();

		//Done GUI
		GUILayout.BeginArea (new Rect (800, 400, 200, 200));
		if(GUILayout.Button(new GUIContent ("Done", "Go Onwards"))) {

		}
		GUILayout.EndArea ();

		GUI.Label (new Rect (Event.current.mousePosition.x + 20, Event.current.mousePosition.y, 200, 80), GUI.tooltip);

	}

	//Resource Transaction Logic
	void process (Type val, Upgrade part) {
		if(val == Type.Water) {
			TextMesh display = WMoney.GetComponent<TextMesh> ();
			int level = int.Parse (display.text);
			if(part == Upgrade.Damage && (level >= WDamage)) {
				level -= WDamage;
				WDamage = WDamage * 2;
			} else if(part == Upgrade.Range && (level >= WRange)) {
				level -= WRange;
				WRange = WRange * 2;
			} else if(part == Upgrade.Special && (level >= WSpecial)) {
				level -= WSpecial;
				WSpecial = WSpecial * 2;
			} else {
				StartCoroutine(ShowError());
			}
			display.text = level.ToString ();
		}
		if(val == Type.Lightning) {
			TextMesh display = LMoney.GetComponent<TextMesh> ();
			int level = int.Parse (display.text);
			if(part == Upgrade.Damage && (level >= LDamage)) {
				level -= LDamage;
				LDamage = LDamage * 2;
			} else if(part == Upgrade.Range && (level >= LRange)) {
				level -= LRange;
				LRange = LRange * 2;
			} else if(part == Upgrade.Special && (level >= LSpecial)) {
				level -= LSpecial;
				LSpecial = LSpecial * 2;
			} else {
				StartCoroutine(ShowError());
			}
			display.text = level.ToString ();
		}
		if(val == Type.Earth) {
			TextMesh display = EMoney.GetComponent<TextMesh> ();
			int level = int.Parse (display.text);
			if(part == Upgrade.Damage && (level >= EDamage)) {
				level -= EDamage;
				EDamage = EDamage * 2;
			} else if(part == Upgrade.Range && (level >= ERange)) {
				level -= ERange;
				ERange = ERange * 2;
			} else if(part == Upgrade.Special && (level >= ESpecial)) {
				level -= ESpecial;
				ESpecial = ESpecial * 2;
			} else {
				StartCoroutine(ShowError());
			}
			display.text = level.ToString ();
		}
	}

	//Error Pop Up
	IEnumerator ShowError () {
		string message = "Not enough resource.";
		float delay = 2f;
		GameObject display = new GameObject ("GUIText");
		display.AddComponent (typeof(GUIText));
		display.guiText.text = message;
		display.guiText.fontSize = 18;
		display.guiText.alignment = TextAlignment.Center;
		display.guiText.anchor = TextAnchor.UpperCenter;
		Vector3 temp = new Vector3(0.5f, 0.5f, 0.1f);
		display.transform.position = temp;
		yield return new WaitForSeconds(delay);
		Destroy (display);
	}
}
