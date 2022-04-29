using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashtomenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TaketoMenu());   
    }
    IEnumerator TaketoMenu(){
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(1);
    }

}
