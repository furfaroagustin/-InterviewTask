using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
[System.Serializable]
[CreateAssetMenu(fileName ="MenuStore",menuName ="InformationItemStore")]
public class ClothingItem:ScriptableObject
{
    public string titleName;
   // public string description;
    public int price;
    public Sprite sprite;
   
}