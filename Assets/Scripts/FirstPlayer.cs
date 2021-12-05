using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPlayer : MonoBehaviour
{
    [SerializeField] int money;
    // Start is called before the first frame update
    public void ButtonClick()
    {
        money++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
