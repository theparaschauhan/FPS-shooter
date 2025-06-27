using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]int startingHealth = 3, currentHealth;

    void Start()
    {
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Robot Destroyed !");
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }

}
