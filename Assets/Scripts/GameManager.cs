using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public enum moneyType
{
    input, output
}

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int money;
    [HideInInspector] public int bank_money;

    [Header("Text")]
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI bankText;
    public TMP_InputField moneyInput;
    public TMP_InputField moneyOutput;

    [Header("Button")]
    public GameObject inputButton;
    public GameObject outputButton;

    [Header("UI")]
    public GameObject inputPanel;
    public GameObject outputPanel;
    public GameObject noActionPanel;

    private InputMoney inputMoney;
    private OutputMoney outputMoney;
    //╫л╠шео
    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);

        inputMoney = GetComponent<InputMoney>();
        outputMoney = GetComponent<OutputMoney>();
        SetStartSetting();
    }

    private void Start()
    {
        moneyText.text = money.ToString("N0");
        bankText.text = bank_money.ToString("N0");
    }

    private void SetStartSetting()
    {
        money = 100000;
        bank_money = 50000;
    }

    public void SetInputMoney(int input)
    {
        inputMoney.MoneyInBank(input);
    }

    public void SetOutputMoney(int input)
    {
        outputMoney.MoneyOutBank(input);
    }

    public void NoActionPanel()
    {
        OnNoActionPanel();
        Invoke("OffNoActionPanel", 1f);
    }

    private void OnNoActionPanel()
    {
        noActionPanel.SetActive(true);
    }
    private void OffNoActionPanel()
    {
        noActionPanel.SetActive(false);
    }
}
