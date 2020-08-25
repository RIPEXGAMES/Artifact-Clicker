using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyGen : MonoBehaviour
{
    public int enemyCurHP;
    private int enemyMaxHP;
    private int enemyId;
    public GameObject enemyName;
    public GameObject enemyHP;
    private bool enemyAlive;    
    string[,] enemies = new string [5, 2];
    void Start() 
    {
        enemyAlive = false;
        enemies[	0,0	] = 	"Крыса"	;
        enemies[	1,0	] = 	"Волшебник"	;
        enemies[	2,0	] = 	"Крестьянин"	;
        enemies[	3,0	] = 	"Разбойник"	;
        enemies[	4,0	] = 	"Стражник"	;
        enemies[	0,1	] = 	"1"	;
        enemies[	1,1	] = 	"2"	;
        enemies[	2,1	] = 	"2"	;
        enemies[	3,1	] = 	"3"	;
        enemies[	4,1	] = 	"4"	;
    }
    void Update()
    {
        if (enemyCurHP <= 0)
            {
                enemyAlive = false;
            }
        if (enemyAlive == false) 
        {
            enemyId = initializeOfEnemy();
            enemyMaxHP = int.Parse(enemies[enemyId,1]);
            enemyCurHP = enemyMaxHP;
            enemyName.GetComponent<TMP_Text>().text = enemies[enemyId,0];
            enemyAlive = true;
        } 
        enemyHP.GetComponent<TMP_Text>().text = enemyCurHP + "/" + enemyMaxHP;
    }
    int initializeOfEnemy()
    {
        int a = Random.Range (0,5);
        return a;
    }
}
