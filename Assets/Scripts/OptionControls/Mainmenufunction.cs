using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenufunction : MonoBehaviour
{
    public GameObject fadeout;
    public GameObject loadtext;
    public AudioSource buttonclick;
    
    void Start() {
        Cursor.visible=true;
        Cursor.lockState = CursorLockMode.None;  
        GlobalHealth.Currenthealth=100;
        GlobalAmmo.ammocount=0;
        GlobalInventory.firstdoorkey = false;
        GlobalInventory.righteye = false;
        GlobalInventory.lefteye = false;   
        StalkerAI.isStalking=false;
    }
    public void NewgameButton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        fadeout.SetActive(true);
        buttonclick.Play();
        yield return new WaitForSeconds(3);
        loadtext.SetActive(true);
        SceneManager.LoadScene(2);

    }
    public void loadlevel1()
    {
        StartCoroutine(loadgame1());
    }
    IEnumerator loadgame1()
    {
        fadeout.SetActive(true);
        buttonclick.Play();
        yield return new WaitForSeconds(3);
        loadtext.SetActive(true);
        SceneManager.LoadScene(3);

    }
    public void loadlevel2()
    {
        StartCoroutine(loadgame2());
    }
    IEnumerator loadgame2()
    {
        fadeout.SetActive(true);
        buttonclick.Play();
        yield return new WaitForSeconds(3);
        loadtext.SetActive(true);
        SceneManager.LoadScene(4);
    }
    public void loadBoss()
    {
        StartCoroutine(Bossscene());
    }
    IEnumerator Bossscene()
    {
        fadeout.SetActive(true);
        buttonclick.Play();
        yield return new WaitForSeconds(3);
        loadtext.SetActive(true);
        SceneManager.LoadScene(5);
        GlobalHealth.Currenthealth = 100;

    }
    public void LoadCredits()
    {
        StartCoroutine(Credits());
    }
    IEnumerator Credits(){
        fadeout.SetActive(true);
        buttonclick.Play();
        yield return new WaitForSeconds(3);
        loadtext.SetActive(true);
        SceneManager.LoadScene(6);

    }

    public void Exit()
    {
        fadeout.SetActive(true);
        buttonclick.Play();
        Debug.Log("QUIT");
        Application.Quit();

    }

}
