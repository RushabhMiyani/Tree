using System.Collections;
using System.Collections.Generic;
using Michsky.UI.ModernUIPack;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CameraSetup : MonoBehaviour
{
    public static CameraSetup mycamera;
    [SerializeField] Camera camera;
    [SerializeField] Slider slider;
    [SerializeField] UnityAction unityActionchange;
    public GameObject Target;
    [SerializeField] Vector3 Offset;
    void Start()
    {
        if (mycamera == null) { mycamera = this; }
        else{ Destroy(this); }
        slider.onValueChanged.AddListener((value)=> {  OnSiderChange(); }) ;
    }

    private void Update()
    {
        if(Target != null)
        {
            camera.transform.position = Offset + Target.transform.position;
        }
    }
    private void OnValidate()
    {
        OnSiderChange();
    }
    void OnSiderChange()
    {
        camera.fieldOfView = slider.value;
    }

}
