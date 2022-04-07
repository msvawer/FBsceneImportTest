using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToScene : MonoBehaviour
{
    public SceneUtils.SceneId nextScene = SceneUtils.SceneId.SampleScene;

    public void Go()
    {
        SceneLoader.Instance.LoadScene(SceneUtils.scenes[(int)nextScene]);

    }


}
