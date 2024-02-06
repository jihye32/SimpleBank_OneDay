using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputMoney : MonoBehaviour
{
    private int money;
    private int bank_money;
    private int input_money;

    public void MoneyOutBank(int input)
    {
        money = GameManager.instance.money;
        bank_money = GameManager.instance.bank_money;

        input_money = input;
        if (input_money > bank_money)
        {
            GameManager.instance.NoActionPanel();
        }
        else
        {
            money += input_money;
            bank_money -= input_money;
        }

        GameManager.instance.bankText.text = bank_money.ToString("N0");
        GameManager.instance.moneyText.text = money.ToString("N0");
        GameManager.instance.money = money;
        GameManager.instance.bank_money = bank_money;
    }
}
