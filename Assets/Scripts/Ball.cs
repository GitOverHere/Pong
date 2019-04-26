using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float Speed = 2f;
    public bool PlayerServes = true,Touched=false;
    public Text AI_Score, Player_Score;
    int AI=0, Player=0;
    public int Rounds=10;
    private Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
  PlayerServes=true;
        ball.AddComponent<Rigidbody2D>();
    }

    IEnumerator wait(int sec) {
        yield return new WaitForSeconds(sec);
    }

    void Awake() {
        StartCoroutine(wait(3));
    }


    // Update is called once per frame
    void Update()
    {


       
            ball.transform.Translate(Vector2.right*Speed*Time.deltaTime);

        


        if (transform.position.y > 2) {
            UpdateAIScore();

        }


        if(transform.position.y < -2)
        {
            UpdatePlayerScore();

        }

        




    }

    void UpdateAIScore() {
        AI++;
        string s = AI.ToString();
        AI_Score.text = s;


    }

    void UpdatePlayerScore() {
       Player++;
        string s = Player.ToString();
        Player_Score.text = s;


    }

    void GameOverCheck() {

        

            if (AI > Rounds) {

               
            }

        if (Player > Rounds) {

        }
            


    }





}
