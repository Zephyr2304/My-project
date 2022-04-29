using System.Collections;
using UnityEngine;

public class BreakObject : MonoBehaviour
{
    public GameObject fakeObj;
    public GameObject brokenObj;
    public GameObject sphereObject;
    public AudioSource smashsound;
    public GameObject keyobject;


    void DamageZombie(int DamageAmount)
    {
        StartCoroutine(BreakVase());
    }

    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        smashsound.Play();
        keyobject.SetActive(true);
        fakeObj.SetActive(false);
        brokenObj.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sphereObject.SetActive(false);
        yield return new WaitForSeconds(3);
        brokenObj.SetActive(false);

        
    }


}