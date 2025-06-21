using UnityEngine;
using IDosGames;

namespace Buttons
{
    public class InventoryActivatorButton : MonoBehaviour
    {
        [SerializeField] InventoryWindow _inventoryWindow;

        public void OnButtonClick() =>
            _inventoryWindow.gameObject.SetActive(true);
    }
}