using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class movimentoPersonagem : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float jumpForce = 10f;

    private bool isOnFloor = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && isOnFloor != false)
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOnFloor = false;

        Debug.Log("Saiu do chão.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnFloor = true;

        Debug.Log("Voltou pro chão.");
    }
}
