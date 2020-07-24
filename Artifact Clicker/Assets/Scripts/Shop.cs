using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private int price;
        private void Start()
    {
        price = 5;
        GetComponentInChildren<TMP_Text>().text = price.ToString();
    }
}
