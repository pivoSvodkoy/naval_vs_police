using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] int scoreFirst;
    [SerializeField] int scoreSecond;

    public void ButtonClickFirstPlayer()
    {
        scoreFirst++;
    }

    public void ButtonClickSecondPlayer()
    {
        scoreSecond++;
    }

    void Update()
    {
        
    }
}
