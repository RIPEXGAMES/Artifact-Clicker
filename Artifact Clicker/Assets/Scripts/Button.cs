using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject mainValues;
    private int money;
    private void OnMouseDown()
    {
        money = mainValues.GetComponent<mainValues>().money + 1;
        mainValues.GetComponent<mainValues>().money = money;
    }
}
