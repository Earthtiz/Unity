using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    public Slider playerSlider3D;
    Stats statsScript;

    // Start is called before the first frame update
    void Start()
    {
        statsScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Stats>();

        playerSlider3D.maxValue = statsScript.maxHealth;
        statsScript.Hp = statsScript.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerSlider3D.value = statsScript.Hp;
    }
}
