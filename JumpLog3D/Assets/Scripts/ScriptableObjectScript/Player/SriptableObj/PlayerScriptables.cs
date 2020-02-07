using LogJump.Player;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Player/PlayerScriptable")]
public class PlayerScriptables : ScriptableObject
{
    public PlayerType playerType;
    public float jumpStep, horizontalStep;
    public PlayerView playerView;
}
