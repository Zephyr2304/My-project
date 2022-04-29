using System.Collections;

using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent StalkerAgent;
    public GameObject Enemy;
    public static bool isStalking;
    public GameObject flash;
    public bool AttackTrigger = false;
    public bool IsAttacking = false;
    void Start()
    {
        StalkerAgent = GetComponent<NavMeshAgent>();       
    }
     void Update()
    {
        if (isStalking == true && AttackTrigger == false)
        {
            Enemy.GetComponent<Animator>().Play("Crouched Walking");
            StalkerAgent.SetDestination(Player.position);
            transform.LookAt (Player);
            Vector3 direction = Player.position - transform.position;
        }
        else if(AttackTrigger == true && IsAttacking ==false){
            Enemy.GetComponent<Animator>().Play("Zombie Attack");
            StartCoroutine(InflictDamage());

        }
        else {
            Enemy.GetComponent<Animator>().Play("Idle");
            }
    
            
        
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
            flash.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            flash.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            GlobalHealth.Currenthealth -=20;
            yield return new WaitForSeconds(0.9f);
            IsAttacking = false;
        }
        
}
