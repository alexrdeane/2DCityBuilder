using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManagement : MonoBehaviour
{
    public int money = 0;
    public int hourMoney = 15;
    public int buildingPower;
    public float timer = 0f;
    public int population;
    public float overallHappiness = 0f;
    public int builders;
    public bool building;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        HourlyCurrency();
    }

    void HourlyCurrency()
    {
        if (timer >= 10)
        {
            money += hourMoney;
            Debug.Log(money);
            timer = 0;
        }
    }
}
