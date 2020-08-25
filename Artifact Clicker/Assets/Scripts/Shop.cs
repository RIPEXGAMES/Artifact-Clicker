using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int money;
    public GameObject mainValues;
    private static int arNum = 29;
    int[] price = new int[29];
    public float[] mod = new float[arNum];
    public int num = 0;
    private void Start()
    {
        price[	0	] = 	3	;
        price[	1	] = 	5	;
        price[	2	] = 	6	;
        price[	3	] = 	9	;
        price[	4	] = 	12	;
        price[	5	] = 	17	;
        price[	6	] = 	24	;
        price[	7	] = 	33	;
        price[	8	] = 	45	;
        price[	9	] = 	62	;
        price[	10	] = 	86	;
        price[	11	] = 	119	;
        price[	12	] = 	164	;
        price[	13	] = 	226	;
        price[	14	] = 	312	;
        price[	15	] = 	430	;
        price[	16	] = 	594	;
        price[	17	] = 	819	;
        price[	18	] = 	1130	;
        price[	19	] = 	1559	;
        price[	20	] = 	2152	;
        price[	21	] = 	2969	;
        price[	22	] = 	4096	;
        price[	23	] = 	5652	;
        price[	24	] = 	7799	;
        price[	25	] = 	10760	;
        price[	26	] = 	14847	;
        price[	27	] = 	20486	;
        price[	28	] = 	28266	;
        mod[	0	] = 	1.2f	;
        mod[	1	] = 	1.5f	;
        mod[	2	] = 	1.9f	;
        mod[	3	] = 	2.4f	;
        mod[	4	] = 	3.0f	;
        mod[	5	] = 	3.7f	;
        mod[	6	] = 	4.5f	;
        mod[	7	] = 	5.4f	;
        mod[	8	] = 	6.4f	;
        mod[	9	] = 	7.5f	;
        mod[	10	] = 	8.7f	;
        mod[	11	] = 	10.0f	;
        mod[	12	] = 	11.4f	;
        mod[	13	] = 	12.9f	;
        mod[	14	] = 	14.5f	;
        mod[	15	] = 	16.2f	;
        mod[	16	] = 	18.0f	;
        mod[	17	] = 	19.9f	;
        mod[	18	] = 	21.9f	;
        mod[	19	] = 	24.0f	;
        mod[	20	] = 	26.2f	;
        mod[	21	] = 	28.5f	;
        mod[	22	] = 	30.9f	;
        mod[	23	] = 	33.4f	;
        mod[	24	] = 	36.0f	;
        mod[	25	] = 	38.7f	;
        mod[	26	] = 	41.5f	;
        mod[	27	] = 	44.4f	;
        mod[	28	] = 	47.4f	;
    }
    private void Update()
    {
        GetComponentInChildren<TMP_Text>().text = price[num].ToString();
        money = mainValues.GetComponent<mainValues>().money;
    }

    private void OnMouseDown()
    {
        if (money >= price[num])
        {
            money -= price[num];
            mainValues.GetComponent<mainValues>().money = money;
            num += 1;
        }
    }
}
