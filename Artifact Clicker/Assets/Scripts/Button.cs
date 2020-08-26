using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject mainValues;
    public GameObject shop;
    private float money;
    public float curMod;
    private void OnMouseDown()
    {
        curMod = shop.GetComponent<Shop>().mod[shop.GetComponent<Shop>().num];
        mainValues.GetComponent<enemyGen>().enemyCurHP -= 1;
        if (mainValues.GetComponent<enemyGen>().enemyCurHP <= 0)
        {
            money = mainValues.GetComponent<mainValues>().money + 5 * curMod;
            mainValues.GetComponent<mainValues>().money = Convert.ToInt32(money);
        }
    }
}
