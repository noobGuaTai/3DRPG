using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{
    public string name;
    public string[] contentList;

    public DialogUI dialogUI;
    protected override void Interact(){
        print("Interacted with " + name);
        dialogUI.Show(name, contentList);
    }
}
