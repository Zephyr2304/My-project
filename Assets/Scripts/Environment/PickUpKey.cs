using UnityEngine;
using UnityEngine.UI;

public class PickUpKey : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;
	public GameObject TheKey;

    void Update()   {
        TheDistance = PlayerCasting.DistanceFromTarget;        
    }
    void OnMouseOver() {
        if (TheDistance <= 3){
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text> ().text = "Pick Up Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 3) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCross.SetActive (false);
				TheKey.SetActive(false);
				GlobalInventory.firstdoorkey = true;
			}
		}    
    }
    void OnMouseExit() {
		if(TheDistance > 2){	
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
	}
    
}
