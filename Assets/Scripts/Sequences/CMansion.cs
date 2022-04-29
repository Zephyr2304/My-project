using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class CMansion : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
        StartCoroutine (ScenePlayer ());
    }
    IEnumerator ScenePlayer (){
        yield return new WaitForSeconds (1);
        FadeScreenIn.SetActive (false);
        TextBox.GetComponent<Text> ().text = "... This Mansion is Big";
        yield return new WaitForSeconds (1);
        TextBox.GetComponent<Text> ().text = "";
        yield return new WaitForSeconds (0.5f);
        TextBox.GetComponent<Text> ().text = "I need to be Careful around here.";
        yield return new WaitForSeconds (1.2f);
        TextBox.GetComponent<Text> ().text = "";
        ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
    }

}
