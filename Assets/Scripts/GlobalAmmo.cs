
using UnityEngine;
using  UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int ammocount;
    public GameObject ammodisplay;
    public int internalammo;

    void Update()
    {
        internalammo = ammocount;
        ammodisplay.GetComponent<Text>().text="" + ammocount;
        
    }
}
