using UnityEngine;

public class OperadorTernario : MonoBehaviour
{
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        // Usando o condicional if e else 
        //  if (vida >= 0)
        //  {
        //      Debug.Log("Player ainda tem vida!");
        //  }
        //  else
        //  {
        //      Debug.Log("Player foi eliminado!");
        //  }



        // Usando o operador Ternario para fazer a mesma verificação!
        Debug.Log(vida >= 0 ? "Player ainda tem vida!" : "Player foi eliminado!"); 
    }
}