using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BurnerButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pressing = false;
    public AirshipController ac;
    public AudioSource burnerAudio;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
        burnerAudio.Play();
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
            ac.Burn();
        } else
        {
            ac.StopBurn();
        }
    }
}
