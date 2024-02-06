using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class ButtonController : MonoBehaviour
{
    public void OnInputButton()
    {
        GameManager.instance.inputPanel.SetActive(true);
    }

    public void OnOutputButton()
    {
        GameManager.instance.outputPanel.SetActive(true);
    }

    public void OnOutButton()
    {
        GameManager.instance.inputPanel.SetActive(false);
        GameManager.instance.outputPanel.SetActive(false);
    }

    public void OnInputButton(int n)
    {
        GameManager.instance.SetInputMoney(n);
    }

    public void OnOutputButton(int n)
    {
        GameManager.instance.SetOutputMoney(n);
    }

    public void OnSelfInputButton()
    {
        OnInputButton(int.Parse(GameManager.instance.moneyInput.text));
    }

    public void OnSelfOutputButton()
    {
        OnOutputButton(int.Parse(GameManager.instance.moneyOutput.text));
    }
}
