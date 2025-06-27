using StarterAssets;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    StarterAssetsInputs starterAssetsInputs;
    [SerializeField]EnemyHealth enemyHealth;

    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }

    void Update()
    {
        if (starterAssetsInputs.shoot)
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name == "Robot")
                {
                    enemyHealth.TakeDamage(1);//robot health -1
                }
                starterAssetsInputs.ShootInput(false);
            }      
        }
    }
}
