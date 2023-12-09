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
    private int currentPointButtonLevel = 1;
    private int currentMoneyButtonLevel = 1;
    private int currentMoneyValue = 0;
    private int currentPointValue = 0;
    private int valuePerClick = 1;
    private int valueMoneyPerClick = 1;
    
    public void AddValue()
    {
        currentPointValue = currentPointValue + valuePerClick;
        counterText.text = currentPointValue.ToString();
    }

    public void AddValuePerClick(int addedValue, int minimumValue)
    {
        if (currentMoneyValue >= minimumValue)
        {
            valuePerClick = valuePerClick + addedValue;
            currentMoneyValue = currentMoneyValue - minimumValue;
            moneyText.text = currentMoneyValue.ToString();
            currentPointButtonLevel = currentPointButtonLevel + addedValue;
            pointButtonLevelText.text = currentPointButtonLevel.ToString();
        }
    }

    public void AddMoneyValue(int addedValue, int minimumValue)
    {
        if (currentMoneyValue >= minimumValue)
        {
            valueMoneyPerClick = valueMoneyPerClick + addedValue;
            currentMoneyValue = currentMoneyValue - minimumValue;
            moneyText.text = currentMoneyValue.ToString();
            currentMoneyButtonLevel = currentMoneyButtonLevel + addedValue;
            moneyButtonLevelText.text = currentMoneyButtonLevel.ToString();
        }
    }

    public void ConvertPointtoMoney(int minimumValue)
    {
        if (currentPointValue >= minimumValue)
        {
            var upgradeCount = Mathf.FloorToInt(currentPointValue / 10f);
            currentMoneyValue = currentMoneyValue + upgradeCount;
            currentPointValue = currentPointValue - upgradeCount * 10;
            moneyText.text = currentMoneyValue.ToString();
            counterText.text = currentPointValue.ToString();
        }
    }

    public void AddPasivePointValue(int addedValue, int minimumValue)
    {
        
    }

    private void Start()
    {
        playerButton.onClick.AddListener(AddValue);
    }

    private void Update()
    {
        
    }
}
