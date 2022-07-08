using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    GameObject avatar;

    private void Start()
    {
        avatar = GameObject.Find("Avatar");
        avatar.SetActive(false);
    }

    public void LoadScene(int buildIndex)
    {
        Debug.Log("Loading Level " + buildIndex);
        // Disable the avatar in the 0_Menu scene, otherwise activate it
        avatar.SetActive(buildIndex != 0);
        SceneManager.LoadScene(buildIndex);
    }
}
