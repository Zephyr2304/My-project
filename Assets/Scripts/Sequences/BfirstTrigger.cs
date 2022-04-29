using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;


public class BfirstTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject TheMarker;
    public GameObject FirstTrigger;
    public AudioSource line03;

    void  OnTriggerEnter() {
        ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
        StartCoroutine (ScenePlayer ());
        
    }

    IEnumerator ScenePlayer() {
        TextBox.GetComponent<Text> ().text = "Looks like a weapon on the table";
        line03.Play();
        yield return new WaitForSeconds (1.5f);
        TextBox.GetComponent<Text> ().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled =true;
        TheMarker.SetActive(true);
        FirstTrigger.GetComponent<BoxCollider>().enabled = false;
    }


}
