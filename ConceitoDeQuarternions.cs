using UnityEngine;

public class ConceitoDeQuarternions : MonoBehaviour
{
    public Transform Target;
    public Transform AnotherObject;

    //float TimeCount;

    private void Update()
    {
        // Vari�vel Pos armazena a posi��o de diferen�a
        //Vector3 Pos = Target.position - transform.position; 

        // o transform.rotation do objeto que esta este script recebe o Quaternion.LookRotation(Pos). fazendo com que o objeto ratacione para a mesma posi��o do objeto target
        //transform.rotation = Quaternion.LookRotation(Pos);

        // transform.rotation recebe o Quaternion.Slerp que por sua vez rotaciona o objeto Taget para a mesma rota��o do objeto AnotherObject em segundos
        //transform.rotation = Quaternion.Slerp(Target.rotation, AnotherObject.rotation, TimeCount); 
        //TimeCount += Time.deltaTime;

        // Define manualmente a rota��o do objeto ao qual este script est� anexado!
        transform.rotation = Quaternion.Euler(1, 1, 1);

    }
}