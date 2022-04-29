
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ExitLevel2 : MonoBehaviour
{
    public float distance;
    public GameObject player;
    public GameObject noteUI;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;
    


    void Update()
    {
        distance = PlayerCasting.DistanceFromTarget; 
    }
    void OnMouseOver() {
        if (distance <= 2){
			ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionDisplay.GetComponent<Text> ().text = "Pick up the Note";
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")) {
			if (distance <= 2) {
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
                noteUI.SetActive(true);
                player.GetComponent<FirstPersonController>().enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
			}
		}    
    }
    void OnMouseExit() {
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

    public void ExitButton()
    {
        SceneManager.LoadScene(5);        
    }
    
}
