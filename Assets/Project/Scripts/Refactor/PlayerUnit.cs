using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    [SerializeField]
    private Bullet _bulletPrefab = null;
    [SerializeField]
    private float _interval;
    [SerializeField]
    private float _speed;

    private float _reloadTime;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, vertical, 0F) * _speed * Time.deltaTime;

        if (Input.GetButton("Fire1") && _reloadTime < 0)
        {
            var bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            bullet.SetUp(Vector2.up);
            _reloadTime = _interval;
        }

        _reloadTime -= Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
