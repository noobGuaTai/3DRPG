using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{
    public string name;
    public string[] contentList;

    protected override void Interact(){
        print("Interacted with " + name);
        DialogUI.Instance.Show(name, contentList);
    }
}
