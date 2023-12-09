using System;
using UnityEngine;
using UnityEngine.UI;

namespace Scipts
{
    public class ConvertPointToMoney : MonoBehaviour
    {
        [SerializeField] private Button convertButton;
        [SerializeField] private PlayerMechanic playerMechanic;

        private void ConvertPointtoMoney()
        {
            playerMechanic.ConvertPointtoMoney(10);
        }

        private void Start()
        {
            convertButton.onClick.AddListener(ConvertPointtoMoney);
        }
    }
}