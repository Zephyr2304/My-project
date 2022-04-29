using UnityEngine;
using UnityEngine.AI;

public class ZombieNavDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject Enemy;
    public int StatusCheck;
    public AudioSource ambmusic;
    public ZombieNav stop;


    void DamageZombie (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        if(EnemyHealth <=0 && StatusCheck ==0 )
        {
            this.GetComponent<ZombieNav>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            Enemy.GetComponent<Animation>().Stop("Z_Walk_InPlace");
            Enemy.GetComponent<Animation>().Play("Z_FallingBack");
            stop.GetComponent<NavMeshAgent>().speed = 0;
            ambmusic.Play();

        }

        }
        
    }
