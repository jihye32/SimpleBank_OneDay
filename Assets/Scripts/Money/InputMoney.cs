using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMoney : MonoBehaviour
{
    private int money;
    private int bank_money;
    private int input_money;

    private void Start()
    {
        money = GameManager.instance.money;
        bank_money = GameManager.instance.bank_money;
    }

    private void Update()
    {
        
    }

    public void MoneyInBank(int input)
    {
        input_money = input;
        if(input_money < money)
        {
            GameManager.instance.NoActionPanel();
        }
        else
        {
            money -= input_money;
            bank_money += input_money;
        }
    }
}
