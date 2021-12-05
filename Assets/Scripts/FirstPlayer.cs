using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPlayer : MonoBehaviour
{
    [SerializeField] int moneyFirst;
    [SerializeField] int moneySecond;
    // Start is called before the first frame update
    public void ButtonClick()
    {
        moneyFirst++;
    }

    public void ButtonClickSecondPlayer()
    {
        moneySecond++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
