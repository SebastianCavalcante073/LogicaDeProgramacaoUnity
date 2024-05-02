using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionalSwitch : MonoBehaviour
{
    public int Opcoes = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Estrutura condiciona Switch 
        switch (Opcoes)
        {
            case 0:
                Debug.Log($"Caso de teste é igual a {Opcoes}");
                break;
            case 1:
                Debug.Log($"Caso de teste é igual a {Opcoes}");
                break;
            case 2:
                Debug.Log($"Caso de teste é igual a {Opcoes}");
                break;
            default:
                Debug.Log("Nenhum caso equivalente!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
