using System.Collections;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
   public GameObject TheGun;
   public GameObject MuzzleFlash;
   public AudioSource GunFire;
   public bool IsFiring = false;
   public float TargetDistance;
   public int DamageAmount = 5 ;


	void Update () {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.ammocount >=1)
        {
            if (IsFiring == false)
            {
                GlobalAmmo.ammocount -=1;
                StartCoroutine(FiringPistol());
            }
        }
		
	}

    IEnumerator FiringPistol ()
    {
        RaycastHit Shot;
        IsFiring = true;
        if( Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie",DamageAmount, SendMessageOptions.DontRequireReceiver);
            Shot.transform.SendMessage("DamageBoss",DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");
        GunFire.Play();
        yield return new WaitForSeconds(0.3f);
        MuzzleFlash.SetActive(false);
        IsFiring = false;
    }
    // Update is called once per frame
   
}
