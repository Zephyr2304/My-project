using UnityEngine;
using UnityEngine.UI;


public class EyePlacement : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;
	public GameObject EyePiece;

	public GameObject Realwall;

	

    void Update()   {
        TheDistance = PlayerCasting.DistanceFromTarget;        
    }
    void OnMouseOver() 
	{
		if(GlobalInventory.lefteye == true && GlobalInventory.righteye == true)
		{
			if (TheDistance <= 2)
			{
			ExtraCross.SetActive(true);
			ActionText.GetComponent<Text> ().text = "Place the eye pieces";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
			}
			if (Input.GetButtonDown("Action")) 
			{
				if (TheDistance <= 3)
				{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCross.SetActive (false);
				EyePiece.SetActive(true);
				Realwall.GetComponent<Animator>().Play("Realwall");
				}
			}
		}    
    }
    void OnMouseExit() {
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
    
}
