using UnityEngine;

public class AcessandoVariaveisPorMeioDePropriedades : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Propriedades PropriedadesTeste = new Propriedades();

        PropriedadesTeste.ObterDefinirSpeed = 10;
        Debug.Log(PropriedadesTeste);
    }
}