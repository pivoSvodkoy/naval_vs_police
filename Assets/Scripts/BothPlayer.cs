using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] 
    private double coinFirst;
    [SerializeField] 
    private double coinSecond;
    [SerializeField] 
    private int scoreFirst;
    [SerializeField] 
    private int scoreSecond;
    [SerializeField]
    private GameObject objPrefab;
    private CreateWeapon crW = new CreateWeapon();


    public void ButtonClickFirstPlayer()
    {
        crW.CreateObj(objPrefab);
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
