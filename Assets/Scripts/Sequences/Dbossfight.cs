using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class Dbossfight : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    // public AudioSource line01;
    // public AudioSource line02;

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
        StartCoroutine (ScenePlayer ());
    }
    IEnumerator ScenePlayer (){
        yield return new WaitForSeconds (1.5f);
        FadeScreenIn.SetActive (false);
        TextBox.GetComponent<Text> ().text = "Woah, How did I get here ??";
        yield return new WaitForSeconds (2);
        TextBox.GetComponent<Text> ().text = "";
        yield return new WaitForSeconds (0.5f);
        TextBox.GetComponent<Text> ().text = "Something is Wrong!";
        yield return new WaitForSeconds (1.7f);
        TextBox.GetComponent<Text> ().text = "";
        yield return new WaitForSeconds (0.8f);
        TextBox.GetComponent<Text> ().text = "... I think that the Exit";
        yield return new WaitForSeconds (1.5f);    
        TextBox.GetComponent<Text> ().text = "";
        ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
    }

}
