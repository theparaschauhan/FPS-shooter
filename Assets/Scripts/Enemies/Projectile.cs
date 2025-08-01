using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 30f;
    [SerializeField] GameObject projectileHitVFX;

    Rigidbody rb;
    int damage;

    void Awake() {
        rb = GetComponent<Rigidbody>();    
    }

    void Start() {
        rb.linearVelocity = transform.forward * speed;    
    }

    public void Init(int damage)
    {
        this.damage = damage;
    }


    void OnTriggerEnter(Collider other) {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        playerHealth?.TakeDamage(damage);
        Instantiate(projectileHitVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);    
    } 
}
