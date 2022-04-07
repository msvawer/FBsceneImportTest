using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneUtils
{
    public enum SceneId
    {
        SampleScene,
        Scene2,
        Scene3
    }

    public static readonly string[] scenes = { Names.SampleScene, Names.Scene2, Names.Scene3 };

    public static class Names
    {
        //*The scene names in the quotes need to be the exact names of the actual scenes
        public static readonly string XRPersistent = "XRPersistent";
        public static readonly string SampleScene = "SampleScene";
        public static readonly string Scene2 = "Scene2";
        public static readonly string Scene3 = "Scene3";
    }

    public static void AlignXRRig(Scene persistentScene, Scene currentScene)
    {
        GameObject[] currentObjects = currentScene.GetRootGameObjects();
        GameObject[] persistentObjects = persistentScene.GetRootGameObjects();

        foreach (var origin in currentObjects)
            if (origin.CompareTag("XRRigOrigin"))
            {
                foreach (var rig in persistentObjects)
                {
                    if (rig.CompareTag("XRRig"))
                    {
                        rig.transform.position = origin.transform.position;
                        rig.transform.rotation = origin.transform.rotation;
                        return;
                    }
                }
            }

    }


}



