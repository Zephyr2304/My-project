
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public GameObject HealthBox;
    void OnTriggerEnter() 
    {
        HealthBox.SetActive(true);
        GlobalHealth.Currenthealth += 20;
        gameObject.SetActive(false);  
    }
    
}
