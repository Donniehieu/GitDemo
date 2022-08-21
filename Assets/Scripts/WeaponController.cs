using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
   
    public GunAbilities gun;
    public CharacterController characterController;
    public List<GameObject> gunList;
    [SerializeField] GameObject pistolGun;
    [SerializeField] GameObject rifleGun; 
  
    public int i;

    private void Start()
    {
        characterController = FindObjectOfType<CharacterController>();

        SpawnWeapon(characterController.handTrans);

    }
    public void SwapWeapon()
    {  
        if (i < gunList.Count)
        {
            i++;
        }
        if(i>= gunList.Count)
        {
            i = 0;
        }
        
        
        ShowWeapon(i);
        gun = characterController.handTrans.GetChild(i).GetComponent<GunAbilities>();
        Debug.Log("Current Gun is: " + gun);
    }
    private void ShowWeapon(int id)
    {
        for (int k = 0; k < characterController.handTrans.childCount; k++)
        {
            characterController.handTrans.GetChild(k).gameObject.SetActive(false);
        }
      characterController.handTrans.GetChild(id).gameObject.SetActive(true);
      
    }

    private void SpawnWeapon(Transform spawnTrans)
    {
        for (int k = 0; k < gunList.Count; k++)
        {
            GameObject obj=   Instantiate(gunList[k], spawnTrans.position, Quaternion.Euler(90,0,0));
            obj.transform.SetParent(spawnTrans);            
        }
       
    }
   
   
   public void Shoot()
    {
        characterController.handTrans.GetComponentInChildren<GunAbilities>().Shoot();
    }
}
