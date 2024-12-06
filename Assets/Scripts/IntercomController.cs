using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntercomController : MonoBehaviour
{

    public AudioClip currentClip;
    public AudioTriggerBox lastBox;
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
        foreach (Transform intercom in intercoms)
        {
            if (!intercom.GetComponent<AudioSource>().isPlaying && lastBox != null && lastBox.gate != null)
            {
                lastBox.gate.transform.position = Vector3.Lerp(lastBox.gate.transform.position, new Vector3(lastBox.gate.transform.position.x, lastBox.gate.transform.position.y - 8, lastBox.gate.transform.position.z), 0.01f);
            }
        }
    }

    public void UpdateIntercom(AudioClip clip, AudioTriggerBox box)
    {
        lastBox = box;
        
        foreach(Transform intercom in intercoms)
        {
            var audioSource = intercom.GetComponent<AudioSource>();
           if (audioSource.clip == clip) return;

            currentClip = clip;
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}
