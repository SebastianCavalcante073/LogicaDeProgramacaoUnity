using UnityEngine;

public class Estaticos : MonoBehaviour
{
    public static Estaticos estaticos; // Classe estatica 

    private void Start()
    {
        estaticos = this; // Referência para a propria classe
    }

    public void OlaMundo() 
    {
        Debug.Log("Olá, Mundo!");
    }
}
