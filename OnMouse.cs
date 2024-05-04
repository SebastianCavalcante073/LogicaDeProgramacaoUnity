using UnityEngine;

public class OnMouse : MonoBehaviour
{
    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp é chamado quando o usuário libera o botão do mouse quando o mouse está sobre um elemento GUI ou objeto com colisor");
    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown é chamado quando o usuário preciona o botão do mouse quando estiver sobre um elemento GUI ou objeto com colisor!");
    }

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter é chamado quando o mouse for inserido sobre um elemento GUI ou sobre um objeto com colisor");
    }

    private void OnMouseExit()
    {
        Debug.Log("OnMouseExit é chamado quando o mouse está sobre um elememto GUI ou objeto com colisor e é removido em seguida!");
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver é chamado a cada frame enquando o mouse está sobre um elemento GUI ou sobre um objeto com colisor!");
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag é chamado a cada frame enquando o mouse está sendo precionado sobre um elemento GUI ou sobre um objeto com colisor é como o efeito arrastar do mouse");
    }
}