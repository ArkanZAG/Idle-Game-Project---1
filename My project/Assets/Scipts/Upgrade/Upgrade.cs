using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Scipts.Upgrade
{
    public class Upgrade : MonoBehaviour
    {
        [SerializeField] private Button upgradeButton;
        [SerializeField] private PlayerMechanic playerMechanic;

        private void Start()
        {
            upgradeButton.onClick.AddListener(UpgradeValue);
        }

        private void UpgradeValue()
        {
            bool canUpgrade = playerMechanic.CheckCanUpgrade(10);
            if (canUpgrade == false)
            {
                PlayCannotUpgradeEffects();
            }
            playerMechanic.AddValuePerClick(1, 10);
        }

        private void PlayCannotUpgradeEffects()
        {
            Debug.Log("Cannot Upgrade!");
        }
    }
}