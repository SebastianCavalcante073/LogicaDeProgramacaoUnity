using UnityEngine;

public class OnMouse : MonoBehaviour
{
    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp � chamado quando o usu�rio libera o bot�o do mouse quando o mouse est� sobre um elemento GUI ou objeto com colisor");
    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown � chamado quando o usu�rio preciona o bot�o do mouse quando estiver sobre um elemento GUI ou objeto com colisor!");
    }

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter � chamado quando o mouse for inserido sobre um elemento GUI ou sobre um objeto com colisor");
    }

    private void OnMouseExit()
    {
        Debug.Log("OnMouseExit � chamado quando o mouse est� sobre um elememto GUI ou objeto com colisor e � removido em seguida!");
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver � chamado a cada frame enquando o mouse est� sobre um elemento GUI ou sobre um objeto com colisor!");
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag � chamado a cada frame enquando o mouse est� sendo precionado sobre um elemento GUI ou sobre um objeto com colisor � como o efeito arrastar do mouse");
    }
}