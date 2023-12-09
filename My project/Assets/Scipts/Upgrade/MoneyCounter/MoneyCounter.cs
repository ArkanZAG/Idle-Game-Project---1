using System;
using TMPro;
using UnityEngine;

namespace Scipts.Upgrade.MoneyCounter
{
    public class MoneyCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI moneyText;
        [SerializeField] private PlayerMechanic playerMechanic;
        
        private void AddPlayerMoney()
        {
            bool addPlayerMoney = playerMechanic.AddPlayerMoneyValue();
            if (addPlayerMoney == true)
            {
                moneyText.text = moneyText.text + 1;
            }
        }

        private void Start()
        {
            AddPlayerMoney();
        }
    }
}