using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad;

    public void OnButtonClick() =>
        StartCoroutine(LoadLevelAsync(_sceneToLoad));

    private IEnumerator LoadLevelAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}