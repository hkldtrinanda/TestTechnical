using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text MyText;
    private int score;
    public GameObject gameOver;


        [Header("Collider kapal")] 
    public List<Collider2D> coll;

    // Use this for initialization
    void Start () 
    {
        score = 0;
        MyText.text = "";
    }

    // Update is called once per frame
    void Update () 
    {
        if (score>=1000)
        {
            MyText.text = "You Win";
            gameOver.SetActive(true);
        }
        
        MyText.text = "" + score;
        PlayerPrefs.SetInt("Score", score);
    }
 
 
    void OnTriggerEnter2D(Collider2D coll) 
    {

        if (coll.tag == "hijaiyah")
        {
            score += 100;
            Destroy(coll.gameObject);
            MyText.text = "Score" + score;

            
        }
        
        if (coll.tag == "box")
        {
            score -= 100;
            Destroy(coll.gameObject);
            MyText.text = "Score" + score;


            
        }
 
    }
    
    public void Reset()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        print("Game saved!");
    }
}
