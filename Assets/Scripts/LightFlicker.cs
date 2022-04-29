using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light bulb;
    // public AudioSource lightsound;
    public float mintime;
    public float maxtime;
    public float timer;
    void Start()
    {
        timer = Random.Range(mintime,maxtime);
    }

    // Update is called once per frame
    void Update()
    {
        lightflickering();
    }
    void lightflickering()
    {
        if (timer > 0)
            timer -= Time.deltaTime;

        if(timer <= 0)
        {
            bulb.enabled = !bulb.enabled;
            timer = Random.Range(mintime, maxtime);
            // lightsound.Play();
    

    }
    }

}
