using TMPro;
using UnityEngine;

public class WonScreen : MonoBehaviour
{
    public TextMeshProUGUI Wontext;
    private void Start()
    {
        Wontext.text = "Player " + PlayerPrefs.GetInt("PlayerWon") + " Won";
    }
    public void loadLevel(int level)
    {
        SceneLoader.LoadAnyScene(level);
    }
}
