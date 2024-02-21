using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCObject : InteractableObject
{

    public string Name;

    public string[] ContentList;

    public DialogueUI dialogueUI;

    protected override void Interact()
    {

        dialogueUI.Show(Name, ContentList);
        print("Interacting with NPC");

    }
}
