using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text MyText;
    private int score;

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
   
        MyText.text = "" + score;
 
    }
 
 
    void OnTriggerEnter2D(Collider2D coll) 
    {

        if (coll.tag == "hijaiyah")
        {
            score += 1;
            Destroy(coll.gameObject);
            MyText.text = "" + score;
            
        }
        
        if (coll.tag == "box")
        {
            score -= 1;
            Destroy(coll.gameObject);
            MyText.text = "" + score;
            
        }
 
    }
}
