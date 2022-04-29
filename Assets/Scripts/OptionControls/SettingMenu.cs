
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown resolutiondrop;
    Resolution[] resolutions;
    void  Start() {

        resolutions = Screen.resolutions;
        resolutiondrop.ClearOptions();
        List<string> options = new List<string>();
        int currentResindex = 0;
        for(int i = 0; i < resolutions.Length;i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " @ " + resolutions[i].refreshRate + "hz";
            options.Add(option);

            if(resolutions[i].width == Screen.width &&
            resolutions[i].height == Screen.height )
            {
                currentResindex =i;
            }

        }
        resolutiondrop.AddOptions(options);
        resolutiondrop.value = currentResindex;
        resolutiondrop.RefreshShownValue();
    }

    public void setResolution(int resIndex)
    {
        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume( float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
       
    }
    public void setQuality (int qualityindex){
        QualitySettings.SetQualityLevel(qualityindex);


    }
    public void setFullScreen (bool isFullscreen){
        Screen.fullScreen = isFullscreen;
    }

  
}
