using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] int scoreFirst;
    [SerializeField] int scoreSecond;
    [SerializeField] double coinFirst;
    [SerializeField] double coinSecond;

    public void ButtonClickFirstPlayer()
    {
        scoreFirst++;
    }

    public void ButtonClickSecondPlayer()
    {
        scoreSecond++;
    }
    void Start()
    {
        InvokeRepeating("TimeStartGame", 2.0f, 3f);
    }
    void Update()
    {
        
    }
    public void TimeStartGame()
    {
        if((scoreFirst - scoreSecond) >= 10)
        {
            coinFirst += 0.1;
        }
        if((scoreSecond - scoreFirst) >= 10)
        {
            coinSecond += 0.1;
        }
        if((scoreFirst - scoreSecond) >= 1000)
        {
            //FIRST PLAYER WIN
        }
        if((scoreSecond - scoreFirst) >= 1000)
        {
            //SECOND PLAYER WIN
        }
    }

}
