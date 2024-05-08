using UnityEngine;

public class TesteDeEncapsulamento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Instânciando um objeto do tipo ConceitoDeEncapsulamento de nome player!
        ConceitoDeEncapsulamento player = new ConceitoDeEncapsulamento();

        // Acessando é definindo de forma polimorfica o valor da variável privada VidaPlayer, atravez do Método publico SetVidaPlayer();
        player.SetVidaPlayer(100);

        // Obtendo o valor da variável VidaPlayer de forma polimorfica atravez do método GetVidaPlayer.
        Debug.Log(player.GetVidaPlayer());
    }
}