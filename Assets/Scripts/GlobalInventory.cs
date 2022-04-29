
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool firstdoorkey = false;
    public bool internaldoorkey;
    public static bool righteye = false;
    public static bool lefteye = false;
    public GameObject fakewall;
	public GameObject realwall;
    // Update is called once per frame
    void Update()
    {
        internaldoorkey = firstdoorkey;      
        if(GlobalInventory.righteye == true && GlobalInventory.lefteye ==true){
            fakewall.SetActive(false);
            realwall.SetActive(true);
        } 
    }
}
