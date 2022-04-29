
using UnityEngine;
using UnityEngine.UI;
public class ActivateBoss : MonoBehaviour
{
    public GameObject Enemy;
    public AudioSource BattleMusic;
    public float TheDistance;
    public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCross;
    public GameObject lights;
    public GameObject doorlight;
    public Slider healthslide;
	

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
                Enemy.SetActive(true);
                healthslide.gameObject.SetActive(true);
                BattleMusic.Play();
                lights.SetActive(true);
                StalkerAI.isStalking = true;
                gameObject.SetActive(false);  
                doorlight.SetActive(false);   
			}
		}    
    }
    void OnMouseExit() {
		ExtraCross.SetActive(false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
