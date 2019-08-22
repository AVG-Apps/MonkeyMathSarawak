using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
	public class TutorialTrigger : MonoBehaviour {

		public bool tutorialOn;

		bool aaa;
		// GameObject result;
		// GameObject result1;
		LevelManager levelManager;

		void Awake()
		{
			levelManager = FindObjectOfType<LevelManager>();
		}

		void Start()
		{
            // result = levelManager.TutorialPanel[0].transform.Find("T").gameObject;
			// result1 = levelManager.TutorialPanel[0].transform.Find("T1").gameObject;
		}

		private void OnTriggerEnter2D(Collider2D other)
    	{
        	if (other.tag == "Player")
        	{
				tutorialOn = true;
				if (levelManager.tutorialTriggerCounter == 1)
				{
					StartCoroutine(nextTutorial());
				}

        	}
    	}

		void Update()
		{
			if (tutorialOn)
            {
                Time.timeScale = 0;
				if (levelManager.tutorialTriggerCounter < 2)
                levelManager.TutorialPanel[levelManager.tutorialTriggerCounter].SetActive(true);
                levelManager.tutorialTriggerCounter++;
				levelManager.Triggers[0].GetComponent<BoxCollider2D>().enabled = false;
				if (levelManager.tutorialCounter < 19)
				{levelManager.Triggers[levelManager.tutorialCounter].GetComponent<BoxCollider2D>().enabled = false;}
				tutorialOn = false;
            }

			if (levelManager.TutorialPanel[1].activeSelf == true)
			{
				StartCoroutine(TutorialOff());
			}

			
			//Check correct answer
            if (levelManager.tutorialCorrectAnswer)
            {
                levelManager.TutorialPanel[0].SetActive(false);
				if (levelManager.tutorialCounter < 19)
				{levelManager.Triggers[levelManager.tutorialCounter].GetComponent<BoxCollider2D>().enabled = false;}
				if (levelManager.tutorialCounter == 0)
				{
					levelManager.TutorialPanel[2].SetActive(true);
					StartCoroutine(previousTutorial());
				}
				levelManager.tutorialCorrectAnswer = false;
				levelManager.tutorialCounter++;	
            }

			// if (levelManager.wrongAnswer == false)
			// {
			// 	result.SetActive(false);
			// 	result1.SetActive(true);
			// 	levelManager.wrongAnswer = true;
			// }

			// if (levelManager.removeButton)
			// {
			// 	result.SetActive(true);
			// 	result1.SetActive(false);
			// 	levelManager.removeButton = false;
			// }

			if (levelManager.totalLives == 0 && levelManager.lifes[0].gameObject == null)
			{
				levelManager.TutorialPanel[3].SetActive(true);
				Time.timeScale = 0;
			}

		}	

		//Set next tutorial
		IEnumerator nextTutorial()
		{
			yield return new WaitForSecondsRealtime(2f);
			levelManager.TutorialPanel[1].SetActive(false);
			Time.timeScale = 1;
		}

		//Set previous tutorial
		IEnumerator previousTutorial()
		{
			yield return new WaitForSecondsRealtime(2f);
			levelManager.TutorialPanel[2].SetActive(false);
			Time.timeScale = 1;
		}

		//Turn tutorial off
		IEnumerator TutorialOff()
		{
			yield return new WaitForSeconds(1f);
			GameObject.Find("Triggers").SetActive(false);
		}
	}
}
