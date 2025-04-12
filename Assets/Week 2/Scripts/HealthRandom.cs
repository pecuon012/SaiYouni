using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{

    
    //----------------------Edit below here --------------------
    public int maxHealth = 100;
    public int minHealth = 0;
    public int health = 0;

    //----------------------Edit above here --------------------
    // On Click function
    private void Awake()
    {
        RandomHealth();
    }
    public void Reset()
    {
        RandomHealth();
    }
    int tragiatri()
    {
        return health;
    }
    public void RandomHealth()
    {
        health = Random.Range(minHealth, maxHealth);
        tragiatri();
    }
}

