using LogJump.Player;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPlatformService : MonoBehaviour
{
    public PlayerViewType PlatformForPlayer;
    public PlayerType GetPlayerType;
    [Tooltip("Add jumpButton as per player for player 1 jump button 1")]
    public Button jumpButton; // add button p1 in platfrom 1 and p2 in platform 2

    private void Start()
    {
        DefaultSetup();
        jumpButton.onClick.AddListener(DefaultSetup);
    }
    private void DefaultSetup()
    {
        PlayerController controller = PlayerService.Instance.GetPlayerController(GetPlayerType);
        controller.playerView.SetPlayerPos(transform.position);
        controller.playerView.playerViewType = PlatformForPlayer;
        controller.playerView.MovePlayer();
        jumpButton.onClick.AddListener(controller.playerView.MovePlayer);
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerView player = collision.gameObject.GetComponent<PlayerView>();
        if (player.playerViewType != PlatformForPlayer)
        {
            Debug.Log(player.playerViewType + "Won");
            PlayerPrefs.SetInt("PlayerWon",(int)player.playerViewType);
            SceneLoader.LoadAnyScene(1);
        }
    }
}
