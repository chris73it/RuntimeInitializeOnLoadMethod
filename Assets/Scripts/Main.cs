using UnityEngine;

public class Main : MonoBehaviour
{
    // Runs before a scene gets loaded
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void LoadMain()
    {
        GameObject main = Object.Instantiate(Resources.Load("_Main")) as GameObject;
        GameObject.DontDestroyOnLoad(main);
    }

    // You can choose to add any "Service" component to the Main prefab.
    // Examples are: Input, Saving, Sound, Config, Asset Bundles, Advertisements, etc.
    // You can also append child objects to the Main object in the Hierarchy.
}
