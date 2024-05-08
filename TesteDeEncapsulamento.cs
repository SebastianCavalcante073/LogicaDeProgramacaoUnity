using UnityEngine;

public class TesteDeEncapsulamento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Inst�nciando um objeto do tipo ConceitoDeEncapsulamento de nome player!
        ConceitoDeEncapsulamento player = new ConceitoDeEncapsulamento();

        // Acessando � definindo de forma polimorfica o valor da vari�vel privada VidaPlayer, atravez do M�todo publico SetVidaPlayer();
        player.SetVidaPlayer(100);

        // Obtendo o valor da vari�vel VidaPlayer de forma polimorfica atravez do m�todo GetVidaPlayer.
        Debug.Log(player.GetVidaPlayer());
    }
}