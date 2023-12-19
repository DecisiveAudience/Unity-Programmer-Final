using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStarter : MonoBehaviour
{
    // The name or index of the scene to load
    public string sceneName;

    // Start is called before the first frame update
    void clicked()
    {
        // Load the scene
        SceneManager.LoadScene(sceneName);
    }
}