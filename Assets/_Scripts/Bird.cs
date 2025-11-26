using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    private const int LEFT_BUTTON = 0;

    [SerializeField] private float _flapForce = 10f;
    [SerializeField] private float _rotation = 1.5f;
    [SerializeField] private float _maxHeight = 4f;

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene();
        }

        _rb.MoveRotation(_rb.linearVelocityY * _rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
    }

    private void Flap()
    {
        if (transform.position.y >= _maxHeight) return;

        _rb.linearVelocityY = 0f;
        _rb.AddForce(Vector2.up * _flapForce, ForceMode2D.Impulse);
    }

    private void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
