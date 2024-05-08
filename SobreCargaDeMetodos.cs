using UnityEngine;

public class SobreCargaDeMetodos : MonoBehaviour
{
    // Variáveis privadas
    private string IdObj, NomeObj;
    private int QuantidadeObjetos;

    // Podemos criar varios métodos com o mesmo nome utilizando os conceitos de sobrecarga de métodos.
    // Porém para isso cada método precisa ter sua propria assinatura exclusiva!
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