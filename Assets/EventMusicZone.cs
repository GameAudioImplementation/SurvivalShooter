using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMusicZone : MonoBehaviour
{
    public AudioClip eventClip;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
        AudioManager.manager.eventMusic.clip = eventClip;
        AudioManager.manager.StartCoroutine("PlayEventMusic");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
