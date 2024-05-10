using System.Collections;
using UnityEngine;

public class Corrotinas : MonoBehaviour
{
    public byte PlayerVida = 10; // Variável PlayerVida, representa a vida de um player no jogo.

    private void Start()
    {

        StartCoroutine("AumentarVida"); // Chama a Corrotina 

    }

    IEnumerator AumentarVida() // Declaração de Corrotina
    {
        // Enquanto a vida do player for menor que 100, a corrotina aguarda 2 segundos e incrementa a vida do player em +1;
        while (PlayerVida < 100)
        {
            yield return new WaitForSeconds(2f); // Pausa a execução por 2 segundos.
            PlayerVida++;// Incrementa em +1 a vida do player
        }
    }
}