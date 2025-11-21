using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _flapForce = 10f;
    private const int leftButton = 0;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(leftButton))
        {
            Flap();
        }
    }

    private void Flap()
    {
        _rb.linearVelocityY = 0f;
        _rb.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse);
    }


}
