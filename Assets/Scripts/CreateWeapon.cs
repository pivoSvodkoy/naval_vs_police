using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWeapon : MonoBehaviour
{
    public void CreateObj(GameObject objPrefab)
    {
        var weapon = Instantiate(objPrefab, objPrefab.transform.position, objPrefab.transform.rotation);
    }
}
