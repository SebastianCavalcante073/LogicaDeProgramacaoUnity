using UnityEngine;

public class GetKey : MonoBehaviour
{
    private void Update()
    {
        // Capturando inputs do teclado!

        // Input.GetKey retorna true enquanto a tecla A está sendo precionada.
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tecla A está sento mantida precionada!");
        }

        // Input.GetKeyDown retorna true quando a tecla B é precionada uma vez.
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Tecla B foi precionada!");
        }

        // Input.GetKeyUp retorna true quando a tecla C é precionda e solta.
        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Tecla C foi precionada e solta!");
        }
    }
}