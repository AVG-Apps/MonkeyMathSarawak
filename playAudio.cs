using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public string name;

    public void startClip()
    {
        // StartCoroutine(playClip());
    }

    //Play Audio Clip
    public void playClip()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        Debug.Log("111");
        // yield return new WaitForSeconds(audioSource.clip.length);
        // wchangeScene(name);
        SceneManager.LoadScene(name);
        
    }
    
    //Load audio
    public void changeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
