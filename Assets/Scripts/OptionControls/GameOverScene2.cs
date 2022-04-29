using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene2 : MonoBehaviour
{
    public int LoadScene;

    void Start()
    {
        LoadScene = PlayerPrefs.GetInt("AutoSave");
        Cursor.visible=true;
        Cursor.lockState = CursorLockMode.None;  
        GlobalHealth.Currenthealth=100;
        GlobalAmmo.ammocount=0;
        GlobalInventory.firstdoorkey = false;
        GlobalInventory.righteye = false;
        GlobalInventory.lefteye = false; 
        StalkerAI.isStalking=false;     
    }
       
    public void Loadbutton()
    {
        SceneManager.LoadScene(LoadScene);
    }
    public void ExitMainMenu(){
        SceneManager.LoadScene(1);
    }
}

