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
    price[	0	] = 	30	;
    price[	1	] = 	50	;
    price[	2	] = 	64	;
    price[	3	] = 	91	;
    price[	4	] = 	124	;
    price[	5	] = 	172	;
    price[	6	] = 	237	;
    price[	7	] = 	328	;
    price[	8	] = 	452	;
    price[	9	] = 	623	;
    price[	10	] = 	860	;
    price[	11	] = 	1187	;
    price[	12	] = 	1638	;
    price[	13	] = 	2260	;
    price[	14	] = 	3118	;
    price[	15	] = 	4302	;
    price[	16	] = 	5936	;
    price[	17	] = 	8190	;
    price[	18	] = 	11301	;
    price[	19	] = 	15593	;
    price[	20	] = 	21516	;
    price[	21	] = 	29687	;
    price[	22	] = 	40962	;
    price[	23	] = 	56519	;
    price[	24	] = 	77985	;
    price[	25	] = 	107603	;
    price[	26	] = 	148471	;
    price[	27	] = 	204859	;
    price[	28	] = 	282664	;
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
