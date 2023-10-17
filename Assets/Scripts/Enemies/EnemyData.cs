using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Enemy", order = 1)]
//A scriptableObject holds data for us that we can change, this helps create different type of enemies
public class EnemyData : ScriptableObject
{
 public int hp;
 public int damage;
 public float speed;
}
