using UnityEngine;

public class SobreCargaDeMetodos : MonoBehaviour
{
    // Vari�veis privadas
    private string IdObj, NomeObj;
    private int QuantidadeObjetos;

    // Podemos criar varios m�todos com o mesmo nome utilizando os conceitos de sobrecarga de m�todos.
    // Por�m para isso cada m�todo precisa ter sua propria assinatura exclusiva!
    public void CaixaMisteriosa(string idObj, string nomeObj)
    {
        IdObj = idObj;
        NomeObj = nomeObj;
    }

    public void CaixaMisteriosa(int quantidadeObjetos)
    {
        QuantidadeObjetos = quantidadeObjetos;
    }
}