using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody2D rb;
    public Sprite[] sprites;
    public SpriteRenderer render;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pos = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
            render.sprite = sprites[1];
            render.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
            render.sprite = sprites[2];
            render.flipX = false;

        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
            render.sprite = sprites[0];
            render.flipX = false;

        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
            render.sprite = sprites[2];
            render.flipX = true;


        }
        transform.position = pos;
    }
}
