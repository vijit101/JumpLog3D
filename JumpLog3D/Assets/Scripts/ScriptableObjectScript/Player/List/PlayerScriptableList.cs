using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObjects/Player/PlayerScriptableList")]
public class PlayerScriptableList : ScriptableObject
{
    public List<PlayerScriptables> playerScriptables = new List<PlayerScriptables>();
}
