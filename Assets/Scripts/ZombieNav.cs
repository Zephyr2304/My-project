using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNav : MonoBehaviour
{
    public Transform Player;
    NavMeshAgent zombieenemy;
    public GameObject Enemy;
    public static bool ischasing;
    public bool AttackTrigger = false;
    public bool IsAttacking = false;
    public AudioClip[] sounds;
    private AudioSource source;
    public GameObject TheFlash;

    void Start(){
        zombieenemy = GetComponent<NavMeshAgent>();
        source = Player.GetComponent<AudioSource>();

    }

    void Update()
    {
        
        if(ischasing==true && AttackTrigger == false)
        {
            Enemy.GetComponent<Animation>().Play("Z_Walk_InPlace");
            zombieenemy.SetDestination(Player.position); 
            transform.LookAt (Player);
            Vector3 direction = Player.position - transform.position;
            Quaternion rotation =  Quaternion.LookRotation(direction,Vector3.up);
            transform.rotation = rotation;
            }
        if(AttackTrigger == true && IsAttacking == false)
        {
            ischasing = false;
            Enemy.GetComponent<Animation>().Play("Z_Attack");
            StartCoroutine(InflictDamage());
        }
        }

        void  OnTriggerEnter() 
        {
            AttackTrigger = true;    

        }
        void  OnTriggerExit() 
        {
            AttackTrigger = false;
            ischasing = true;
            
        }
        IEnumerator InflictDamage()
        {
            IsAttacking =true;
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
            TheFlash.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            TheFlash.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            GlobalHealth.Currenthealth -=10;
            yield return new WaitForSeconds(0.9f);
            IsAttacking = false;
        }
        
    }
