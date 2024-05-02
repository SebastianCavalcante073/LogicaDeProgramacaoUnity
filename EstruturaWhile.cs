using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaWhile : MonoBehaviour
{
    int Damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Estrutura de Repetição While

        while (Damage >= 0)
        {
            Debug.Log(Damage);
            Damage--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
