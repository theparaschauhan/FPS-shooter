using UnityEngine;

[CreateAssetMenu(fileName = "WeaponOS", menuName = "ScriptableObjects/WeaponSO")]
public class WeaponOS : ScriptableObject
{
    public int Damage = 1;
    public float FireRate = .5f;

}
