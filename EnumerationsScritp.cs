using UnityEngine;

public class EnumerationsScritp : MonoBehaviour
{
    // Enumerador de dire��es
    public enum Direcoes 
    {
        Norte = 0,
        Sul = 1,
        Lest = 2,
        Oeste = 3
    }

    public Direcoes MinhaDirecao; // Vari�vel de refer�ncia ao Enumerador Direcoes

    private void Start()
    {
        // Caso de teste com Switch 
        switch (MinhaDirecao)
        {
            case Direcoes.Norte:
                DirecaoSelecionada("Norte");
                break;
            case Direcoes.Sul:
                DirecaoSelecionada("Sul");
                break;
            case Direcoes.Lest:
                DirecaoSelecionada("Lest");
                break;
            case Direcoes.Oeste:
                DirecaoSelecionada("Oeste");
                break;
        }
    }

    // Imprime o texto passado por par�metro em rela��o a Direcao Selecionada no inspetor unity.
    void DirecaoSelecionada(string text)
    {
        Debug.Log(text + " Selecionado!");
    }
}