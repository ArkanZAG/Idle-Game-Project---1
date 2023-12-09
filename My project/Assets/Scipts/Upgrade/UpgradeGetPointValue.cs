using System;
using UnityEngine;
using UnityEngine.UI;


namespace Scipts.Upgrade
{
    public class UpgradeGetPointValue : MonoBehaviour
    {
        [SerializeField] private Button upgradeButton;
        [SerializeField] private PlayerMechanic playerMechanic;
        
        private void UpgradePointGetValue()
        {
            playerMechanic.AddValuePerClick(1, 10);
        }

        private void Start()
        {
            upgradeButton.onClick.AddListener(UpgradePointGetValue);
        }
    }
}