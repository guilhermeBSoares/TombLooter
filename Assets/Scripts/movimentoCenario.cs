using UnityEngine;

public class movimentoCenario : MonoBehaviour
{
    [Header("Velocidade de Movimento")]
    public float speed = 3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
