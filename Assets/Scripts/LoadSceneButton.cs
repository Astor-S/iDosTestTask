using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad;

    public void OnButtonClick()
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadLevelAsync(_sceneToLoad));
    }

    private IEnumerator LoadLevelAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}