using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    [SerializeField] float _interval = 1f;
    public void SeneLoad(string sceneName)
    {
        StartCoroutine(WaitSceneChange(sceneName));
    }

    IEnumerator WaitSceneChange(string sceneName)
    {
        yield return new WaitForSeconds(_interval);
        SceneManager.LoadScene(sceneName);
    }
}
