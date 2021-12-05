using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject objPrefab;
    public Animation animation;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateObj();
        }
    }

    public void CreateObj()
    {
        var weapon = Instantiate(objPrefab, transform.position, transform.rotation);
    }
}
