using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "ScriptableObjects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public GameObject weaponPrefab;
    public int Damage = 1;
    public float FireRate = .5f;
    public GameObject hitVFXPrefab;
    public bool IsAutomatic = false;
    public bool CanZoom = false;
    public float ZoomAmount = 10f;
}
