using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public GameObject Enemy;

    public float timer;

    public Vector3 pos;

    public int Score;

    public TMP_Text scoreText;
    public TMP_Text TimerText;

    public GameObject Menu;

    public float GameTimer;

    public bool IsDead;
    
    public AudioSource AudioSource;

    public AudioClip Expelosion;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
        scoreText.text = $"Score : {Score}";

        if (IsDead ==false)
        {
            timer += 1 * Time.deltaTime;
            if (timer >=1f)
            {
                MakeEnemy();
                timer = 0;
            }
            
            
            GameTimer += Time.deltaTime;
            TimerText.text = $"Timer : {Mathf.RoundToInt(GameTimer)}";
        }
        
    }


    public void MakeEnemy()
    {
        pos = new Vector3(Random.Range(-2.41f,2.38f),8,0);
        Instantiate(Enemy, pos,Quaternion.identity);
    }

    public void AddScore()
    {
        AudioSource.clip = Expelosion;
        AudioSource.Play();
        
        Score++;
    }

    public void ShowMenu()
    {
        AudioSource.clip = Expelosion;
        AudioSource.Play();
        IsDead = true;
        Menu.SetActive(true);
    }

    public void BTN_Again()
    {
        SceneManager.LoadScene(0);
    }
}
