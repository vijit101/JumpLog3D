namespace LogJump.Player
{
    public class PlayerService : MonoSingletongeneric<PlayerService>
    {
        public PlayerScriptableList playerScriptableList;

        public PlayerController GetPlayerController(PlayerType playerType)
        {
            PlayerModel model = GetPlayerModel(playerType);
            PlayerController playerController = new PlayerController(model);
            return playerController;
        }

        private PlayerModel GetPlayerModel(PlayerType playerType)
        {
            PlayerScriptables scriptables = playerScriptableList.playerScriptables.Find(x => x.playerType.Equals(playerType));
            PlayerModel model = new PlayerModel(scriptables);
            return model;
        }
    }
}
