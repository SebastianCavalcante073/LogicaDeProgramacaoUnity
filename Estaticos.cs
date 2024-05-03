using UnityEngine;

public class Estaticos : MonoBehaviour
{
    public static Estaticos estaticos; // Classe estatica 

    private void Start()
    {
        estaticos = this; // Refer�ncia para a propria classe
    }

    public void OlaMundo() 
    {
        Debug.Log("Ol�, Mundo!");
    }
}
