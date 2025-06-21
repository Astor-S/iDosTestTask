using UnityEngine;

public class PauseHandler : MonoBehaviour
{
    [SerializeField] CameraController _cameraController;

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        _cameraController.clickToMoveCamera = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        _cameraController.clickToMoveCamera = true;
    }
}