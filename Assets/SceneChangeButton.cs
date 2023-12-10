using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene you want to load

    // This method is called when the button is clicked
    public void ChangeSceneOnClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
