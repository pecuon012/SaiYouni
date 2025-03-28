using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 5 Enemies variables
    int CurrentHp = 20; //variables 1
    float head = 100f;  //variables 2
    bool Isdead = true; //variables 3 
    string monster_name = "jn"; //variables 4 
    double boss = 1000000000000; //variables 5 

    // 5 Enemies methods
    public virtual int CurrentHp1() //Method 1
    {
        return CurrentHp;
    }
    public virtual float GetMheadaxWeight2() //Method 2
    {
        return head;
    }
    public virtual bool Isdead3() //Method 3
    {
        return this.Isdead;
    }
    public virtual string monster_name4() //Method 4
    {
        return monster_name;
    }
    public virtual double boss5() //Method 5
    {
        return boss;
    }

}
