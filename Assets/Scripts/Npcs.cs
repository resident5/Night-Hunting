using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Npc", menuName = "Date")]
public class Npc : ScriptableObject
{
    public string myName;
    public string description;

    public Sprite art;
    public Sprite dialogBoxArt;

    public string textPlace = "Hello, there and welcome to the date. I am your host Planty";

    public bool IsActive;
    public Item requiredItem;



}
