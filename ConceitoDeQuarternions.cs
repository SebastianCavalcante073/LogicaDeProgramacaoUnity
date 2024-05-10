using UnityEngine;

public class ConceitoDeQuarternions : MonoBehaviour
{
    public Transform Target;
    public Transform AnotherObject;

    //float TimeCount;

    private void Update()
    {
        // Variável Pos armazena a posição de diferença
        //Vector3 Pos = Target.position - transform.position; 

        // o transform.rotation do objeto que esta este script recebe o Quaternion.LookRotation(Pos). fazendo com que o objeto ratacione para a mesma posição do objeto target
        //transform.rotation = Quaternion.LookRotation(Pos);

        // transform.rotation recebe o Quaternion.Slerp que por sua vez rotaciona o objeto Taget para a mesma rotação do objeto AnotherObject em segundos
        //transform.rotation = Quaternion.Slerp(Target.rotation, AnotherObject.rotation, TimeCount); 
        //TimeCount += Time.deltaTime;

        // Define manualmente a rotação do objeto ao qual este script está anexado!
        transform.rotation = Quaternion.Euler(1, 1, 1);

    }
}