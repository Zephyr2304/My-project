
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Ladder : MonoBehaviour
{

    public Transform playerController;
    bool inside = false;
    public float speed = 3.2f;
    public FirstPersonController player;

    void Start()
    {
        player = GetComponent<FirstPersonController>();
        inside = false;

    }
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Ladder")
        {
           
            player.enabled = false;
            inside = !inside;
        }


    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Ladder")
        {
          
            player.enabled = true;
            inside = !inside;
            
        }


    }

    void Update()
    {
        if(inside == true && Input.GetKey("w"))
        {
			player.transform.position += Vector3.up / speed * Time.deltaTime ;
            }
        if(inside == true && Input.GetKey("s"))
        {
            player.transform.position += Vector3.down /speed * Time.deltaTime ;
        }

    }

}