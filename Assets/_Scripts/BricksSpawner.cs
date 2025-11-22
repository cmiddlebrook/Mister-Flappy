using UnityEngine;

public class BricksSpawner : MonoBehaviour
{
    [SerializeField] private Bricks _bricksPrefab;
    [SerializeField] private float _spawnInterval = 3f;
    [SerializeField] private float _minY = 0f;
    [SerializeField] private float _maxY = 3f;


    private float _spawnTimer;


    private void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0f)
        {
            SpawnBricks();
            _spawnTimer = _spawnInterval;
        }

    }

    private void SpawnBricks()
    {
        Vector2 spawnPosition = transform.position;
        spawnPosition.y = Random.Range(_minY, _maxY);
        Instantiate(_bricksPrefab, spawnPosition, Quaternion.identity);

    }
}
