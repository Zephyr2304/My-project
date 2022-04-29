using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;
	public AudioSource lockeddoor;
	public GameObject Firstkeydoor;
	public AudioSource creakdoor;
	public GameObject TextBox;

    void Update()   {
        TheDistance = PlayerCasting.DistanceFromTarget;        
    }
    void OnMouseOver() {
        if (TheDistance <= 2){
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text> ().text = "Open Door";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCross.SetActive (false);
				StartCoroutine(DoorReset());
			}
		}    
    }
    void OnMouseExit() {
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
	IEnumerator  DoorReset()
	{
		if(GlobalInventory.firstdoorkey == false){
			lockeddoor.Play();
			TextBox.GetComponent<Text> ().text = "The Door is Locked";
        	yield return new WaitForSeconds (0.5f);
        	TextBox.GetComponent<Text> ().text = "";
        	yield return new WaitForSeconds (0.5f);
        	TextBox.GetComponent<Text> ().text = "I need to Find the Key.";
        	yield return new WaitForSeconds (1);
			TextBox.GetComponent<Text> ().text = "";
			yield return new WaitForSeconds(0.5f);
			this.GetComponent<BoxCollider>().enabled = true;
		}
		else{
			Firstkeydoor.GetComponent<Animator>().Play("Firstdoor");
			creakdoor.Play();
			yield return new WaitForSeconds(1.1f);
			this.GetComponent<BoxCollider>().enabled = false;
		}
	}
    
}
