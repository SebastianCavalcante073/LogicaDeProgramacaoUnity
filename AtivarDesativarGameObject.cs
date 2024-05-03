using UnityEngine;

public class AtivarDesativarGameObject : MonoBehaviour
{
    public GameObject Objeto;

    private void Start()
    {
        //Objeto.SetActive(true);   Ativa o GameObject
        //Objeto.SetActive(false);  Desativa o GameObject 
        //Objeto.activeSelf() retorna o estado atualo do objeto ou seja true ou false.

        if (Objeto.activeSelf) // Se o objeto estiver ativo
        {
            Objeto.SetActive(false); // Desativa o objeto
        }
        else // Se não estiver ativo
        {
            Objeto.SetActive(true); // Ativa o objeto
        }
    }
}