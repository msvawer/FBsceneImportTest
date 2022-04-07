using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEditor;


public static class SceneMenu
{
    [MenuItem("Scenes/SampleScene")]
    static void OpenSampleScene()
    {
        OpenScene(SceneUtils.Names.SampleScene);
    }

    [MenuItem("Scenes/Scene2")]
    static void OpenScene2()
    {
        OpenScene(SceneUtils.Names.Scene2);
    }

    [MenuItem("Scenes/SampleScene3")]
    static void OpenScene3()
    {
        OpenScene(SceneUtils.Names.Scene3);
    }


    static void OpenScene(string name)
    {
        Scene persistentScene = EditorSceneManager.OpenScene("Assets/Scenes/" + SceneUtils.Names.XRPersistent + ".unity", OpenSceneMode.Single);
        Scene currentScene = EditorSceneManager.OpenScene("Assets/Scenes/" + name + ".unity", OpenSceneMode.Additive);
        SceneUtils.AlignXRRig(persistentScene, currentScene);
    }


}

