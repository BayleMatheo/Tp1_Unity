using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    private bool _move;
    private float _turn;
    public float _speed = 1.0f;
    public float _turnSpeed = 1.0f;
    // private Vector2 movedirection;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        _move = Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow);

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow)) {
            _turn = 1.0f;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            _turn = -1.0f;
        }else{
            _turn = 0.0f;
        }
        // movedirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }


    private void FixedUpdate()
    {
        if (_move)
        {
            _rb.AddForce(this.transform.up * this._speed);
        }

        if (_turn != 0.0f)
        {
            _rb.AddTorque(_turn * this._turnSpeed );
        }
        
        // _rb.velocity = new Vector3(movedirection.x,movedirection.y, 0f) * speed;
    }
}

