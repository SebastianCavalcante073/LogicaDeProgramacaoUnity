using UnityEngine;

public class Propriedades : MonoBehaviour
{
    //Vari�vel privada
    private float Speed;

    // Propriedades  set e get da vari�vel Speed para que a mesma possa ser alterada e obtida de outras classes.
    public float ObterDefinirSpeed
    {
        get
        {
            return Speed;
        }
        set
        {
            Speed = value;
        }
    }
    //Forma simplificada de declara��o de propriedades.
    public float ObterDefinirSpeed2 { get; set; }

}