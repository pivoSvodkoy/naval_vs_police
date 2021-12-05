using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWeapon : MonoBehaviour
{
    public void CreateWeaponFirstPlayer(GameObject objPrefab)
    {
        Instantiate(objPrefab, objPrefab.transform.position, objPrefab.transform.rotation);
    }

    public void CreateWeaponSecondPlayer(GameObject objPrefab)
    {
        Instantiate(objPrefab, objPrefab.transform.position, objPrefab.transform.rotation);
    }
}
