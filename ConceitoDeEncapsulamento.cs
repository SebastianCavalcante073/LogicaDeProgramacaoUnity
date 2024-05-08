using UnityEngine;

public class ConceitoDeEncapsulamento : MonoBehaviour
{
    private int VidaPlayer; // Vari�vel Privada


    // M�todo publico, que pode ser chamado de outras classes assim podendo alterar o valor da vari�vel privada VidaPlayer de forma polimorfica.
    public void SetVidaPlayer(int vidaPlayer)
    {
        VidaPlayer = vidaPlayer;
    }

    // M�todo publico que retorna o valor da vari�vel privada VidaPlayer de forma polimorfica.
    public int GetVidaPlayer()
    {
        return VidaPlayer;
    }
}