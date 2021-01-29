using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Storage/Item")]
public class Item : ScriptableObject
{
    public string name = "New Item";
    public Sprite icon = null;
}
