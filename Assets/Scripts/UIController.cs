using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public WeaponController weaponController;


    private void Start()
    {
        weaponController = FindObjectOfType<WeaponController>();
    }

    public void Shoot()
    {
        weaponController.Shoot();
    }
    public void SwapWeapon()
    {
        weaponController.SwapWeapon();
    }
}
