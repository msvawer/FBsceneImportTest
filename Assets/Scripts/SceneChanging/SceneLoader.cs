using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneLoader : Singleton<SceneLoader>
{
    //Code for URP screenblit Fade

    // public Material screenfade = null;
    // [Min (0.001f)]
    // float m_fadeAmount = 0.0f;
    // public float fadeSpeed = 1.0f;
    // Couroutine m_fadeCoroutine = null;
    // static readonly int m_fadeAmountPropID = Shader.PropertyToID("_FadeAmount");

    [Range(0.0f, 5.0f)]
    public float addedWaitTime = 2.0f;

    public UnityEvent onLoadStart = new UnityEvent();
    public UnityEvent onLoadFinish = new UnityEvent();

    bool m_isLoading = false;

    Scene m_persistentScene;

    private void Awake()
    {
        SceneManager.sceneLoaded += SetActiveScene;
        m_persistentScene = SceneManager.GetActiveScene();

        if (!Application.isEditor)
        {
            SceneManager.LoadSceneAsync(SceneUtils.Names.SampleScene, LoadSceneMode.Additive);
        }

    }

    private void OnDestory()
    {
        SceneManager.sceneLoaded -= SetActiveScene;
    }

    public void LoadScene(string name)
    {
        if (!m_isLoading)
        {
            StartCoroutine(Load(name));
        }

    }

    void SetActiveScene(Scene scene, LoadSceneMode mode)
    {
        SceneManager.SetActiveScene(scene);
        SceneUtils.AlignXRRig(m_persistentScene, scene);
    }

    void SetActiveScene()
    {

    }

    IEnumerator Load(string name)
    {
        m_isLoading = true;
        onLoadStart?.Invoke();
        //yield return FadeOut();
        yield return StartCoroutine(UnloadCurrentScene());

        yield return new WaitForSeconds(addedWaitTime);

        // yield return FadeIn();
        yield return StartCoroutine(LoadNewScene(name));
        onLoadFinish?.Invoke();
        m_isLoading = false;
    }

    IEnumerator UnloadCurrentScene()
    {
        AsyncOperation unload = SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        while (!unload.isDone)
            yield return null;

    }

    IEnumerator LoadNewScene(string name)
    {
        AsyncOperation load = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
        while (!load.isDone)
            yield return null;
    }

    // IEnumerator FadeOut()
    // {
    //    if(m_fadeCoroutine != null)
    //    {
    //        StopCoroutine(m_fadeCoroutine);
    //    }
    //    m_fadeCoroutine = StartCoroutine(Fade(1.0f));
    //    yield return m_fadeCoroutine;
    // }

    // IEnumerator FadeIn()
    // {
    ///   if (m_fadeCoroutine != null)
    //   {
    //      StopCoroutine(m_fadeCoroutine);
    //   }
    //  m_fadeCoroutine = StartCoroutine(Fade(0.0f));
    //   yield return m_fadeCoroutine;
    // }

    // IEnumerator Fade(float target)
    // {
    //    while(Mathf.Approximately(m_fadeAmount, target))
    //    {
    //        m_fadeAmount = Mathf.MoveTowards(m_fadeAmount, target, fadeSpeed * Time.deltaTime);
    //       ScreenFade.SetFloat(m_fadeAmounPropID, m_fadeAmount);
    //      yield return null;
    //   }

    //   screenFade.SetFloat(m_FadeAmount.PropID, target);
    // }

}
