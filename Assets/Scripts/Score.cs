using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text mathText;
    public float time; 
    public static int score;
    public GameObject prefab;
    private GameObject[] clons = new GameObject[3];


    private int scoreRight = 10;
    private float timeStart;
    private string textMath;
    private int rightAnswer;
    private int loseAnswer1;
    private int loseAnswer2;

    public int a;
    public int b;
    public int c;
    private int[] mass = new int[120];
    public bool bol;
    public int i;

    void Start() {
        if(PlayerPrefs.HasKey("score")) {
            score = PlayerPrefs.GetInt("score");
            score = 0;
        }
        timeStart = time;

        var rand = new System.Random();
        for(int i = 0; i < 120; i++) {
            mass[i] = rand.Next(1, 4);
        }
           
    }

    
   void Update(){
    PlayerPrefs.SetInt("score", score);
    time -= Time.deltaTime;
    scoreText.text = score.ToString();
    if(time <= 0) {
        score += 1;
        time = timeStart;   
    }
      
         while (bol == true)
                {
                    if(mass[i] == 1 || mass[i] == 2 || mass[i] == 3) {
                        a = mass[i];
                        if(a == 1) {
                            i++;
                            if(mass[i] == 2 || mass[i] == 3) {
                                
                                b = mass[i];
                                if(b == 2) {
                                    c = 3;

                                    clons[0].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=rightAnswer.ToString();
                                    clons[1].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer1.ToString();
                                    clons[1].AddComponent<CircleCollider2D>();
                                  
                                    clons[2].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer2.ToString();
                                    clons[2].AddComponent<CircleCollider2D>();
                           

                                    bol = false;
                                } else if(b == 3) {
                                    c = 2;

                                    clons[0].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=rightAnswer.ToString();
                                    clons[1].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer2.ToString();
                                    clons[1].AddComponent<CircleCollider2D>();
                                   
                                    clons[2].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer1.ToString();
                                    clons[2].AddComponent<CircleCollider2D>();
                             
                                    bol = false;
                                }
                            }
                        } else if(a == 2) {
                            i++;
                            if(mass[i] == 1 || mass[i] == 3) {
                                b = mass[i];
                                if(b == 1) {
                                    c = 3; 

                                    clons[0].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer1.ToString();
                                    clons[0].AddComponent<CircleCollider2D>();
                                 
                                    clons[1].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=rightAnswer.ToString();
                                    clons[2].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer2.ToString();
                                    clons[2].AddComponent<CircleCollider2D>();
                              
                                    bol = false;
                                } else if(b == 3) {
                                    c = 1;

                                    clons[0].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer1.ToString();
                                    clons[0].AddComponent<CircleCollider2D>();
                           
                                    clons[1].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer2.ToString();
                                   clons[1].AddComponent<CircleCollider2D>();
                             
                                    clons[2].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=rightAnswer.ToString();


                                    bol = false;
                                }
                            }                       
                        } else if(a == 3) {
                            i++;
                            if(mass[i] == 1 || mass[i] == 2) {
                                b   = mass[i];
                                if(b == 1) {
                                    c = 2;

                                    clons[0].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer2.ToString();
                                    clons[0].AddComponent<CircleCollider2D>();
                    
                                    clons[1].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=rightAnswer.ToString();
                                    clons[2].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer1.ToString();
                                    clons[2].AddComponent<CircleCollider2D>();
       
                                    bol = false;
                                } else if(b == 2) {
                                    c = 1;
                                    clons[0].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer2.ToString();
                                    clons[0].AddComponent<CircleCollider2D>();

                                    clons[1].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=loseAnswer1.ToString();
                                    clons[1].AddComponent<CircleCollider2D>();
                                
                                    clons[2].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text=rightAnswer.ToString();
                                
                                    bol = false;
                                }
                            }
                        }
                        i++;
                    } 
                
                    
                }


        if (score >= scoreRight) {
            float a = -2f;
                int num1;
                 int num2;
            var rnd = new System.Random();
            var rnd2 = new System.Random();
            for(int i = 0; i <= 2; i++) {
                clons[i] = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
                clons[i].transform.position = new Vector2(a, 9);
                a = a + 2;
            }

            num1 = rnd.Next(1, 51);
            num2 = rnd.Next(1, 51);
            textMath =num1 + " + " + num2;
            rightAnswer = num1 + num2;
            loseAnswer1 = rightAnswer - rnd2.Next(1, 4);
            loseAnswer2 = rightAnswer + rnd2.Next(1, 4); 
            Debug.Log(textMath);
            mathText.text = textMath.ToString();

            
            bol = true;
            scoreRight += 10;
            a = -2f;
    
        }




}




}