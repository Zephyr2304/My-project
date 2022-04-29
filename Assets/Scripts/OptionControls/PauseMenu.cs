using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    public GameObject fadeout;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            if(GameisPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;

    }
    void Pause(){
        Cursor.visible=true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameisPaused = true;
        

    }
    public void PauseExit(){
        SceneManager.LoadScene(1);   
        Time.timeScale = 1f;
        GameisPaused=false;
       
    }     
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GlobalHealth.Currenthealth=100;
        GlobalAmmo.ammocount=0;
        GlobalInventory.firstdoorkey = false;
        GlobalInventory.righteye = false;
        GlobalInventory.lefteye = false; 
        StalkerAI.isStalking=false; 
        Time.timeScale = 1f;
        
    }
}
