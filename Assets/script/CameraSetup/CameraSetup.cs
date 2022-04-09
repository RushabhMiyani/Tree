using System.Collections;
using System.Collections.Generic;
using Michsky.UI.ModernUIPack;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CameraSetup : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] Slider slider;
    [SerializeField] UnityAction unityActionchange;
    void Start()
    {
        slider.onValueChanged.AddListener((value)=> {  OnSiderChange(); }) ;
    }
    void OnSiderChange()
    {
        camera.fieldOfView = slider.value;
    }
}
