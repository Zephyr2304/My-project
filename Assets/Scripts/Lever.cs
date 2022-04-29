using UnityEngine;
using UnityEngine.UI;
public class Lever : MonoBehaviour
{
    public GameObject leverwall;
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;

    void Update()   {
        TheDistance = PlayerCasting.DistanceFromTarget;        
    }
    void OnMouseOver() {
        if (TheDistance <= 2){
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text>().text = "Pull the lever";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCross.SetActive (false);
                leverwall.GetComponent<Animator>().Play("Lever");


			}
		}    
    }
    void OnMouseExit() {			
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	
	}

}
