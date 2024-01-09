using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSquare : MonoBehaviour
{
    public float speed = 5.0f;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        if (movement != Vector2.zero)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }

        transform.position = (Vector2)transform.position + movement * speed * Time.deltaTime;
    }
}