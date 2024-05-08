using UnityEngine;

public class AtributoVelocity : MonoBehaviour
{
    /* Variáveis controladores de velocidade e força do pulo.
     */
    public float Velocidade, ForcaPulo;

    // Variável referência  Rig do tipo Rigidbody 
    private Rigidbody Rig;

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody>(); // Pega o componente Rigidbody anexado ao objeto é o referência a variável Rig
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarCubo(); // Chama o método que faz movimentar o objeto.
    }

    void MovimentarCubo()
    {
        // Movimenta o objeto no eixo x, mantendo sua posição original nos eixo y e z * o Tempo em segundos.
        Rig.velocity = new Vector3(Velocidade, Rig.velocity.y, Rig.velocity.z * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            // Movimenta o objeto somente no eixo y, mantendo sua posição original nos eixo x e z * o tempo em segundos.
            Rig.velocity = new Vector3(Rig.velocity.x, ForcaPulo, Rig.velocity.z * Time.deltaTime);
        }
    }
}