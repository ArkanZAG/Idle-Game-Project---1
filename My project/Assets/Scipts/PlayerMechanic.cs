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
    private int currentValue = 0;
    private int valuePerClick = 1;
    public void AddValue()
    {
        currentValue = currentValue + valuePerClick;
        counterText.text = currentValue.ToString();
    }

    public void AddValuePerClick(int addedValue, int minimumValue)
    {
        if (currentValue >= minimumValue)
        {
            valuePerClick = valuePerClick + addedValue;
            currentValue = currentValue - minimumValue;
            counterText.text = currentValue.ToString();
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
    
    private void Start()
    {
        playerButton.onClick.AddListener(AddValue);
    }
}
