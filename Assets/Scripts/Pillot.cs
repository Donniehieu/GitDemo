using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillot : CharacterController 
{
    private void Start()
    {
        mainCharacter = FindObjectOfType<MainCharacter>().gameObject;

        handTrans = mainCharacter.GetComponentInChildren<Gun>().transform;
    }
}
