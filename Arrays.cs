using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Arrays Declaração
    public string[] Inimigos = new string[3]; 


    // Start is called before the first frame update
    void Start()
    {
        // Percorrendo o array de inimigos e mostrando no DebugLog
        foreach (string i in Inimigos)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
