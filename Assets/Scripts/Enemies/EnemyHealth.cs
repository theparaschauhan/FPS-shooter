using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject robotExplosionVFX;
    [SerializeField] int startingHealth = 3;
    int currentHealth;
    GameManager gameManager;

    void Awake()
    {
        currentHealth = startingHealth;
    }
    
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.AdjustEnemiesLeft(1);
    }


    public void TakeDamage(int amount)
    {
        currentHealth = currentHealth - amount;// current health - damage amount 

        if (currentHealth <= 0)
        {
            gameManager.AdjustEnemiesLeft(-1);
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        Debug.Log("Robot Destroyed !");
    }
}