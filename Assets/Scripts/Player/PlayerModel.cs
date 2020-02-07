namespace LogJump.Player
{
    public class PlayerModel
    {
        public PlayerType playerType;
        public float jumpStep, horizontalStep;
        public PlayerView playerView;


        public PlayerModel(PlayerScriptables scriptables)
        {
            playerType = scriptables.playerType;
            jumpStep = scriptables.jumpStep;
            playerView = scriptables.playerView;
            horizontalStep = scriptables.horizontalStep;
        }
    }

}
