using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] List <GameObject> SWAT;
    [SerializeField] List <GameObject> GaysAndAnime;
    [SerializeField] GameObject wins1;
    [SerializeField] GameObject wins2;
    [SerializeField] 
    private double coinFirst;
    [SerializeField] 
    private double coinSecond;
    [SerializeField] 
    private int scoreFirst;
    [SerializeField] 
    private int scoreSecond;
    [SerializeField]
    private GameObject prefabWeaponFirstPlayer;
    [SerializeField]
    private GameObject prefabWeaponSecondPlayer;
    private CreateWeapon crW = new CreateWeapon();
    [SerializeField]
    private Image image;
    public Text moneyFirstPlayer;
    public Text moneySecondPlayer;
    private int PointPerClick1 = 1;
    private int PointPerClick2 = 1;
    [SerializeField] GameObject GameField1;
    [SerializeField] GameObject GameField2;
    public Text scoreFirstPlayer;
    public Text scoreSecondPlayer;
    [SerializeField] GameObject Draw;

    public void ButtonClickFirstPlayer()
    {
        crW.CreateWeaponFirstPlayer(prefabWeaponFirstPlayer);
        image.fillAmount += 0.01f;
        scoreFirst += PointPerClick1;
    }

    public void ButtonClickSecondPlayer()
    {
        crW.CreateWeaponSecondPlayer(prefabWeaponSecondPlayer);
        image.fillAmount -= 0.01f;
        scoreSecond += PointPerClick2;
    }
    void Start()
    {
        Draw.SetActive(false);
        wins1.SetActive(false);
        wins2.SetActive(false);
        InvokeRepeating("TimeStartGame", 1.0f, 1f);
        Invoke("Draw1", 600f);
        for(int i = 0; i< SWAT.Count; i++)
        {
            SWAT[i].SetActive(false);
            GaysAndAnime[i].SetActive(false);
        }
        
    }
    void Update()
    {
        if((scoreFirst - scoreSecond) >= 500)
        {
            //FIRST PLAYER WIN
            wins1.SetActive(true);
            GameField1.SetActive(false);
            GameField2.SetActive(false);

        }
        if((scoreSecond - scoreFirst) >= 500)
        {
            //SECOND PLAYER WIN
            wins2.SetActive(true);
            GameField1.SetActive(false);
            GameField2.SetActive(false);
        }
        int returnTextFirst = (int)(coinFirst + 0.1);
        moneyFirstPlayer.text = returnTextFirst.ToString();
        int returnTextSecond = (int)(coinSecond + 0.1);
        moneySecondPlayer.text = returnTextSecond.ToString();

        scoreFirstPlayer.text = scoreFirst.ToString();
        scoreSecondPlayer.text = scoreSecond.ToString();
        if(scoreFirst >= 50)
        {
            SWAT[0].SetActive(true);
            PointPerClick1 = 2;
        }
        if(scoreFirst >= 200)
        {
            SWAT[1].SetActive(true);
            PointPerClick1 = 3;
        }
        if(scoreFirst >= 1000)
        {
            SWAT[2].SetActive(true);
            PointPerClick1 = 4;
        }
        if(scoreFirst >= 5000)
        {
            SWAT[3].SetActive(true);
            PointPerClick1 = 5;
        }
        if(scoreSecond >= 50)
        {
            GaysAndAnime[0].SetActive(true);
            PointPerClick2 = 2;
        }
        if(scoreSecond >= 200)
        {
            GaysAndAnime[1].SetActive(true);
            PointPerClick2 = 3;
        }
        if(scoreSecond >= 1000)
        {
            GaysAndAnime[2].SetActive(true);
            PointPerClick2 = 4;
        }
        if(scoreSecond >= 5000)
        {
            GaysAndAnime[3].SetActive(true);
            PointPerClick2 = 5;
        }
    }
    public void TimeStartGame()
    {
        if((scoreFirst - scoreSecond) >= 10)
        {
            coinFirst += 1;
        }
        if((scoreSecond - scoreFirst) >= 10)
        {
            coinSecond += 1;
        }
    }
    public void Draw1()
    {
        Draw.SetActive(true);
        GameField1.SetActive(false);
        GameField2.SetActive(false);
    }
}
