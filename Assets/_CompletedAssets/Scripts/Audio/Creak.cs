using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Creak : MonoBehaviour
{
    private AudioSource source;
    public AudioClip creak;
    private float low = 0.75f;
    private float high = 1.25f;
    public List<AudioClip> audioClips = new List<AudioClip>();
    //private WaitForSeconds seconds;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private bool waiting = false;
    private void OnTriggerEnter(Collider other)

    {
      
        if (!waiting)
        {
            int randomclip = Random.Range(0, audioClips.Count);
            Debug.Log("OnTriggerEnter" + Time.time);
            float randomVol = Random.Range(0.3f, 0.8f);
            source.volume = randomVol;

            float randomPitch = Random.Range(1, 3);
            source.pitch = randomPitch;



            float randomTrigger = Random.Range(0f, 1f);
            if (randomTrigger > 0.2f && (other.CompareTag("creak") || other.CompareTag("Player")))
            {
                source.PlayOneShot(audioClips[randomclip]);
                waiting = true;
                StartCoroutine(PauseSound());
            }
        }
    
    }

    private IEnumerator PauseSound()
    {
        yield return new WaitForSeconds(30f);
        waiting = false;
    }
}
