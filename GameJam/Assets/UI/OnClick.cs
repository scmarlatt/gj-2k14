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

//		if(hover) {
//			Vector2 pos = transform.position;
//			Debug.Log (gameObject.name);
//
//			GUI.Box (new Rect (pos.x, (Screen.height - pos.y)-50, 100, 50), "Here is a box");
//
//		}

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

		GUILayout.BeginArea (new Rect (800, 400, 200, 200));
		if(GUILayout.Button(new GUIContent ("Done", "Go Onwards"))) {

		}
		GUILayout.EndArea ();

		GUI.Label (new Rect (Event.current.mousePosition.x + 20, Event.current.mousePosition.y, 200, 80), GUI.tooltip);

	}

	void process (Type val, Upgrade part) {
		if(val == Type.Water) {
			TextMesh display = WMoney.GetComponent<TextMesh> ();
			int level = int.Parse (display.text);
			if(part == Upgrade.Damage) {
				level -= WDamage;
				WDamage = WDamage * 2;
				Debug.Log (WDamage);
			}
			if(part == Upgrade.Range) {
				level -= WRange;
				WRange = WRange * 2;
			}
			if(part == Upgrade.Special) {
				level -= WSpecial;
				WSpecial = WSpecial * 2;
			}
			display.text = level.ToString ();
		}
		if(val == Type.Lightning) {
			TextMesh display = LMoney.GetComponent<TextMesh> ();
			int level = int.Parse (display.text);
			if(part == Upgrade.Damage) {
				level -= LDamage;
				LDamage = LDamage * 2;
			}
			if(part == Upgrade.Range) {
				level -= LRange;
				LRange = LRange * 2;
			}
			if(part == Upgrade.Special) {
				level -= LSpecial;
				LSpecial = LSpecial * 2;
			}
			display.text = level.ToString ();
		}
		if(val == Type.Earth) {
			TextMesh display = EMoney.GetComponent<TextMesh> ();
			int level = int.Parse (display.text);
			if(part == Upgrade.Damage) {
				level -= EDamage;
				EDamage = EDamage * 2;
			}
			if(part == Upgrade.Range) {
				level -= ERange;
				ERange = ERange * 2;
			}
			if(part == Upgrade.Special) {
				level -= ESpecial;
				ESpecial = ESpecial * 2;
			}
			display.text = level.ToString ();
		}
	}
}
