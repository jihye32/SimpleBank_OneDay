using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int money;
    [HideInInspector] public int bank_money;

    [Header("Text")]
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI bankText;

    [Header("Button")]
    public GameObject inputButton;
    public GameObject outputButton;

    [Header("UI")]
    public GameObject inputPanel;
    public GameObject outputPanel;
    public GameObject noActionPanel;

    //╫л╠шео
    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);
    }

    private void Start()
    {
        SetStartSetting();
        moneyText.text = money.ToString();
        bankText.text = bank_money.ToString();
    }

    private void SetStartSetting()
    {
        money = 100000;
        bank_money = 50000;
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
