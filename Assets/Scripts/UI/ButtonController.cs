using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
