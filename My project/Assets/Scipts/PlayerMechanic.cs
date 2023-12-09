using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerMechanic : MonoBehaviour
{
    [SerializeField] private Button playerButton;
    [SerializeField] private TextMeshProUGUI counterText;
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI pointButtonLevelText;
    [SerializeField] private TextMeshProUGUI moneyButtonLevelText;
    [SerializeField] private TextMeshProUGUI pasivePointButtonLevelText;
    private int currentButtonLevel = 1;
    private int currentMoneyValue = 0;
    private int currentValue = 0;
    private int valuePerClick = 1;
    private int valueMoneyPerClick = 1;
    
    public void AddValue()
    {
        currentValue = currentValue + valuePerClick;
        counterText.text = currentValue.ToString();
    }

    public void AddValuePerClick(int addedValue, int minimumValue)
    {
        if (currentMoneyValue >= minimumValue)
        {
            valuePerClick = valuePerClick + addedValue;
            currentValue = currentValue - minimumValue;
            counterText.text = currentValue.ToString();
            currentButtonLevel = currentButtonLevel + addedValue;
            pointButtonLevelText.text = currentButtonLevel.ToString();
        }
    }

    public void AddMoneyValue(int addedValue, int minimumValue)
    {
        if (currentMoneyValue >= minimumValue)
        {
            valueMoneyPerClick = valueMoneyPerClick + addedValue;
            currentMoneyValue = currentMoneyValue - minimumValue;
            moneyText.text = currentMoneyValue.ToString();
            currentButtonLevel = currentButtonLevel + addedValue;
            moneyButtonLevelText.text = currentButtonLevel.ToString();
        }
    }

    public void AddPasivePointValue(int addedValue, int minimumValue)
    {
        if (currentMoneyValue >= minimumValue)
        {
            
        }
    }

    public void AddMoneyPerMilesstone(int addedValue)
    {
        if (currentValue % 10 == 0)
        {
            currentMoneyValue = currentMoneyValue + addedValue;
            moneyText.text = currentMoneyValue.ToString();
        }
    }

    public bool CheckCanUpgrade(int minimumValue)
    {
        if (currentValue >= minimumValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool AddPlayerMoneyValue()
    {
        if (currentValue % 10 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private void Start()
    {
        playerButton.onClick.AddListener(AddValue);
        AddMoneyPerMilesstone(1);
    }
}
