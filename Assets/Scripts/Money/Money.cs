using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum moneyType
{
    one = 10000,
    three = 30000,
    five = 50000,
    self
}


[CreateAssetMenu(fileName = "Money", menuName = "SetMoney", order = 0)]
public class Money : ScriptableObject
{
    public moneyType type;
    public int amount;
}
