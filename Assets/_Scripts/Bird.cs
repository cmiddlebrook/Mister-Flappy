using UnityEngine;

public class Bird : MonoBehaviour
{
    private const int LEFT_BUTTON = 0;

    [SerializeField] private float _flapForce = 10f;
    [SerializeField] private float _rotation = 1.5f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(LEFT_BUTTON))
        {
            Flap();
        }

        _rb.MoveRotation(_rb.linearVelocityY * _rotation);
    }

    private void Flap()
    {
        _rb.linearVelocityY = 0f;
        _rb.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse);
    }


}
