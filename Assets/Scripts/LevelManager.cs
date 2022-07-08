using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject avatar;

    private void Start()
    {
        GameObject ui = GameObject.Find("UI");
        if (ui != null)
        {
            // No avatar while the menu is open
            avatar.SetActive(false);
        }
    }

    public void LoadScene(int buildIndex)
    {
        Debug.Log("Loading scene with build index " + buildIndex);
        // Disable the avatar in the 0_Menu scene, otherwise activate it
        avatar.SetActive(buildIndex != 0);
        SceneManager.LoadScene(buildIndex);
    }
}
