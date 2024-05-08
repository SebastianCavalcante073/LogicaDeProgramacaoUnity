using UnityEngine;

public class ConceitoDeEncapsulamento : MonoBehaviour
{
    private int VidaPlayer; // Variável Privada


    // Método publico, que pode ser chamado de outras classes assim podendo alterar o valor da variável privada VidaPlayer de forma polimorfica.
    public void SetVidaPlayer(int vidaPlayer)
    {
        VidaPlayer = vidaPlayer;
    }

    // Método publico que retorna o valor da variável privada VidaPlayer de forma polimorfica.
    public int GetVidaPlayer()
    {
        return VidaPlayer;
    }
}