using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerBox : MonoBehaviour
{
    public bool hasPlayed = false;
    public IntercomController intercom;
    public AudioClip voiceLine;
    // Start is called before the first frame update
    void Awake()
    {
        intercom = FindFirstObjectByType<IntercomController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasPlayed) return;
        print("entered");
        if (!other.GetComponent<PlayerMovement>()) return;

        intercom.UpdateIntercom(voiceLine);
        hasPlayed = true;
    }
}
