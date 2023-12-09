using System;
using UnityEngine;
using UnityEngine.UI;


namespace Scipts.Upgrade
{
    public class UpgradeGetMoneyValue : MonoBehaviour
    {
        [SerializeField] private Button upgradeButton;
        [SerializeField] private PlayerMechanic playerMechanic;
        
        private void UpgradeMoneyValue()
        {
            playerMechanic.AddMoneyValue(1, 10);
        }

        private void Start()
        {
            upgradeButton.onClick.AddListener(UpgradeMoneyValue);
        }
    }
}