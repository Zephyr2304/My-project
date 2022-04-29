using System.Collections;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float EnemySpeed ;
    public bool AttackTrigger = false;
    public bool IsAttacking = false;
    public AudioClip[] sounds;
    private AudioSource source;
    public GameObject TheFlash;

    void Start(){
        source = Player.GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.LookAt (Player.transform);
        if(AttackTrigger == false)
        {
            Enemy.GetComponent<Animation>().Play("Z_Walk_InPlace");
            EnemySpeed = 0.02f ;
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
            }
        if(AttackTrigger == true && IsAttacking == false)
        {
            EnemySpeed = 0;
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
