using UnityEngine.SceneManagement;

public static class SceneLoader 
{
    public static void LoadAnyScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
