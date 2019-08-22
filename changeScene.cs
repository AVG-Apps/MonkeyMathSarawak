using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace monkeyMath
{

	public class changeScene : MonoBehaviour
	{

		public GameObject ExitPanel;

		void Update()
		{
			if (GameObject.Find("Canvas/HighScore/Text") != null)
			GameObject.Find("Canvas/HighScore/Text").GetComponent<Text>().text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();

			if (GameObject.Find("TotalBanana/Text") != null)
			GameObject.Find("TotalBanana/Text").GetComponent<Text>().text = PlayerPrefs.GetInt("TotalBanana").ToString();
			
			
			
			
			if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.A))
			{
				openExitPanel();
			}


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

		void Start()
		{
			SetScreenOrientation();
			if (GameObject.Find("Canvas/ExitPanel") != null)
			ExitPanel = GameObject.Find("Canvas/ExitPanel");
			ExitPanel.SetActive(false);
		}

		private void SetScreenOrientation()
     	{
          Screen.autorotateToPortrait = false;
          Screen.autorotateToLandscapeRight = true;
          Screen.autorotateToLandscapeLeft = true;
          Screen.autorotateToPortraitUpsideDown = false; 
    	 }	

		public void sceneSwitcher(string scenename)
		{
			SceneManager.LoadScene(scenename);
		}

		public void setLevelExercise(int difficulty)
        {
            // this.levelExercise = difficulty;
            PlayerPrefs.SetInt("MathLevelNumber", difficulty);
        }

		public void setMathLevel(int level)
		{
			Time.timeScale = 1;
			PlayerPrefs.SetInt("MathLevel", level);
		}

        public void setMathCount(int level)
        {
            PlayerPrefs.SetInt("MonkeyCount", level);
        }

		public void restartLevel()
		{
			Time.timeScale = 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		public void nextLevel()
		{
			Time.timeScale = 1;
			PlayerPrefs.SetInt("MathLevelNumber", PlayerPrefs.GetInt("MathLevelNumber") + 1);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		public void resetAll()
		{
			PlayerPrefs.DeleteAll();
		}

		//Set Difficulty level
		public void setDifficulty(int difficulty)
		{
			PlayerPrefs.SetInt("difficulty", difficulty);
			if (PlayerPrefs.GetInt("MathLevel") == 1)
			{
				StartCoroutine(wait());
				SceneManager.LoadScene("LevelOverviewPlus");
			}
			if (PlayerPrefs.GetInt("MathLevel") == 2)
			{
				StartCoroutine(wait());
				SceneManager.LoadScene("LevelOverviewMinus");
			}
			if (PlayerPrefs.GetInt("MathLevel") == 3)
			{
				StartCoroutine(wait());
				SceneManager.LoadScene("LevelOverviewTimes");
			}
			if (PlayerPrefs.GetInt("MathLevel") == 4)
			{
				StartCoroutine(wait());
				SceneManager.LoadScene("LevelOverviewDivides");
			}
		}

		IEnumerator wait()
		{
			yield return new WaitForSeconds(1f);
		}

		public void setTest(int level)
		{
			PlayerPrefs.SetInt("level", level);
		}

		public void setSpeedMovement(int number)
        {
            PlayerPrefs.SetInt("speed", number);
        }

		//Get stars of the levels

		public void GetAllStar()
    {
        int a = 3;
        PlayerPrefs.SetInt("EAdditionStarsTest1", a);
        PlayerPrefs.SetInt("EAdditionStarsTest2", a);
        PlayerPrefs.SetInt("EAdditionStarsTest3", a);
        for (int i = 1; i < 11; i++)
        {              
            PlayerPrefs.SetInt("EAdditionStars"+i.ToString(), a);   
            PlayerPrefs.SetInt("MAdditionStars"+i.ToString(), a);   
            PlayerPrefs.SetInt("HAdditionStars"+i.ToString(), a);   
            PlayerPrefs.SetInt("ESubtractionStars"+i.ToString(), a);   
            PlayerPrefs.SetInt("MSubtractionStars"+i.ToString(), a);   
            PlayerPrefs.SetInt("HSubtractionStars"+i.ToString(), a); 
            PlayerPrefs.SetInt("EMultiplicationStars"+i.ToString(), a);
            PlayerPrefs.SetInt("MMultiplicationStars"+i.ToString(), a);
            PlayerPrefs.SetInt("HMultiplicationStars"+i.ToString(), a);
            PlayerPrefs.SetInt("EDivisionStars"+i.ToString(), a);
            PlayerPrefs.SetInt("MDivisionStars"+i.ToString(), a);
            PlayerPrefs.SetInt("HDivisionStars"+i.ToString(), a);
        }
        PlayerPrefs.SetInt("MAdditionStarsTest1", a);
        PlayerPrefs.SetInt("MAdditionStarsTest2", a);
        PlayerPrefs.SetInt("MAdditionStarsTest3", a);
        PlayerPrefs.SetInt("HAdditionStarsTest1", a);
        PlayerPrefs.SetInt("HAdditionStarsTest2", a);
        PlayerPrefs.SetInt("HAdditionStarsTest3", a);
        PlayerPrefs.SetInt("ESubtractionStarsTest1", a);
        PlayerPrefs.SetInt("ESubtractionStarsTest2", a);
        PlayerPrefs.SetInt("ESubtractionStarsTest3", a);
        PlayerPrefs.SetInt("MSubtractionStarsTest1", a);
        PlayerPrefs.SetInt("MSubtractionStarsTest2", a);
        PlayerPrefs.SetInt("MSubtractionStarsTest3", a);
        PlayerPrefs.SetInt("HSubtractionStarsTest1", a);
        PlayerPrefs.SetInt("HSubtractionStarsTest2", a);
        PlayerPrefs.SetInt("HSubtractionStarsTest3", a);
        PlayerPrefs.SetInt("EMultiplicationStarsTest1", a);
        PlayerPrefs.SetInt("EMultiplicationStarsTest2", a);
        PlayerPrefs.SetInt("EMultiplicationStarsTest3", a);
        PlayerPrefs.SetInt("MMultiplicationStarsTest1", a);
        PlayerPrefs.SetInt("MMultiplicationStarsTest2", a);
        PlayerPrefs.SetInt("MMultiplicationStarsTest3", a);
        PlayerPrefs.SetInt("HMultiplicationStarsTest1", a);
        PlayerPrefs.SetInt("HMultiplicationStarsTest2", a);
        PlayerPrefs.SetInt("HMultiplicationStarsTest3", a);
        PlayerPrefs.SetInt("EDivisionStarsTest1", a);
        PlayerPrefs.SetInt("EDivisionStarsTest2", a);
        PlayerPrefs.SetInt("EDivisionStarsTest3", a);
        PlayerPrefs.SetInt("MDivisionStarsTest1", a);
        PlayerPrefs.SetInt("MDivisionStarsTest2", a);
        PlayerPrefs.SetInt("MDivisionStarsTest3", a);
        PlayerPrefs.SetInt("HDivisionStarsTest1", a);
        PlayerPrefs.SetInt("HDivisionStarsTest2", a);
        PlayerPrefs.SetInt("HDivisionStarsTest3", a);
    }
}
}

