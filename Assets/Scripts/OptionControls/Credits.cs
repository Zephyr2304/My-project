using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject exitbutton;

    public void ExitMainMenu(){
    
        SceneManager.LoadScene(1);

    }
}