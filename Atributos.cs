using UnityEngine;

public class Atributos : MonoBehaviour
{
    // -- Exemplos de Atributos Organizadores na Unity.  -- \\

    /* Atributos
        Header, Cria um cabeçalho no inspetor.
        SerializeField, Torna visivel uma variável privada no inspetor.
        Tooltip, Cria um texto sobre a variável.
        Space, Insere um espaço entre as variáveis no inspetor.
        TextArea, Define um campo de texto maior para variáveis.
        Range, Define um valor minimo e maximo de uma variável.

        Outros atributos podem ser consultados na documentação Unity.
        https://docs.unity3d.com/Manual/Attributes.html
    */

    [Header("Variáveis Privadas")]
    [SerializeField]
    [Tooltip("Define a vida")] private int Vida;

    [Space]
    [Header("Variáveis Publicas")]
    [Tooltip("Define o dano")] public float Dano;
    [Tooltip("Define a velocidade")] public float Velocidade;

    [Space]
    [Header("Outras Variáveis")]
    [Tooltip("Define o nome do player")] public string PlayerName;

    [Space]
    [Header("Descrição do player")]
    [Space]
    [Tooltip("Define a descrição do player! ")][TextArea] public string Descricao;

    [Tooltip("Defini qual skin padrão do player ")][Range(1, 10)] public int PlayerSkins;
}