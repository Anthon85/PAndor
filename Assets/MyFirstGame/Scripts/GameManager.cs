using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] string sceneName = "Unset!!!";

    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
