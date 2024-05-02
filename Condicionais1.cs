using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais1 : MonoBehaviour
{
    int Idade = 18;
    // Start is called before the first frame update
    void Start()
    {
        // Comandos if else 
        if (Idade < 18)
        {
            Debug.Log("Menor de idade");
        }
        else
        {
            Debug.Log("Maior de idade");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
