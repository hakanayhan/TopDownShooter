using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour
{
    private float Health=100;
    public void Hit(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Debug.Log("health zero");
        }
        else
        {
            Debug.Log("current health: " + Health);
        }
    }
}
