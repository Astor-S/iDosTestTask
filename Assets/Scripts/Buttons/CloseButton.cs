using UnityEngine;

namespace Buttons
{
    public class CloseButton : MonoBehaviour
    {
        [SerializeField] MenuSwitcher _menuSwitcher;

        public void OnButtonClick() =>
            _menuSwitcher.CloseMenu();
    }
}