using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public new string name = "New Item";

    [TextArea(2, 5)]
    public string description;
    public Sprite art = null;

    public enum Type {ESSENCE, SOURVENIR, CLOTHES}
    public Type type;
}
