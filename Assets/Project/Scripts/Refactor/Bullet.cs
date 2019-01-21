using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    [SerializeField]
    private float _speed = 0F;

    public void SetUp(Vector2 direction)
    {
        _direction = direction;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _direction.normalized * _speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        Destroy(gameObject);
    }
}
