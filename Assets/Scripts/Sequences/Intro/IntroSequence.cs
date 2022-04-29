using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IntroSequence : MonoBehaviour
{
    public GameObject textbox;
    public GameObject datedisplay;
    public GameObject placedisplay;
    public AudioSource line01;
    public AudioSource line02;
    public AudioSource line03;
    public AudioSource line04;
    public AudioSource line05;

    public AudioSource thudSound;
    public GameObject allBlack;
    public GameObject loadText;
    public GameObject skipbutton;

    void Start()
    {
        StartCoroutine(sequenceBegin());
    }

    IEnumerator sequenceBegin()
    {
        yield return new WaitForSeconds(3);
        placedisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        datedisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placedisplay.SetActive(false);
        datedisplay.SetActive(false);
        skipbutton.SetActive(true);
        yield return new WaitForSeconds(2);
        textbox.GetComponent<Text>().text = "The night of October 29th 2008 changed me forever";
        line01.Play();
        yield return new WaitForSeconds(4);
        textbox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        textbox.GetComponent<Text>().text = "I headed out to investigate the haunting sounds in the woods.";
        line02.Play();
        yield return new WaitForSeconds(4);
        textbox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(18);
        textbox.GetComponent<Text>().text = "I stumbled upon a clearing with a cabin in the distance.";
        line03.Play();
        yield return new WaitForSeconds(5);
        textbox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(8);
        textbox.GetComponent<Text>().text = "I could hear those sounds again coming from there.";
        line04.Play();
        yield return new WaitForSeconds(4);
        textbox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(12);
        textbox.GetComponent<Text>().text = "Little did I know that this was only the beginning.";
        line05.Play();
        yield return new WaitForSeconds(4);
        textbox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(30);
        allBlack.SetActive(true);
        thudSound.Play();
        loadText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    public void SkipCutscene(){
        StartCoroutine(Skip());

    }
    IEnumerator Skip(){
        skipbutton.SetActive(false);
        allBlack.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(3);

    }


}
