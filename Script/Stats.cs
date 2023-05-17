using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public float maxHealth;
    public float Hp;
    public float attackDmg;
    public float attackSpeed;
    public float attackTime;

    void Update()
    {
        if(Hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
    }
}
