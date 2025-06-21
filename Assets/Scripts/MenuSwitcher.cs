using UnityEngine;

public class MenuSwitcher : MonoBehaviour
{
    [SerializeField] private LevelMenu _levelMenu;
    [SerializeField] private KeyCode _menuKey = KeyCode.Escape;
    [SerializeField] private PauseHandler _pauseHandler;

    private void Update()
    {
        if (Input.GetKeyDown(_menuKey))
            OpenMenu(); 
    }

    public void CloseMenu()
    {
        _levelMenu.gameObject.SetActive(false);
        _pauseHandler.ContinueGame();
    }

    private void OpenMenu()
    {
        _levelMenu.gameObject.SetActive(true);
        _pauseHandler.PauseGame();
    }
}