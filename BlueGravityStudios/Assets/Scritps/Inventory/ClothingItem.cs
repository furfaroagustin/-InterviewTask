using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MenuStore",menuName ="Templates/InformationItemStore")]
public class ClothingItem:ScriptableObject
{
    public string titleName;
    public int price;
    public Sprite sprite;
   }