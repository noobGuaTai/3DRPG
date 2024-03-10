using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : Interactable
{
    protected override void Interact(){
        print("Interact with Pickable");
    }
}
