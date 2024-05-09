using UnityEngine;
public class Program : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Instânciando um objeto Player e acessado seus atributos apartir de um namespace.
        PlayerNameSpace.Player player = new PlayerNameSpace.Player();

        player.Vida = 10;
    }
}