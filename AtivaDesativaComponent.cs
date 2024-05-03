using UnityEngine;

public class AtivaDesativaComponent : MonoBehaviour
{
    public GameObject Objeto;

    private void Start()
    {
        // Objeto.GetComponent<Light>().enabled = true;  Captura o componente Light que est� presente no Objeto refer�ncia e o ativa
        // Objeto.GetComponent<Light>().enabled = false; Captura o componente Light que est� presente no Objeto refer�ncia e o ativa

        if (Objeto.GetComponent<Light>().enabled) // Se o componente Light estiver ativo
        {
            Objeto.GetComponent<Light>().enabled = false; // Desativa o Componente Light
        }
        else // Se n�o estiver ativo
        {
            Objeto.GetComponent<Light>().enabled = true; // Ativa o componente Light
        }
    }
}