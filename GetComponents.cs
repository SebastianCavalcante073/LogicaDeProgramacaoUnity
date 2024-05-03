using UnityEngine;

public class GetComponents : MonoBehaviour
{
    // Declarando vari�veis do tipo Componentes
    Rigidbody rig;
    BoxCollider box;
    // Start � chamado ao dar play no jogo.
    void Start()
    {
        rig = GetComponent<Rigidbody>(); //Pega o Rigidbody do objeto ao qual o script est� anexado para que o messo possa ser manipulado atraves da variavel.
        rig.isKinematic = true; // Manipulando componente presente no objeto.

        box = GetComponent<BoxCollider>();  // Pega o BoxCollider do objeto ao qual o script est� anexado para que o messo possa ser manipulado atraves da variavel.
        box.isTrigger = true; // Manipulando o componente atraves da variavel. definindo o colisor como invisivel.
    }
}