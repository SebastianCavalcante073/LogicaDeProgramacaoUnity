using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstruturaForeach : MonoBehaviour
{
    List<string> Inimigos = new List<string> { "Gargula", "Borus", "Flerton" };
    // Start is called before the first frame update
    void Start()
    {
        // Estrutura Foreach
        foreach (string inimigos in Inimigos) // Percorre toda a lista de inimigos e mostra no debug.
        {
            Debug.Log(inimigos);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
