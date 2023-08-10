using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="MenuStore",menuName ="InformationItemStore")]
public class ClothingItem:ScriptableObject
{
    public string titleName;
    public int price;
    public Sprite sprite;
   
}