using UnityEngine;

public class Main : MonoBehaviour
{
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
        var _main = Resources.Load("_Main") as GameObject;
        if (_main.activeSelf == false)
        {
            Debug.LogWarning("Skipping Resource::_Main instantiation because it is inactive");
            return;
        }
        var _mainClone = Object.Instantiate(_main);
        _mainClone.name = "_Main"; // Remove trailing (Clone) from _Main(Clone)'s name.
        //GameObject.DontDestroyOnLoad(main); // No need to do this: it is done implicitly.
    }
    
    // You can choose to add any "Service" component to the _Main prefab.
    // Examples are: Input, Saving, Sound, Config, Asset Bundles, Advertisements, etc.
    // You can also append child objects to _Main.
}