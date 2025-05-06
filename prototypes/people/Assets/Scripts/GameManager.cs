using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    // Create a list
    public List<UnitScript> units = new List<UnitScript>();

    public Camera cam;

    public UnitScript selectedUnit = null;

    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text dialogueText;

    void OnEnable()
    {
        if (GameManager.instance != null)
        {
            Destroy(this);
        }
        else
        {
            GameManager.instance = this;
        }

        // Subscribe to the action that will come from the DialogueManager
        DialogueManager.DialogueAction += DisplayDialogue;
    }

    void OnDisable() 
    {
        DialogueManager.DialogueAction -= DisplayDialogue;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayDialogue(string speaker, string dialogue) {
        nameText.text = speaker;
        dialogueText.text = dialogue;
        dialoguePanel.SetActive(true);
    }

    public void SelectUnit(UnitScript unit)
    {
        if (selectedUnit != null)
        {
            // Deselect the previously selected unit.
            selectedUnit.bodyRenderer.material.color = selectedUnit.unselectedColor;
        }

        // Set the currently selected unit to be the unit passed in to this function (that's the whole point!).
        selectedUnit = unit;
        selectedUnit.bodyRenderer.material.color = selectedUnit.selectedColor;
    }

}
