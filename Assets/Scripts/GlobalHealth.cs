
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject player;
    public static int Currenthealth = 100;
    public Slider slider;
    public int internalhealth;
    

    void Update()
    {
        slider.value = Currenthealth;
        internalhealth = Currenthealth;
        if(GlobalHealth.Currenthealth <= 0){
            player.GetComponent<FirstPersonController>().enabled = false;
            SceneManager.LoadScene(7);
            // Cursor.visible=true;
            // Cursor.lockState = CursorLockMode.None;
           
            }
        if (Currenthealth >100){
            Currenthealth = 100;
        }
    }
    
}