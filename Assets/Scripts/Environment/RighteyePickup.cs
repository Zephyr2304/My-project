using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RighteyePickup : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;
	public GameObject Righteye;
	public GameObject halffade;
	public GameObject eyeimage;
	public GameObject eyetext;
	public GameObject mazewall;
	

    void Update()   {
        TheDistance = PlayerCasting.DistanceFromTarget;        
    }
    void OnMouseOver() {
        if (TheDistance <= 2){
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text> ().text = "Pick Up Right Eye piece";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCross.SetActive (false);
				GlobalInventory.righteye = true;
				StartCoroutine(EyePicked());
			}
		}    
    }
    void OnMouseExit() {			
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	
	}
	IEnumerator EyePicked(){
		eyeimage.SetActive(true);
		halffade.SetActive(true);
		eyetext.GetComponent<Text>().text = "YOU GOT THE RIGHT EYE PIECE";
		eyetext.GetComponent<Text>().fontSize = 50;
		yield return new WaitForSeconds(2);
		eyetext.GetComponent<Text>().text = "";
		Righteye.SetActive(false);
		halffade.SetActive(false);
		eyeimage.SetActive(false);
		mazewall.GetComponent<Animator>().Play("Mazewall");
		
	}
    
}
