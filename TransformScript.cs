using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public float Velocidade; // Variável de controle de velocidade de movimento do objeto.
    public float Rotacao;    // Variável de controle de rotação do objeto.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // Verifica se está sendo mantido precionado a tecla W do teclado.
        {
            transform.Translate(Vector3.forward * Velocidade * Time.deltaTime); // Incrementa em +1 no eixo z na velocidade * Time.deltaTime em segundos.
        }

        if (Input.GetKey(KeyCode.S))// Verifica se está sendo mantido precionado a tecla S do teclado.
        {
            transform.Translate(Vector3.back * Velocidade * Time.deltaTime); // Incrementa em -1 no eixo z na velocidade * Time.deltaTime em segundos.
        }

        if (Input.GetKey(KeyCode.D))// Verifica se está sendo mantido precionado a tecla D do teclado.
        {
            transform.Rotate(Vector3.up * Rotacao * Time.deltaTime); // Incrementa em +1 no eixo y do componente Rotation * a velocidade * Time.deltaTime em segundos.
        }

        if (Input.GetKey(KeyCode.A))// Verifica se está sendo mantido precionado a tecla A do teclado.
        {
            transform.Rotate(Vector3.down * Rotacao * Time.deltaTime); // Decrementa em -1 no eixo y do componente Rotation * a velocidade * Time.deltaTime em segundos.
        }
    }
}