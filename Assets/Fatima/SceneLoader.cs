using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName = "Architecture_Prototype_Broken"; // The name of the scene to load

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName); // Load the scene with the specified name
    }
}
