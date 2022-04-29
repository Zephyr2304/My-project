using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject Enemy;
    public int StatusCheck;
    public AudioSource JumpscareMusic;
    public AudioSource ambmusic;


    void DamageZombie (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <=0 && StatusCheck ==0 )
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            Enemy.GetComponent<Animation>().Stop("Z_Walk_InPlace");
            Enemy.GetComponent<Animation>().Play("Z_FallingBack");
            JumpscareMusic.Stop();
            ambmusic.Play();
            


        }
        
    }
}
