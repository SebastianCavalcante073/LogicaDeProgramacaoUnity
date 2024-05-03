using UnityEngine;

public class AtivaDesativaComponent : MonoBehaviour
{
    public GameObject Objeto;

    private void Start()
    {
        // Objeto.GetComponent<Light>().enabled = true;  Captura o componente Light que está presente no Objeto referência e o ativa
        // Objeto.GetComponent<Light>().enabled = false; Captura o componente Light que está presente no Objeto referência e o ativa

        if (Objeto.GetComponent<Light>().enabled) // Se o componente Light estiver ativo
        {
            Objeto.GetComponent<Light>().enabled = false; // Desativa o Componente Light
        }
        else // Se não estiver ativo
        {
            Objeto.GetComponent<Light>().enabled = true; // Ativa o componente Light
        }
    }
}