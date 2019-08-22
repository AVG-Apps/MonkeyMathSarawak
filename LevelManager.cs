using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace monkeyMath
{

    public class LevelManager : MonoBehaviour
    {
        //Public variables
        public GameObject answerLabel;
        public Excercise[] exercises;
        public Excercise[] bossExercises;
        public GameObject[] lifes;
        public GameObject[] stars;
        public GameObject[] TutorialPanel;
        public GameObject[] Triggers;
        public GameObject[] Obstacle;
        public Text labelTotalBananas;
        public Text labelCorrectAnswer;
        public float fadeOutTime;

        public int currentExercise;
        public int bossCurrentExercise = 0;
        public int totalLives;
        private int totalBananas;
        private int totalCorrectAnswers;

        public String[] WQuestion;
        public String[] WAnswer;
        public String[] Equation;

        public bool correctAnswer;
        public bool correctAnswer1;
        public bool correctAnswer2;
        public bool correctAnswer3;

        public bool tutorialCorrectAnswer;
        public bool wrongAnswer = true;
        public bool firstTime = true;

        private Player player;
        private Excercise exercise;
        private HitsExercise hits;
        private StopMovement stop;
        bool bossAnswer;
        Weapon weapon;
        public GameObject[] BossT;

        public int tutorialCounter;
        public int tutorialTriggerCounter;
        public bool removeButton;
        public GameObject WellDonePanel;
        public GameObject GameOverPanel;
        public GameObject PausePanel;
        public GameObject ExitPanel;
        public GameObject PausePanelText;
        public GameObject WellDonePanelText;
        public GameObject NextButton;
        public GameObject fixedCanvas;

        public int WrongQ;
        public GameObject GameOverPanelText;

        public GameObject ExplosionPrefab;

        int PreviousBanana;
        bool inCD1;
        public bool Hit;
        TutorialTrigger tt;

        Enemy enemy;

        //Not public variables
        string answer = "";

        // Start is called before the first frame update
        [Obsolete]

        private void Awake()
        {
            player = FindObjectOfType<Player>();
            exercise = FindObjectOfType<Excercise>();
            hits = FindObjectOfType<HitsExercise>();
            stop = FindObjectOfType<StopMovement>();
            tt = FindObjectOfType<TutorialTrigger>();
            weapon = FindObjectOfType<Weapon>();
            enemy = FindObjectOfType<Enemy>();
        }


        void Start()
        {
            totalLives = 3;
            Time.timeScale = 1;
            labelTotalBananas.text = totalBananas.ToString();
            answerLabel.SetActive(false);
            PreviousBanana = PlayerPrefs.GetInt("TotalBanana");
            // Swap();
            reshuffle(Obstacle);
            
            
            for (int i = 0; i < exercises.Length; i++)
            {
                setLabels(exercises[i]);
            }
            for (int i = 0; i < bossExercises.Length; i++)
            {
                setLabels(bossExercises[i]);   
                bossExercises[i].gameObject.GetComponentInChildren<Text>().gameObject.SetActive(false);
            }

            if(PlayerPrefs.GetInt("MathLevelNumber") != 1)
            {
                GameObject.Find("Triggers").SetActive(false);
            }
            
           
        }

        void reshuffle (GameObject[] Obstacle)
        {
           for (int t = 0; t < Obstacle.Length; t++)
           {
               Vector3 temp = Obstacle[t].transform.position;
               GameObject tmp = Obstacle[t];
               int r = UnityEngine.Random.Range(t, Obstacle.Length);
               Obstacle[t].transform.position = Obstacle[r].transform.position;
               Obstacle[r].transform.position = temp;
               Obstacle[t] = Obstacle[r];
               Obstacle[r] = tmp;
               Obstacle[t].transform.parent = null;
               Obstacle[t].transform.SetParent(exercises[t].transform);

           }
        }

        void Swap()
        {
            for (int t = 0; t < Obstacle.Length; t++)
            {
                // Obstacle[t].transform.GetChild(t).transform.parent = null;
                Vector3 temp = Obstacle[t].transform.position;
                // Transform temp1 = exercises[t].transform.GetChild(1).transform;
                int r = UnityEngine.Random.Range(t, Obstacle.Length);
                Obstacle[t].transform.position = Obstacle[r].transform.position;
                Obstacle[r].transform.position = temp;
                // exercises[t].transform.GetChild(1).SetParent(exercises[r].transform);
                // exercises[r].transform.GetChild(1).SetParent(exercises[t].transform);
                // Obstacle[r].name = (t+1).ToString();
                
            }
        }

        public void openPauseMenu()
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        }

        public void closePauseMenu()
        {
            // if (Time.timeScale == 0 && firstTime)
            // {
            //     PausePanel.SetActive(false);
            // }
            // else
            // {
                PausePanel.SetActive(false);
                Time.timeScale = 1;
            // }
            
        }

        public void openExitPanel()
        {
            ExitPanel.SetActive(true);
            Time.timeScale = 0;
        }

        public void closeExitPanel()
        {
            ExitPanel.SetActive(false);
            Time.timeScale = 1;
        }

        public void CloseGame()
        {
            Application.Quit();
        }

        private void Update()
        {
            if (enemy.isWin)
            {
                hits.CollectStars();
                Debug.Log("111");
                enemy.isWin = false;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
			{
				openExitPanel();
			}

            if (Hit)
            {
                GameOverPanelText.transform.Find("Panel/Answer/").GetChild(WrongQ-1).GetComponent<Text>().text = Equation[WrongQ-1];
                Hit = false;
            }
            
            if (PlayerPrefs.GetInt("MathLevelNumber") == 10)
            {
                NextButton.GetComponent<Button>().interactable = false;
            }

            if (correctAnswer1 == true)
            {
                earnBanana(5);
                correctAnswer1 = false;
            }

            if (exercise.bigboss)
            {
                // bossExercises[0].gameObject.SetActive(true);
                BossT[bossCurrentExercise].SetActive(true);
                // exercise.bigboss = false;
            }

            PausePanelText.transform.Find("Target/Score").GetComponent<Text>().text = totalCorrectAnswers.ToString() + "/20";
            PausePanelText.transform.Find("Banana/Score").GetComponent<Text>().text = totalBananas.ToString();
            WellDonePanelText.transform.Find("Target/Score").GetComponent<Text>().text = totalCorrectAnswers.ToString() + "/20";
            WellDonePanelText.transform.Find("Banana/Score").GetComponent<Text>().text = totalBananas.ToString();
            // GameOverPanelText.transform.FindChild("Target/Score").GetComponent<Text>().text = totalCorrectAnswers.ToString() + "/18";
            // GameOverPanelText.transform.FindChild("Banana/Score").GetComponent<Text>().text = totalBananas.ToString();
        }

        public void changeAnswerLabel(string number)
        {
            
            answerLabel.SetActive(true);
            //StartCoroutine(FadeTextToFullAlpha(0.1f, answerLabel.GetComponent<Text>()));

            if (number != "remove")
            {
                if (answer.Length > 1) { answer = answer.Substring(0); }
                // if (answer.Length == 3)
                // {
                //     answer = "";
                // }
                answer += number;
            }

            if (number == "remove")
            {
                // if (answer.Length > 1) { answer = answer.Substring(2); }
                // if (answer.Length == 1) { answer = answer.Substring(1); }
                answer = "";
                removeButton = true;
            }

            answerLabel.GetComponent<Text>().text = answer;
            if (exercise.bigboss == false)
                checkAnswer();
            else{
                checkBossAnswer();
            }
            StartCoroutine(FadeTextToZeroAlpha(3f, answerLabel.GetComponent<Text>()));

        }

        public void checkAnswer()
        {
            if (String.IsNullOrEmpty(answer) != true)
            {
                if (exercises[currentExercise].answer <= 9)
                {
                    string a = answer.Substring(0);
                    // Debug.Log(a);
                    // Debug.Log(exercises[currentExercise].answer);
                    if (exercises[currentExercise].answer == Int32.Parse(a))
                    {
                        answer = "";
                        weapon.shoot();
                        if (player.posDown == true)
                        {
                            int direction = +1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }

                        else
                        {
                            int direction = -1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }
                        correctAnswer = true;
                        correctAnswer1 = true;
                        tutorialCorrectAnswer = true;

                        totalCorrectAnswers += 1;
                        labelCorrectAnswer.text = totalCorrectAnswers.ToString() + "/20";
                    }
                    if (a.Length == 1)
                    {
                        if (exercises[currentExercise].answer != Int32.Parse(a))
                        {
                            wrongAnswer = false; 
                            Debug.Log("1");
                            answer = "";
                        }
                    }
                }

                if (exercises[currentExercise].answer > 9)
                {
                    string a = answer.Substring(0,1) + answer.Substring(1);
                    if (exercises[currentExercise].answer == Int32.Parse(a))
                    {
                        answer = "";
                        weapon.shoot();
                        if (player.posDown == true)
                        {
                            int direction = +1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }

                        else
                        {
                            int direction = -1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }
                        correctAnswer = true;
                        correctAnswer1 = true;
                        tutorialCorrectAnswer = true;

                        totalCorrectAnswers += 1;
                        labelCorrectAnswer.text = totalCorrectAnswers.ToString() + "/20";
                    }

                    if (a.Length == 2)
                    {
                        if (exercises[currentExercise].answer != Int32.Parse(a))
                        {
                            wrongAnswer = false; 
                            Debug.Log("2");
                            answer = "";
                        }
                    }
                }
                
                
            }
        }

        public void checkBossAnswer()
        {
            if (String.IsNullOrEmpty(answer) != true)
            {
                if (exercises[bossCurrentExercise].answer <= 9)
                {
                    string a = answer.Substring(0);

                    if (a.Length == 1)
                    {
                        if (bossExercises[bossCurrentExercise].answer != Int32.Parse(a)) 
                        {
                            wrongAnswer = false;
                            hits.destroyLife2();
                            answer = "";
                            Debug.Log("life - 1");
                        }
                    }

                    if (bossExercises[bossCurrentExercise].answer == Int32.Parse(a))
                    {
                        answer = "";
                        weapon.shoot();
                        if (player.posDown == true)
                        {
                            int direction = +1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }   

                        else
                        {
                            int direction = -1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }
                    
                        correctAnswer2 = true;
                        correctAnswer1 = true;
                        totalCorrectAnswers += 1;
                        BossT[bossCurrentExercise].SetActive(false);
                        BossT[bossCurrentExercise + 1].SetActive(true);
                        bossCurrentExercise++;
                        labelCorrectAnswer.text = totalCorrectAnswers.ToString() + "/20";
                    }
                }

                if (exercises[bossCurrentExercise].answer > 9)
                {
                    string a = answer.Substring(0, 1) + answer.Substring(1);
                    if (a.Length == 2)
                    {
                        if (bossExercises[bossCurrentExercise].answer != Int32.Parse(a)) 
                        {
                            wrongAnswer = false;
                            hits.destroyLife2();
                            answer = "";
                        }
                    }

                    if (bossExercises[bossCurrentExercise].answer == Int32.Parse(a))
                    {
                        answer = "";
                        weapon.shoot();
                        if (player.posDown == true)
                        {
                            int direction = +1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }   

                        else
                        {
                            int direction = -1;
                            StartCoroutine(player.changeYDirection(direction));
                            player.posDown = !player.posDown;
                        }
                    
                        correctAnswer2 = true;
                        correctAnswer1 = true;
                        totalCorrectAnswers += 1;
                        BossT[bossCurrentExercise].SetActive(false);
                        BossT[bossCurrentExercise + 1].SetActive(true);
                        bossCurrentExercise++;
                        labelCorrectAnswer.text = totalCorrectAnswers.ToString() + "/20";
                    }
   
                }
            }
        }

        public void earnBanana(int amountBananas)
        {
            totalBananas += amountBananas;
            labelTotalBananas.text = totalBananas.ToString();
            int CumBanana = PreviousBanana + totalBananas;
            PlayerPrefs.SetInt("TotalBanana", CumBanana);
        }

        IEnumerator inCD()
        {
            inCD1 = true;
            yield return new WaitForSecondsRealtime (0.2f);
            inCD1 = false;
        }

        public void setLabels(Excercise exercise)
        {
            if (PlayerPrefs.GetInt("MathLevel") == 1)
            {
                if (PlayerPrefs.GetInt("level") == 1)
                {
                    int operation = UnityEngine.Random.Range(1, 5);
                    exercise.setAdditionExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }  
                else if (PlayerPrefs.GetInt("level") == 2)
                {
                    int operation = UnityEngine.Random.Range(6, 10);
                    exercise.setAdditionExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else if (PlayerPrefs.GetInt("level") == 3)
                {
                    int operation = UnityEngine.Random.Range(1, 10);
                    exercise.setAdditionExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else
                {
                    exercise.setAdditionExercise();
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }         
            }   

            if (PlayerPrefs.GetInt("MathLevel") == 2)
            {
                if (PlayerPrefs.GetInt("level") == 1)
                {
                    int operation = UnityEngine.Random.Range(1, 5);
                    exercise.setSubtractionExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }  
                else if (PlayerPrefs.GetInt("level") == 2)
                {
                    int operation = UnityEngine.Random.Range(6, 10);
                    exercise.setSubtractionExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else if (PlayerPrefs.GetInt("level") == 3)
                {
                    int operation = UnityEngine.Random.Range(1, 10);
                    exercise.setSubtractionExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else
                {
                    exercise.setSubtractionExercise();
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
            } 

            if (PlayerPrefs.GetInt("MathLevel") == 3)
            {
                if (PlayerPrefs.GetInt("level") == 1)
                {
                    int operation = UnityEngine.Random.Range(1, 5);
                    exercise.setMultiplicationExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }  
                else if (PlayerPrefs.GetInt("level") == 2)
                {
                    int operation = UnityEngine.Random.Range(6, 10);
                    exercise.setMultiplicationExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else if (PlayerPrefs.GetInt("level") == 3)
                {
                    int operation = UnityEngine.Random.Range(1, 10);
                    exercise.setMultiplicationExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else
                {
                    exercise.setMultiplicationExercise();
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }   
            }    

            if (PlayerPrefs.GetInt("MathLevel") == 4)
            {
                if (PlayerPrefs.GetInt("level") == 1)
                {
                    int operation = UnityEngine.Random.Range(1, 5);
                    exercise.setMultiplicationExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }  
                else if (PlayerPrefs.GetInt("level") == 2)
                {
                    int operation = UnityEngine.Random.Range(6, 10);
                    exercise.setMultiplicationExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else if (PlayerPrefs.GetInt("level") == 3)
                {
                    int operation = UnityEngine.Random.Range(1, 10);
                    exercise.setMultiplicationExercise(operation);
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }
                else
                {
                     exercise.setDivisionExercise();
                    exercise.GetComponentInChildren<Text>().text = exercise.exercise;
                }  
            }  
            
        }   

        public void checkExercisePosition()
        {
            if (player.posDown == true)
            {
                if (exercises[currentExercise].posDown != true)
                {
                    exercise.changePosition(exercises[currentExercise], -1);             
                }
            }

            if (player.posDown != true)
            {
                if (exercises[currentExercise].posDown == true)
                {
                    exercise.changePosition(exercises[currentExercise], +1);
                }
            }
        }

        public IEnumerator FadeTextToZeroAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
            while (i.color.a > 0.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
                yield return null;
            }
        }
    }
}
