﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueManager : MonoBehaviour
{
	public static SimpleConditionalConversation scc;

	public static Action<string, string> DialogueAction;

	// NOTE: When you do not use the google sheet option, it is expecting the file
	// to be named "data.csv" and for it to be in the Resources folder in Assets.
	public bool useGoogleSheet = false;
	public string googleSheetDocID = "";

	// Start is called before the first frame update
	void Start()
	{
		if (useGoogleSheet) {
			// This will start the asyncronous calls to Google Sheets, and eventually
			// it will give a value to scc, and also call LoadInitialHistory().
			GoogleSheetSimpleConditionalConversation gs_ssc = gameObject.AddComponent<GoogleSheetSimpleConditionalConversation>();
			gs_ssc.googleSheetDocID = googleSheetDocID;
		} else {
			scc = new SimpleConditionalConversation("data");
			LoadInitialSCCState();
		}
	}
	
	public static void LoadInitialSCCState()
	{
		// Example of setting the initial state:
		// NOTE: If you are putting a number or bool, make sure not to store them
		// as strings.
		//
		// scc.setGameStateValue("playerWearing", "equals", "Green shirt");
		scc.setGameStateValue("talkedToAll", "equals", 0);
		scc.setGameStateValue("moneyLoaned", "equals", 0);
	}
	
	public void talk(string target)
    {
		string line = DialogueManager.scc.getSCCLine(target);
		GameManager.instance.DisplayDialogue(target, line);
	}

	public void talkedToAll()
    {
		scc.setGameStateValue("talkedToAll", "equals", 1);
	}
	public void setMoneyLoaned()
    {
		scc.setGameStateValue("moneyLoaned", "equals", 1);
		scc.setGameStateValue("talkedToAll", "equals", 0);
	}
	public void pay(string target)
    {
		scc.setGameStateValue("hasMoney"+target, "equals", 1);
	}
	public void allClear()
    {
		scc.setGameStateValue("allClear", "equals", 1);
		scc.setGameStateValue("moneyLoaned", "equals", 0);
		scc.setGameStateValue("talkedToAll", "equals", 0);
	}
	// Update is called once per frame
	void Update()
	{
		// An example of getting a line of dialogue.
			
			
			//Debug.Log("Mike says: " + line);
			//DialogueAction?.Invoke("Mike", line);
		
		// An example of modifying the state outside of the DialogueManager (e.g. you could put this in some
		// OnTriggerEnter or something)
		if (Input.GetKeyDown(KeyCode.G)) {

			//scc.setGameStateValue("playerWearing", "equals", "Green shirt");
			//Debug.Log("Emma puts on a green shirt.");
		}
	}
}
