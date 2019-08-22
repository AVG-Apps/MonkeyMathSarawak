using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

namespace monkeyMath
{
	public class GameControl : MonoBehaviour 
	{
		public static GameControl instance;			

		public GameObject answerLabel;
		public float scrollSpeed;
		public GameObject Canvas;
		public GameObject[] test;
		public Transform[] spots;
		public String WQuestion;
        public String WAnswer;
        public String Equation;
		public bool removeButton;
		public bool correctAnswer;
		PlayerEndless player;
		public bool Hit;
		Weapon weapon;
		string answer = "";
		public GameObject ex;
		public GameObject GameOverPanel;
		public GameObject PausePanel;
		public Text labelTotalBananas;
		public int totalBananas;

		public GameObject ExplosionPrefab;

		int targetScore = 50;
		int previous;
		int turn;
		void Awake()
		{
	
			if (instance == null)
		
				instance = this;
		
			else if(instance != this)
			
			Destroy (gameObject);

			player = FindObjectOfType<PlayerEndless>();
			weapon = FindObjectOfType<Weapon>();
		}

		void Start()
		{
			Time.timeScale = 1;
			SpawnExercise();
			previous = PlayerPrefs.GetInt("Highscore");
		}

		void Update()
		{
			if (Hit)
            {
                GameOverPanel.transform.Find("Panel/Answer/").GetChild(0).GetComponent<Text>().text = Equation;
                Hit = false;
            }

			if (correctAnswer)
			{
				earnBanana(5);
				correctAnswer = false;
			}

			if (totalBananas >= targetScore)
			{
				scrollSpeed-=50;
				targetScore+= 50;
			}

			PausePanel.transform.Find("Panel/Banana/Score").GetComponent<Text>().text = totalBananas.ToString();
		}

		public void openPauseMenu()
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        }

        public void closePauseMenu()
        {  
            PausePanel.SetActive(false);
            Time.timeScale = 1; 
        }

		public void changeAnswerLabel(string number)
        {
            
            answerLabel.SetActive(true);
            if (number != "remove")
            {
                if (answer.Length > 1) { answer = answer.Substring(1); }
                answer += number;
            }

            if (number == "remove")
            {
                if (answer.Length > 1) { answer = answer.Substring(2); }
                if (answer.Length == 1) { answer = answer.Substring(1); }
                removeButton = true;
            }

            answerLabel.GetComponent<Text>().text = answer;
            checkAnswer();
            
            StartCoroutine(FadeTextToZeroAlpha(3f, answerLabel.GetComponent<Text>()));

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

		public void checkAnswer()
        {
            if (String.IsNullOrEmpty(answer) != true)
            {
				if (ex.GetComponent<ExerciseEndless>().answer <= 9)
                {
                    string a = answer.Substring(0);
                   
                    if (ex.GetComponent<ExerciseEndless>().answer == Int32.Parse(a))
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
						SpawnExercise();
                    }
                    if (a.Length == 1)
                    {
                        if (ex.GetComponent<ExerciseEndless>().answer != Int32.Parse(a))
                        {
                            Debug.Log("1");
                            answer = "";
                        }
                    }
                }

                if (ex.GetComponent<ExerciseEndless>().answer > 9)
                {
                    string a = answer.Substring(0,1) + answer.Substring(1);
                    if (ex.GetComponent<ExerciseEndless>().answer == Int32.Parse(a))
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
						SpawnExercise();
                    }

                    if (a.Length == 2)
                    {
                        if (ex.GetComponent<ExerciseEndless>().answer != Int32.Parse(a))
                        {
                            Debug.Log("2");
                            answer = "";
                        }
                    }

                }
            }
        }

		public void earnBanana(int amountBananas)
        {
            totalBananas += amountBananas;
            labelTotalBananas.text = totalBananas.ToString();
			if (totalBananas > previous)
            PlayerPrefs.SetInt("Highscore", totalBananas);
        }

		void SpawnExercise()
		{
			if (turn == 0)
			{
				int r = UnityEngine.Random.Range(0, 15);
				ex = (GameObject)Instantiate(test[r], spots[0].position, spots[0].rotation);
				setLabels(ex.GetComponent<ExerciseEndless>());
				ex.transform.SetParent(Canvas.transform);
				turn = 1;
			}
			
			else
			{
				int r = UnityEngine.Random.Range(0, 15);
				ex = (GameObject)Instantiate(test[r], spots[1].position, spots[1].rotation);
				setLabels(ex.GetComponent<ExerciseEndless>());
				ex.transform.SetParent(Canvas.transform);
				turn = 0;
			}
		}

		public void setLabels(ExerciseEndless exercise)
        {
            int operation = UnityEngine.Random.Range(1, 4);
			if (operation == 1)
			{
				exercise.setAdditionExercise();
			}
			if (operation == 2)
			{
				exercise.setSubtractionExercise();
			}
			if (operation == 3)
			{
				exercise.setMultiplicationExercise();
			}
			if (operation == 4)
			{
				exercise.setDivisionExercise();
			}
            
            exercise.GetComponentInChildren<Text>().text = exercise.exercise;
            
        }   
	}
}
