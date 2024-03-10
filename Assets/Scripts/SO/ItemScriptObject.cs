using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu]
public class ItemScriptObject : ScriptableObject
{
    public int id;
    public string name;
    public ItemType itemType;
    public string description;
    public List<ItemProperty> propertyList;
    public Sprite icon;
    public GameObject prefab;
    
}

public enum ItemType{
    Weapon,
    Consumable,
}

public enum ItemPropertyType{
    HP,
    Energy,
    Mental,
    Speed,
    Attack,
}

[Serializable]
public class ItemProperty{
    public ItemPropertyType propertyType;
    public int value;
}