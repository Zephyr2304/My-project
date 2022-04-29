using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    // public GameObject Ammo;
    public GameObject Ammodisplaybox;
    // Start is called before the first frame update
    void OnTriggerEnter() 
    {
        Ammodisplaybox.SetActive(true);
        GlobalAmmo.ammocount +=7;
        gameObject.SetActive(false);  
    }
    // Update is called once per frame
    
}
