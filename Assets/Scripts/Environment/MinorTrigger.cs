using System.Collections;
using UnityEngine;

public class MinorTrigger : MonoBehaviour
{
    public GameObject cup;
    public GameObject trigger;
    
    void OnTriggerEnter() {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        trigger.SetActive(true);
        StartCoroutine(DeactivateSphere());

    }
    IEnumerator DeactivateSphere(){
        yield return new WaitForSeconds(1);
        trigger.SetActive(false);
        yield return new WaitForSeconds(3);
        cup.SetActive(false);

    }

}
