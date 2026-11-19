using Unity.Mathematics.Geometry;
using Unity.VisualScripting;
using UnityEngine;

public class movimentoCenario : MonoBehaviour
{
    [Header("Velocidade de Movimento")]
    public float speed = 3.5f;

    [Header("Configurações dos Blocos")]
    public Transform objetoPai;
    public GameObject[] objetoPrefab;
    public float distanciaX = 20.045f;

    private float _contador;
    public float intervalo = 5f;

    void Start()
    {
        gerarBloco();
    }

    // Update is called once per frame
    void Update()
    {
        _contador += Time.deltaTime;
        if (_contador >= intervalo)
        {
            Destroy(transform.GetChild(0).gameObject);

            gerarBloco();
            _contador -= intervalo;
        }
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void gerarBloco()
    {
        int variacao = Random.Range(0, objetoPrefab.Length);

        Vector3 posicao = transform.position + new Vector3(distanciaX, -4.1049f, 0f);
        distanciaX += 20.045f;

        // Cria apenas um bloco dentro do objetoPai
        Instantiate(objetoPrefab[variacao], posicao, Quaternion.identity, objetoPai);

    }
}
