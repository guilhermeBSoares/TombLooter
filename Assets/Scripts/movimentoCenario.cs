using Unity.VisualScripting;
using UnityEngine;

public class movimentoCenario : MonoBehaviour
{
    [Header("Velocidade de Movimento")]
    public float speed = 3.5f;

    public GameObject objetoPrefab; // Arraste o prefab do objeto aqui
    public int quantidade = 5;      // Quantas vezes ele será criado
    public float espacamento = 1f;  // Distância entre o centro de um objeto e o próximo

    void Start()
    {
        GerarFila();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void GerarFila()
    {
        if (objetoPrefab == null) return;

        for (int i = 0; i < quantidade; i++)
        {
            Vector2 posicao = transform.position + new Vector3(i * espacamento, -4.1049f, 0f);

            // Cria o objeto na posição calculada
            Instantiate(objetoPrefab, posicao, Quaternion.identity);
        }
    }
}
