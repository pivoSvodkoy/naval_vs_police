using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] int scoreFirst, scoreSecond;
    [SerializeField] double coinFirst, coinSecond;
    [SerializeField] GameObject wins1;
    [SerializeField] GameObject wins2;
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
        wins1.SetActive(false);
        wins2.SetActive(false);
        InvokeRepeating("TimeStartGame", 2.0f, 3f);
    }
    void Update()
    {
        if((scoreFirst - scoreSecond) >= 50)
        {
            //FIRST PLAYER WIN
            wins1.SetActive(true);
        }
        if((scoreSecond - scoreFirst) >= 50)
        {
            //SECOND PLAYER WIN
            wins2.SetActive(true);
        }
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
        
    }

}
