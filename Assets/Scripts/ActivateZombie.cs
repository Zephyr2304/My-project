
using UnityEngine;

public class ActivateZombie : MonoBehaviour
{
    public AudioSource scare;
    public AudioSource jump;
    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        scare.Play();
        jump.Stop();
        ZombieNav.ischasing = true;
        
    }
}
