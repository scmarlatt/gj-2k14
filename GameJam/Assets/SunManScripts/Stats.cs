using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	static public Stats ps;

	//GAME FLOW
	public int dayNumber = 0;
	public int numDayRunsRemaining = 3;

	//PLAYER
	public float health = 100;
	public float mana = 60f;
	public float manaRegen = 5.0f;
	public float armor = 0.0f;
	public int ltResource = 0;
	public int wtResource = 0;
	public int etResource = 0;
	public int ltPow = 0;
	public int ltRange = 0;
	public int ltSpec = 0;
	public int wtPow = 0;
	public int wtRange = 0;
	public int wtSpec = 0;
	public int etPow = 0;
	public int etRange = 0;
	public int etSpec = 0;
	public int ltCaps = 0;
	public int wtCaps = 0;
	public int etCaps =0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
