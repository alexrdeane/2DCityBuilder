using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Income : MonoBehaviour
{
    public static int income = 10; // amount we recieve
    public int payment;
    public float incomeTime = 10f; // how often we get income
    public float nextIncomeTime; // How long between incomes
    public GameObject gameObject; // The game object that works as the bank

    public void AddIncome(int payment) // Function that adds income
    {
        income += payment;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > incomeTime) // If the correct amount of time has passed to recieve income
        {
            // GetComponent<Bank>().
            AddIncome(payment); // Finds the "bank" and adds money
            Debug.Log("We got money"); // Testing to see if it works
            nextIncomeTime = Time.time + incomeTime; // The next income will occur after the next income time has passed
        }
        UpdatePayment();

    }
    void UpdatePayment()
    {
        payment = income;
    }
}
