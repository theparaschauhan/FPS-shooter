using UnityEngine;

public class AmmoPickup : Pickup
{
    [SerializeField] int ammoAmount;
    protected override void OnPickup(ActiveWeapon activeWeapon)
    {
        // activeWeapon.AdjustAmmo(ammoAmount);
        activeWeapon.SetInfiniteAmmo();
    }
}
