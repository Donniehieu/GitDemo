using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public  Transform handTrans;

    public GameObject mainCharacter;

    private void OnEnable()
    {
        mainCharacter = FindObjectOfType<MainCharacter>().gameObject;

        handTrans= mainCharacter.GetComponentInChildren<Gun>().transform;

    }
}
