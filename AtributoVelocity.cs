using UnityEngine;

public class AtributoVelocity : MonoBehaviour
{
    /* Vari�veis controladores de velocidade e for�a do pulo.
     */
    public float Velocidade, ForcaPulo;

    // Vari�vel refer�ncia  Rig do tipo Rigidbody 
    private Rigidbody Rig;

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody>(); // Pega o componente Rigidbody anexado ao objeto � o refer�ncia a vari�vel Rig
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarCubo(); // Chama o m�todo que faz movimentar o objeto.
    }

    void MovimentarCubo()
    {
        // Movimenta o objeto no eixo x, mantendo sua posi��o original nos eixo y e z * o Tempo em segundos.
        Rig.velocity = new Vector3(Velocidade, Rig.velocity.y, Rig.velocity.z * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            // Movimenta o objeto somente no eixo y, mantendo sua posi��o original nos eixo x e z * o tempo em segundos.
            Rig.velocity = new Vector3(Rig.velocity.x, ForcaPulo, Rig.velocity.z * Time.deltaTime);
        }
    }
}