using UnityEngine;

public class Propriedades : MonoBehaviour
{
    //Variável privada
    private float Speed;

    // Propriedades  set e get da variável Speed para que a mesma possa ser alterada e obtida de outras classes.
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
    //Forma simplificada de declaração de propriedades.
    public float ObterDefinirSpeed2 { get; set; }

}