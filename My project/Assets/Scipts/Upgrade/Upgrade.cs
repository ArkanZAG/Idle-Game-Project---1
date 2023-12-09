using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Scipts.Upgrade
{
    public class Upgrade : MonoBehaviour
    {
        [FormerlySerializedAs("upgradeButton")] [SerializeField] private Button upgradePointGainButton;
        [SerializeField] private Button upgradeGetMoneyValueButton;
        [SerializeField] private Button upgradePasivePointButton;
        [SerializeField] private PlayerMechanic playerMechanic;
        

        private void Start()
        {
            upgradePointGainButton.onClick.AddListener(UpgradePointGetValue);
            upgradeGetMoneyValueButton.onClick.AddListener(UpgradeMoneyValue);
            upgradePasivePointButton.onClick.AddListener(UpgradeGetPasivePoint);
        }

        private void UpgradePointGetValue()
        {
            bool canUpgrade = playerMechanic.CheckCanUpgrade(10);
            if (canUpgrade == false)
            {
                PlayCannotUpgradeEffects();
            }
            playerMechanic.AddValuePerClick(1, 10);
        }

        private void UpgradeMoneyValue()
        {
            bool canUpgrade = playerMechanic.CheckCanUpgrade(10);
            if (canUpgrade == false)
            {
                PlayCannotUpgradeEffects();
            }
            playerMechanic.AddMoneyValue(1, 10);
        }

        private void UpgradeGetPasivePoint()
        {
            bool canUpgrade = playerMechanic.CheckCanUpgrade(10);
            if (canUpgrade == false)
            {
                PlayCannotUpgradeEffects();
            }
            playerMechanic.AddPasivePointValue(1, 10);
        }

        private void PlayCannotUpgradeEffects()
        {
            Debug.Log("Cannot Upgrade!");
        }
    }
}