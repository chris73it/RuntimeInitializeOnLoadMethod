using UnityEngine;

public class Main : MonoBehaviour
{
    static int numAwakeExecutions = 0;
    static GameObject _mainResources;

    // Runs before a scene gets loaded.
    // NOTE1 Sometimes we want to drag _Main into the Hierarchy before pressing Play,
    //       for instance because we want to access the child objects parented under _Main.
    //       We accomplish that by making the _Main in the Hierarchy active and the one
    //       in Resources inactive, then we press Play.
    // NOTE2 We remove (Clone) from the name of the instantiated _Main so it is no different
    //       from the _Main manually dragged into the Hierarchy.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void LoadMain()
    {
        _mainResources = Resources.Load("_Main") as GameObject;
        if (_mainResources == null)
        {
            Debug.LogError("Could not find Resources::_Main");
            return;
        }
        if (_mainResources.activeSelf == false)
        {
            Debug.Log("Resources::_Main is inactive");
        }
        _mainResources = Object.Instantiate(_mainResources);
        _mainResources.name = "_Main"; // Remove trailing (Clone) from _Main(Clone)'s name.
        GameObject.DontDestroyOnLoad(_mainResources);
    }

    // You can choose to add any "Service" component to the _Main prefab.
    // Examples are: Input, Saving, Sound, Config, Asset Bundles, Advertisements, etc.
    // You can also append child objects to _Main.

    private void Awake()
    {
        numAwakeExecutions++;
        Debug.Log("Number of Awake() executions " + numAwakeExecutions);
        if (numAwakeExecutions == 2)
        {
            // Keep _Main and destroy the one coming from Resources,
            // otherwise keep the one from Resources (the one whose
            // name has been changed to drop the (Clone) at the end,
            // so that, no matter what, the object in the Hierarchy
            // is always named _Main.)
            Debug.Log("Eliminating instance of cloned Resources::_Main");
            Destroy(_mainResources);
        }
    }
}