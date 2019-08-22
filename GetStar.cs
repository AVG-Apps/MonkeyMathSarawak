using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStar : MonoBehaviour
{
    public Texture m_texture;

    

    void Update()
    {
        if (PlayerPrefs.GetInt("MathLevel") == 1)
        {
            if (PlayerPrefs.GetInt("difficulty") == 1)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("EAdditionStars"+ i.ToString());
                    
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }  

                }

                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("EAdditionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/+" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("EAdditionStars5");
                int starTest1 = PlayerPrefs.GetInt("EAdditionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("EAdditionStars10");
                int starTest2 = PlayerPrefs.GetInt("EAdditionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("EAdditionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("EAdditionAnimalScore");
                GameObject s = GameObject.Find("Canvas/+minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/+minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/+minigame/Lock");
                    b.SetActive(false);
                }

                 
                
            }
            if (PlayerPrefs.GetInt("difficulty") == 2)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MAdditionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MAdditionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/+" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("MAdditionStars5");
                int starTest1 = PlayerPrefs.GetInt("MAdditionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("MAdditionStars10");
                int starTest2 = PlayerPrefs.GetInt("MAdditionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("MAdditionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("NAdditionAnimalScore");
                GameObject s = GameObject.Find("Canvas/+minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/+minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/+minigame/Lock");
                    b.SetActive(false);
                }
            }
            if (PlayerPrefs.GetInt("difficulty") == 3)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HAdditionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HAdditionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/+" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/+" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("HAdditionStars5");
                int starTest1 = PlayerPrefs.GetInt("HAdditionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("HAdditionStars10");
                int starTest2 = PlayerPrefs.GetInt("HAdditionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("HAdditionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("HAdditionAnimalScore");
                GameObject s = GameObject.Find("Canvas/+minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/+minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/+minigame/Lock");
                    b.SetActive(false);
                }
            }
            
        }
        
        if (PlayerPrefs.GetInt("MathLevel") == 2)
        {
            if (PlayerPrefs.GetInt("difficulty") == 1)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("ESubtractionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("ESubtractionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/-" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("ESubtractionStars5");
                int starTest1 = PlayerPrefs.GetInt("ESubtractionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("ESubtractionStars10");
                int starTest2 = PlayerPrefs.GetInt("ESubtractionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("ESubtractionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("ESubtractionAnimalScore");
                GameObject s = GameObject.Find("Canvas/-minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/-minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/-minigame/Lock");
                    b.SetActive(false);
                }
                
            }
            if (PlayerPrefs.GetInt("difficulty") == 2)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MSubtractionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MSubtractionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/-" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("MSubtractionStars5");
                int starTest1 = PlayerPrefs.GetInt("MSubtractionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("MSubtractionStars10");
                int starTest2 = PlayerPrefs.GetInt("MSubtractionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("MSubtractionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("NSubtractionAnimalScore");
                GameObject s = GameObject.Find("Canvas/-minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/-minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/-minigame/Lock");
                    b.SetActive(false);
                }
            }
            if (PlayerPrefs.GetInt("difficulty") == 3)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HSubtractionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HSubtractionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/-" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/-" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("HSubtractionStars5");
                int starTest1 = PlayerPrefs.GetInt("HSubtractionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("HSubtractionStars10");
                int starTest2 = PlayerPrefs.GetInt("HSubtractionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("HSubtractionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("HSubtractionAnimalScore");
                GameObject s = GameObject.Find("Canvas/-minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/-minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/-minigame/Lock");
                    b.SetActive(false);
                }
            }
            
        }

        if (PlayerPrefs.GetInt("MathLevel") == 3)
        {
            if (PlayerPrefs.GetInt("difficulty") == 1)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("EMultiplicationStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("EMultiplicationStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/×" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("EMultiplicationStars5");
                int starTest1 = PlayerPrefs.GetInt("EMultiplicationStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("EMultiplicationStars10");
                int starTest2 = PlayerPrefs.GetInt("EMultiplicationStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("EMultiplicationStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("EMultiplicationAnimalScore");
                GameObject s = GameObject.Find("Canvas/×minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/×minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/×minigame/Monkey/Lock");
                    b.SetActive(false);
                }
            }
            if (PlayerPrefs.GetInt("difficulty") == 2)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MMultiplicationStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    } 
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MMultiplicationStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/×" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("MMultiplicationStars5");
                int starTest1 = PlayerPrefs.GetInt("MMultiplicationStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("MMultiplicationStars10");
                int starTest2 = PlayerPrefs.GetInt("MMultiplicationStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("MMultiplicationStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("NMultiplicationAnimalScore");
                GameObject s = GameObject.Find("Canvas/×minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/×minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/×minigame/Lock");
                    b.SetActive(false);
                }
            }
            if (PlayerPrefs.GetInt("difficulty") == 3)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HMultiplicationStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                     GameObject a = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                     a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HMultiplicationStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/×" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/×" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("HMultiplicationStars5");
                int starTest1 = PlayerPrefs.GetInt("HMultiplicationStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("HMultiplicationStars10");
                int starTest2 = PlayerPrefs.GetInt("HMultiplicationStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("HMultiplicationStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("HMultiplicationAnimalScore");
                GameObject s = GameObject.Find("Canvas/×minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/×minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/×minigame/Lock");
                    b.SetActive(false);
                }
            }   
        }

        if (PlayerPrefs.GetInt("MathLevel") == 4)
        {
            if (PlayerPrefs.GetInt("difficulty") == 1)
            {
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("EDivisionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("EDivisionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/÷" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("EDivisionStars5");
                int starTest1 = PlayerPrefs.GetInt("EDivisionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("EDivisionStars10");
                int starTest2 = PlayerPrefs.GetInt("EDivisionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("EDivisionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("EDivisionAnimalScore");
                GameObject s = GameObject.Find("Canvas/÷minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/÷minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/÷minigame/Lock");
                    b.SetActive(false);
                }
            }
            if (PlayerPrefs.GetInt("difficulty") == 2)
            {
                for (int i = 1; i < 11; i++)
                {
                 int star = PlayerPrefs.GetInt("MDivisionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                         GameObject a = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("MDivisionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/÷" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("MDivisionStars5");
                int starTest1 = PlayerPrefs.GetInt("MDivisionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("MDivisionStars10");
                int starTest2 = PlayerPrefs.GetInt("MDivisionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("MDivisionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("NDivisionAnimalScore");
                GameObject s = GameObject.Find("Canvas/÷minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/÷minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/÷minigame/Lock");
                    b.SetActive(false);
                }
            }
            if (PlayerPrefs.GetInt("difficulty") == 3)
            {   
                for (int i = 1; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HDivisionStars"+ i.ToString());
                    for (int j = 1; j <= star; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;   
                    }  
                }
                for (int i = 2; i < 11; i++)
                {
                    int star = PlayerPrefs.GetInt("HDivisionStars"+ (i-1).ToString());
                    if (star > 1)
                    {
                        GameObject b = GameObject.Find("Canvas/Buttons/÷" + i.ToString());
                        b.GetComponent<Button>().interactable = true;

                        GameObject c = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Lock");
                        c.SetActive(false);

                        for (int j = 1; j <= 3; j++)
                        {
                        GameObject a = GameObject.Find("Canvas/Buttons/÷" + i.ToString() + "/" +"Stars" + i.ToString() + "/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
    
                        }  
                    }
                }

                
                int star5 = PlayerPrefs.GetInt("HDivisionStars5");
                int starTest1 = PlayerPrefs.GetInt("HDivisionStarsTest1");
                    
                if (star5 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/1/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/1");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest1; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/1/Stars1/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }

                int star10 = PlayerPrefs.GetInt("HDivisionStars10");
                int starTest2 = PlayerPrefs.GetInt("HDivisionStarsTest2");
                    
                if (star10 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/2/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/2");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest2; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/2/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                        
                }
                int starTest3 = PlayerPrefs.GetInt("HDivisionStarsTest3");

                if (starTest1 > 1 && starTest2 > 1)
                {
                    GameObject c = GameObject.Find("Canvas/Test/3/Lock");
                    c.SetActive(false);
                    GameObject b = GameObject.Find("Canvas/Test/3");
                    b.GetComponent<Button>().interactable = true;
                    for (int j = 1; j <= starTest3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().texture = m_texture;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        GameObject a = GameObject.Find("Canvas/Test/3/Stars2/" + j.ToString());
                        a.GetComponent<RawImage>().color = new Color(255,255,255,255);
                    }
                }

                int gameScore = PlayerPrefs.GetInt("HDivisionAnimalScore");
                GameObject s = GameObject.Find("Canvas/÷minigame/Text");
                s.GetComponent<Text>().text = gameScore.ToString();

                if (starTest3 > 1)
                {
                    GameObject a = GameObject.Find("Canvas/÷minigame");
                    a.GetComponent<Button>().interactable = true;
                    GameObject b = GameObject.Find("Canvas/÷minigame/Lock");
                    b.SetActive(false);
                }
            }
        }
        
    }
}
