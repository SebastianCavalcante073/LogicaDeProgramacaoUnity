using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaDoWhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int total = 5;
        //Estrutura de Repetição DoWhile 
        do
        {
            Debug.Log(total);
            total--;
        } while (total >= 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
