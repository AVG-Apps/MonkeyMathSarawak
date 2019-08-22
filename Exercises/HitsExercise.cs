using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace monkeyMath
{
    public class HitsExercise : MonoBehaviour
    {
        #region Attribute
        public float speed = 5f;

        private Player player;
        private Live liveManager;
        private LevelManager levelManager;
        private Enemy enemyManager;
        Excercise exercise;

        private bool hit = false;
        public bool tutorialHit;
        float timePassed = 0;
        bool lost;

        int aaa;

        int failLevel;
        #endregion


        private void Start()
        {
            player = FindObjectOfType<Player>();
            liveManager = FindObjectOfType<Live>();
            levelManager = FindObjectOfType<LevelManager>();
            exercise = FindObjectOfType<Excercise>();
            enemyManager = FindObjectOfType<Enemy>();
        }

        // Update is called once per frame
        void Update()
        {

            if (hit == true)
            {
                StartCoroutine(changeXDirection(-1));

                if (levelManager.totalLives == 0)
                {
                    levelManager.GameOverPanel.SetActive(true);
                    Time.timeScale = 0;
                    lost = true;
                    hit = false;
                }
            }

            if (lost)
            {
                if (PlayerPrefs.GetInt("MathLevel") == 1)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    for (int i = 1; i < 21; i++)
                    {
                        if (levelNumber == i)
                        {
                            failLevel = PlayerPrefs.GetInt("AdditionFailLevel"+i.ToString());
                            failLevel++;
                            PlayerPrefs.SetInt("AdditionFailLevel"+i.ToString(), failLevel);
                            Debug.Log(PlayerPrefs.GetInt("AdditionFailLevel"+i.ToString()));
                        }
                        
                    }
                }

                if (PlayerPrefs.GetInt("MathLevel") == 2)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    for (int i = 1; i < 21; i++)
                    {
                        if (levelNumber == i)
                        {
                            failLevel = PlayerPrefs.GetInt("SubtractionFailLevel"+i.ToString());
                            failLevel++;
                            PlayerPrefs.SetInt("SubtractionFailLevel"+i.ToString(), failLevel);
                            Debug.Log(PlayerPrefs.GetInt("SubtractionFailLevel"+i.ToString()));
                        } 
                    }
                }

                if (PlayerPrefs.GetInt("MathLevel") == 3)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    for (int i = 1; i < 21; i++)
                    {
                        if (levelNumber == i)
                        {
                            failLevel = PlayerPrefs.GetInt("MultiplicationFailLevel"+i.ToString());
                            failLevel++;
                            PlayerPrefs.SetInt("MultiplicationFailLevel"+i.ToString(), failLevel);
                            Debug.Log(PlayerPrefs.GetInt("MultiplicationFailLevel"+i.ToString()));
                        }
                    }
                }

                if (PlayerPrefs.GetInt("MathLevel") == 4)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    for (int i = 1; i < 21; i++)
                    {
                        if (levelNumber == i)
                        {
                            failLevel = PlayerPrefs.GetInt("DivisionFailLevel"+i.ToString());
                            failLevel++;
                            PlayerPrefs.SetInt("DivisionFailLevel"+i.ToString(), failLevel);
                            Debug.Log(PlayerPrefs.GetInt("DivisionFailLevel"+i.ToString()));
                        }
                    }
                }
                lost = false;
            }
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds (1f);
            Debug.Log("111");
            levelManager.GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                hitObstacle();
                aaa = PlayerPrefs.GetInt("Counter");
                levelManager.WQuestion[levelManager.WrongQ] = levelManager.exercises[levelManager.currentExercise].exercise.ToString();
                levelManager.WAnswer[levelManager.WrongQ] = levelManager.exercises[levelManager.currentExercise].answer.ToString();
                levelManager.Equation[levelManager.WrongQ] = levelManager.WQuestion[levelManager.WrongQ] + " = " + levelManager.WAnswer[levelManager.WrongQ];
                PlayerPrefs.SetString("WA"+aaa.ToString(), levelManager.Equation[levelManager.WrongQ]);
                aaa++;
                if (aaa == 21)
                {
                    aaa = 0;
                }
                PlayerPrefs.SetInt("Counter", aaa);
                levelManager.WrongQ++;
                tutorialHit = true;
                levelManager.Hit = true;  
            }

            if (other.tag == "Bullet" && !exercise.bigboss)
            {
                GameObject explosion = (GameObject)Instantiate(levelManager.ExplosionPrefab, transform.position, transform.rotation); 
                
                Destroy(explosion, 0.5f);
                Destroy(this. gameObject);
            }
        }

        public void hitObstacle()
        {
            destroyLife();
            hit = true;
        }

        public void destroyLife()
        {
            Destroy(gameObject, 1f);

            GameObject[] lifes = levelManager.lifes;
            GameObject[] stars = levelManager.stars;
            Destroy(lifes[levelManager.totalLives - 1].gameObject, 1f);
            Destroy(stars[levelManager.totalLives - 1].gameObject, 1f);
            levelManager.totalLives -= 1;   
        }

        public void destroyLife2()
        {
            GameObject[] lifes = levelManager.lifes;
            GameObject[] stars = levelManager.stars;
            Destroy(lifes[levelManager.totalLives - 1].gameObject, 1f);
            Destroy(stars[levelManager.totalLives - 1].gameObject, 1f);
            levelManager.totalLives -= 1;
        }


        IEnumerator changeXDirection(int direction)
        {
            while (timePassed < 4)
            {
                player.transform.Translate(direction * 150f * Time.deltaTime, 0, 0);
                timePassed += Time.deltaTime;
                // Debug.Log("go left monkey!");
                //Animation boom

                yield return null;
            }
        }

        public void CollectStars()
        {   
            if (PlayerPrefs.GetInt("MathLevel") == 1)
            {
                if (PlayerPrefs.GetInt("difficulty") == 1)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("EAdditionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EAdditionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("EAdditionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EAdditionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("EAdditionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EAdditionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {   
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {   
                                int star = PlayerPrefs.GetInt("EAdditionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                {
                                    PlayerPrefs.SetInt("EAdditionStars"+i.ToString(), levelManager.totalLives);
                                }
                            }
                        }
                    }
                    
                }
                if (PlayerPrefs.GetInt("difficulty") == 2)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("MAdditionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MAdditionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("MAdditionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MAdditionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("MAdditionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MAdditionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("MAdditionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                {
                                    PlayerPrefs.SetInt("MAdditionStars"+i.ToString(), levelManager.totalLives);
                                }
                            }
                        }
                    }
                    
                }
                if (PlayerPrefs.GetInt("difficulty") == 3)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("HAdditionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HAdditionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("HAdditionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HAdditionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("HAdditionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HAdditionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {   
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("HAdditionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                {
                                    PlayerPrefs.SetInt("HAdditionStars"+i.ToString(), levelManager.totalLives);
                                }
                            }
                        }   
                    }
                    
                }          
            }
        

            if (PlayerPrefs.GetInt("MathLevel") == 2)
            {
                if (PlayerPrefs.GetInt("difficulty") == 1)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("ESubtractionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("ESubtractionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("ESubtractionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("ESubtractionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("ESubtractionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("ESubtractionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("ESubtractionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("ESubtractionStars"+i.ToString(), levelManager.totalLives);
                            }
                        } 
                    }
                     
                }
                if (PlayerPrefs.GetInt("difficulty") == 2)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("MSubtractionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MSubtractionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("MSubtractionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MSubtractionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("MSubtractionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MSubtractionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("MSubtractionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("MSubtractionStars"+i.ToString(), levelManager.totalLives);
                            }
                        }  
                    }
                    
                }
                if (PlayerPrefs.GetInt("difficulty") == 3)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("HSubtractionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HSubtractionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("HSubtractionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HSubtractionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("HSubtractionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HSubtractionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("HSubtractionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("HSubtractionStars"+i.ToString(), levelManager.totalLives);
                            }
                        }  
                    }
                    
                }
                
            }

            if (PlayerPrefs.GetInt("MathLevel") == 3)
            {
                if (PlayerPrefs.GetInt("difficulty") == 1)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("EMultiplicationStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EMultiplicationStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("EMultiplicationStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EMultiplicationStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("EMultiplicationStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EMultiplicationStarsTest3", levelManager.totalLives);
                        }
                    }
                    for (int i = 1; i < 11; i++)
                    {
                        if (levelNumber == i)
                        {
                            int star = PlayerPrefs.GetInt("EMultiplicationStars"+ i.ToString());
                            if (star < levelManager.totalLives)
                            PlayerPrefs.SetInt("EMultiplicationStars"+i.ToString(), levelManager.totalLives);
                        }
                    }
                }
                if (PlayerPrefs.GetInt("difficulty") == 2)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("MMultiplicationStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MMultiplicationStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("MMultiplicationStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MMultiplicationStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("MMultiplicationStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MMultiplicationStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("MMultiplicationStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("MMultiplicationStars"+i.ToString(), levelManager.totalLives);
                            }
                        }
                    }
                    
                }
                if (PlayerPrefs.GetInt("difficulty") == 3)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("HMultiplicationStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HMultiplicationStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("HMultiplicationStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HMultiplicationStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("HMultiplicationStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HMultiplicationStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("HMultiplicationStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("HMultiplicationStars"+i.ToString(), levelManager.totalLives);
                            }
                        }
                    }
                    
                }
            }

            if (PlayerPrefs.GetInt("MathLevel") == 4)
            {
                if (PlayerPrefs.GetInt("difficulty") == 1)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("EDivisionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EDivisionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("EDivisionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EDivisionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("EDivisionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("EDivisionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("EDivisionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("EDivisionStars"+i.ToString(), levelManager.totalLives);
                            }
                        }  
                    }  
                }
                if (PlayerPrefs.GetInt("difficulty") == 2)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("MDivisionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MDivisionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("MDivisionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MDivisionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("MDivisionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("MDivisionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("MDivisionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("MDivisionStars"+i.ToString(), levelManager.totalLives);
                            }
                        }  
                    }    
                }
                if (PlayerPrefs.GetInt("difficulty") == 3)
                {
                    int levelNumber = PlayerPrefs.GetInt("MathLevelNumber");
                    int level = PlayerPrefs.GetInt("level");
                    if (level == 1)
                    {
                        int star = PlayerPrefs.GetInt("HDivisionStarsTest1");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HDivisionStarsTest1", levelManager.totalLives);
                        }
                    }
                    if (level == 2)
                    {
                        int star = PlayerPrefs.GetInt("HDivisionStarsTest2");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HDivisionStarsTest2", levelManager.totalLives);
                        }
                    }
                    if (level == 3)
                    {
                        int star = PlayerPrefs.GetInt("HDivisionStarsTest3");
                        if (star < levelManager.totalLives)
                        {
                            PlayerPrefs.SetInt("HDivisionStarsTest3", levelManager.totalLives);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 11; i++)
                        {
                            if (levelNumber == i)
                            {
                                int star = PlayerPrefs.GetInt("HDivisionStars"+ i.ToString());
                                if (star < levelManager.totalLives)
                                PlayerPrefs.SetInt("HDivisionStars"+i.ToString(), levelManager.totalLives);
                            }   
                        }  
                    }
                    
                }
           } 
        }      
    }
}

