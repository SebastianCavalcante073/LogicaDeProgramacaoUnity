using UnityEngine;

public class DetectarColisoesOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter detecta colisão de objetos que estão definidos como IsTrigger ou seja objetos com o colisor Invisivel.
        if (other.gameObject.tag == "Vida")
        {
            Debug.Log("Você colotou uma vida!");
        }
    }
}