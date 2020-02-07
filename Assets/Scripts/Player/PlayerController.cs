using UnityEngine;
namespace LogJump.Player
{
    public class PlayerController
    {
        PlayerModel playerModel;
        public PlayerView playerView;
        public PlayerController(PlayerModel model)
        {
            playerModel = model;
            playerView = GameObject.Instantiate<PlayerView>(playerModel.playerView);
            playerView.SetMyController(this);
            playerView.horizontalStep = model.horizontalStep;
            playerView.jumpForce = model.jumpStep;
        }        
    }
}
