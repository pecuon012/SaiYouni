using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FindEnemy : MonoBehaviour // phải tạo thêm script class enemyHp để tạo ô giá trị cho từng đối tưong
{
    List<EnemyHp> enemyList = new List<EnemyHp>();
    EnemyHp max_valuve_obj; // tạo danh sách thể hiện rõ
    EnemyHp min_valuve_obj;


    void Start()
    {
        // Tìm tất cả các Enemy là con của GameObject này (EnemyManager)
        foreach (Transform child in transform)
        {
            EnemyHp enemy = child.GetComponent<EnemyHp>();
            if (enemy != null)
            {
                // gán ngẫu nhiên biến
                enemy.currentHP = Random.Range(0, 100);

                // In ra xem obj
                Debug.Log(child.name + " có gán HP: " + enemy.currentHP);

                enemyList.Add(enemy);
            }
        }

        EnemyHp min = FindEnemyWithSmallestHealth(); // Danh sách chỉ ra số nhỏ nhất
        EnemyHp max = FindEnemyWithLargestHealth();// tương tự lớn nhất
        max_valuve_obj = max;
        min_valuve_obj = min;

        if (min != null) Debug.Log("Enemy có HP nhỏ nhất: " + min.currentHP + " (" + min.name + ")");
        if (max != null) Debug.Log("Enemy có HP lớn nhất: " + max.currentHP + " (" + max.name + ")");
    }

    public EnemyHp FindEnemyWithSmallestHealth() // TRả về đối tượng 
    {
        if (enemyList.Count == 0) return null; 

        EnemyHp smallest = enemyList[0];
        foreach (EnemyHp e in enemyList)
        {
            if (e.currentHP < smallest.currentHP)
            {
                smallest = e;
            }
        }
        return smallest;
    }

    public EnemyHp FindEnemyWithLargestHealth()
    {
        if (enemyList.Count == 0) return null;

        EnemyHp largest = enemyList[0];
        foreach (EnemyHp e in enemyList)
        {
            if (e.currentHP > largest.currentHP)
            {
                largest = e;
            }
        }
        return largest;
    }
}

