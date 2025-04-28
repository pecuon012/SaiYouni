using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] protected EnemyCtrl EnemyCtrl;
    [SerializeField] protected List<Targetable> enemies;
    // Start is called before the first frame update
    protected virtual void OnTriggerEnter(Collider other) //trong collier
    {
        Targetable targetable = other.GetComponent<Targetable>();
        if (targetable == null) return;
        enemies.Add(targetable);
    }
    protected virtual void OnTriggerExit(Collider other) // khi ra khỏi collier
    {
        Targetable targetable = other.GetComponent<Targetable>();
        if (targetable == null) return;
        enemies.Remove(targetable);

    }
}
