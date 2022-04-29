using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class StalkerAI : MonoBehaviour
{
    public Transform player;
    NavMeshAgent StalkerAgent;
    public GameObject Enemy;
    public static bool isStalking;
    public AudioClip[] sounds;
    private AudioSource source;
    public GameObject flash;
    public bool AttackTrigger = false;
    public bool IsAttacking = false;
    void Start()
    {
        StalkerAgent = GetComponent<NavMeshAgent>(); 
        source = player.GetComponent<AudioSource>();      
    }
     void Update()
    {
        if (isStalking == true && AttackTrigger == false)
        {
            Enemy.GetComponent<Animator>().Play("Crouched Walking");
            StalkerAgent.SetDestination(player.position);
            transform.LookAt (player);
            Vector3 direction = player.position - transform.position;
            Quaternion rotation =  Quaternion.LookRotation(direction,Vector3.up);
        }
        else if(AttackTrigger == true && IsAttacking ==false){
            // Enemy.GetComponent<Animator>().Play("Zombie Attack");
            StartCoroutine(InflictDamage());

        }
        // else {
        //     // Enemy.GetComponent<Animator>().Play("Zombie Attack");
        //     }     
    }
        void  OnTriggerEnter() 
        {
            AttackTrigger = true;  
            isStalking = false;
        }
        void  OnTriggerExit() 
        {
            AttackTrigger = false;
            isStalking = true;
            
        }
    IEnumerator InflictDamage()
        {  
            IsAttacking = true;
            Enemy.GetComponent<Animator>().Play("Zombie Attack");
            yield return new WaitForSeconds(0.9f);
            source.clip = sounds[Random.Range(0, sounds.Length)];
            yield return new WaitForSeconds(0.4f);
            source.Play();
            flash.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            flash.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            GlobalHealth.Currenthealth -=20;
            yield return new WaitForSeconds(0.9f);
            IsAttacking = false;
        }
        
}
