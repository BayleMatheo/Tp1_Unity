using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;

    private float speed = 4f;
    private Vector2 movedirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        movedirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector3(movedirection.x,movedirection.y, 0f) * speed;
    }
}

