using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSwitch : MonoBehaviour
{
    public GameObject musicOn, musicOff, soundOn, soundOff;
    public void OnChangeValue()
    {
        bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn;
        if (onoffSwitch)
        {
            musicOn.SetActive(true);
            musicOff.SetActive(false);
        }
        if (!onoffSwitch)
        {
            musicOn.SetActive(false);
            musicOff.SetActive(true);
        }
    }
}
