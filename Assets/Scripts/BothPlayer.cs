using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] GameObject wins1;
    [SerializeField] List <GameObject> SWAT;
    [SerializeField] List <GameObject> GaysAndAnime;
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
    public Image imageFirst;
    public Image imageSecond;
    public Button btnFirst;
    public Button btnSecond;


    public void BuffClickFirst()
    {
        if (coinFirst >= 1)
        {
            imageFirst.color = new Color32(123, 123, 123, 255);
            coinFirst -= 1;
            StartCoroutine(PointPerClickUp(5));
        }
        return;
    }
    
    IEnumerator PointPerClickUp(float t)
    {
        PointPerClick1 += 5;
        yield return new WaitForSeconds(t);
        PointPerClick1 -= 5;
    }

    IEnumerator PointPerClickUp2(float t)
    {
        PointPerClick2 += 5;
        yield return new WaitForSeconds(t);
        PointPerClick2 -= 5;
    }
    public void BuffClickSecond()
    {
        if(coinSecond >=1)
        {
            imageSecond.color = new Color32(123, 123, 123, 255);
            coinSecond -= 1;
            StartCoroutine(PointPerClickUp2(5));
        }
        return;
    }

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
        wins1.SetActive(false);
        wins2.SetActive(false);
        InvokeRepeating("TimeStartGame", 2.0f, 3f);
        for(int i = 0; i< SWAT.Count; i++)
        {
            SWAT[i].SetActive(false);
            GaysAndAnime[i].SetActive(false);
        }
        
    }
    void Update()
    {
        btnFirst.interactable = false;
        if (coinFirst >=1)
        {
            btnFirst.interactable = true;
            imageFirst.color = new Color32(0, 255, 0, 255);
        }
        btnSecond.interactable = false;
        if (coinSecond >= 1)
        {
            btnSecond.interactable = true;
            imageSecond.color = new Color32(0, 255, 0, 255);
        }

        if ((scoreFirst - scoreSecond) >= 50)
        {
            //FIRST PLAYER WIN
            wins1.SetActive(true);
            GameField1.SetActive(false);

        }
        if((scoreSecond - scoreFirst) >= 50)
        {
            //SECOND PLAYER WIN
            wins2.SetActive(true);
            GameField2.SetActive(false);
        }
        int returnTextFirst = (int)(coinFirst + 0.1);
        moneyFirstPlayer.text = returnTextFirst.ToString();
        int returnTextSecond = (int)(coinSecond + 0.1);
        moneySecondPlayer.text = returnTextSecond.ToString();

        scoreFirstPlayer.text = scoreFirst.ToString();
        scoreSecondPlayer.text = scoreSecond.ToString();
        if(scoreFirst >= 20)
        {
            SWAT[0].SetActive(true);
            PointPerClick1 = 2;
        }
        if(scoreFirst >= 30)
        {
            SWAT[1].SetActive(true);
            PointPerClick1 = 3;
        }
        if(scoreFirst >= 40)
        {
            SWAT[2].SetActive(true);
            PointPerClick1 = 4;
        }
        if(scoreFirst >= 50)
        {
            SWAT[3].SetActive(true);
            PointPerClick1 = 5;
        }
        if(scoreSecond >= 20)
        {
            GaysAndAnime[0].SetActive(true);
            PointPerClick2 = 2;
        }
        if(scoreSecond >= 30)
        {
            GaysAndAnime[1].SetActive(true);
            PointPerClick2 = 3;
        }
        if(scoreSecond >= 40)
        {
            GaysAndAnime[2].SetActive(true);
            PointPerClick2 = 4;
        }
        if(scoreSecond >= 50)
        {
            GaysAndAnime[3].SetActive(true);
            PointPerClick2 = 5;
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
