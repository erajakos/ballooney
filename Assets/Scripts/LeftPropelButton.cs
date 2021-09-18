using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftPropelButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pressing = false;
    public AirshipController ac;
    public AudioSource propellerAudio;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
        propellerAudio.Play();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pressing)
        {
            ac.RotateLeftPropel();
        }
    }
}
