using UnityEngine;

public class DetectarColisoesOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter detecta colis�o de objetos que est�o definidos como IsTrigger ou seja objetos com o colisor Invisivel.
        if (other.gameObject.tag == "Vida")
        {
            Debug.Log("Voc� colotou uma vida!");
        }
    }
}