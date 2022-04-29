using UnityEngine;
using UnityEngine.UI;

public class PickupGun : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakePistol;
	public GameObject GuidedArrow;
	public GameObject RealPistol;
	public GameObject ExtraCross;
	public GameObject TheJumpTrigger;
    void Update()   {
        TheDistance = PlayerCasting.DistanceFromTarget;        
    }
    void OnMouseOver() {
        if (TheDistance <= 3){
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text> ().text = "Pick Up the Gun";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 3) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				FakePistol.SetActive (false);
				RealPistol.SetActive (true);
				ExtraCross.SetActive (false);
				GuidedArrow.SetActive (false);	
				TheJumpTrigger.SetActive(true);
			}
		}    
    }
    void OnMouseExit() {
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
    
}
