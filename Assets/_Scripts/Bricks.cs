using UnityEngine;

public class Bricks : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;
    [SerializeField] private float _lifeCycle = 12f;

    private void Start()
    {
        Destroy(gameObject, _lifeCycle);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
    }
}
