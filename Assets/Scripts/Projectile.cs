using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField][Range (0f, 10f)] float projectileSpeed = 3f;
    [SerializeField] float rotationSpeed = 300f;
    [SerializeField] int projectileDamage = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -(Time.deltaTime * rotationSpeed));
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health health = other.GetComponent<Health>();
        Attacker attacker = other.GetComponent<Attacker>();

        if (health && attacker)
        {
            health.DealDamage(projectileDamage);
            Destroy(gameObject);
        }
    }
}
