using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class moneyText : MonoBehaviour
{
    private TMP_Text moneyCounter;
    private int money;
    public GameObject mainValues;
    void Start()
    {
        moneyCounter = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        money = mainValues.GetComponent<mainValues>().money;
        moneyCounter.text = money.ToString();
    }
}
