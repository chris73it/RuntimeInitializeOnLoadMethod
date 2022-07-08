using UnityEngine;

public class SelectLevel : MonoBehaviour
{
    GameObject _Main;
    LevelManager levelManager;

    private void Start()
    {
        _Main = GameObject.Find("_Main");
        levelManager = _Main.GetComponent<LevelManager>();
    }

    public void SetLevel(int buildIndex)
    {
        levelManager.LoadScene(buildIndex);
    }
}
