using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSettings : MonoBehaviour
{
    public Dropdown dropdown;
    public Toggle toggle;
    Resolution[] res;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Fullscreen"))
        {
            if (PlayerPrefs.GetInt("Fullscreen") == 0)
            {
                Screen.fullScreen = false;
                toggle.isOn = !Screen.fullScreen;
            }
            else
            {
                Screen.fullScreen = true;
                toggle.isOn = !Screen.fullScreen;
            }
        }
        else
        {
            Screen.fullScreen = true;
            toggle.isOn = !Screen.fullScreen;
        }
        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();

        string[] strRes = new string[res.Length];
        for (int i = 0; i < res.Length; i++)
        {
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();
        }


        dropdown.ClearOptions();
        dropdown.AddOptions(strRes.ToList());
        if (PlayerPrefs.HasKey("Resolution"))
        {
            dropdown.value = PlayerPrefs.GetInt("Resolution");
            Screen.SetResolution(res[PlayerPrefs.GetInt("Resolution")].width, res[PlayerPrefs.GetInt("Resolution")].height, Screen.fullScreen);
        }
        else
        {
            dropdown.value = res.Length - 1;
            Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);
        }
    }

    public void SetRes()
    {
        Screen.SetResolution(res[dropdown.value].width, res[dropdown.value].height, Screen.fullScreen);
        PlayerPrefs.SetInt("Resolution", dropdown.value);
    }

    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
        if (Screen.fullScreen)
        {
            PlayerPrefs.SetInt("FullScreen", 1);
        }
        else
        {
            PlayerPrefs.SetInt("FullScreen", 0);
        }
    }
}
