using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int money;
    [HideInInspector] public int bank_money;




    public void SetStartSetting()
    {
        money = 100000;
        bank_money = 50000;
    }
}
