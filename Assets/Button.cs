using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public AudioClip clip;
    public AudioTriggerBox box;
    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<AudioTriggerBox>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<PlayerMovement>()) return;


        other.GetComponent<PlayerMovement>().button = this;


    }

    public void playAudio()
    {

    }
}
