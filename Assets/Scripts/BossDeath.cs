using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class BossDeath : MonoBehaviour
{
    public float BossHealth ;
    public Slider healthslide;
    public GameObject Enemy;
    public int StatusCheck;
    public GameObject mainlight;
    public ActivateBoss gg;
    public StalkerAI se;
    public AudioSource Endingmusic;
    public GameObject ExitDoor;
    public AudioSource death;


    void DamageBoss (int DamageAmount)
    {
        BossHealth -= DamageAmount;

    }

    // Update is called once per frame
    void Update()
    {
        healthslide.value = BossHealth;
        if(BossHealth <=0 && StatusCheck == 0 )
        {
            this.GetComponent<StalkerAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            death.Play();
            Enemy.GetComponent<Animator>().Play("Death");
            se.GetComponent<NavMeshAgent>().speed=0;
            StartCoroutine(End());
        }
    }
    IEnumerator End()
    {
        gg.BattleMusic.Stop();
        healthslide.gameObject.SetActive(false);
        yield return new WaitForSeconds(3.7f);
        Enemy.SetActive(false);
        yield return new WaitForSeconds(2);
        gg.lights.SetActive(false);
        mainlight.SetActive(true);
        Endingmusic.Play();
        ExitDoor.SetActive(true);
    }
}
