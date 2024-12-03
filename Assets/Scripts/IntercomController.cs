using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntercomController : MonoBehaviour
{

    public AudioClip currentClip;
    public List<Transform> intercoms = new List<Transform>();
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Transform child in transform)
        {
            intercoms.Add(child);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateIntercom(AudioClip clip)
    {
        
        foreach(Transform intercom in intercoms)
        {
            var audioSource = intercom.GetComponent<AudioSource>();
            if (currentClip == clip) return;

            currentClip = clip;
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}
