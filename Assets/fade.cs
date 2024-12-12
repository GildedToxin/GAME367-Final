using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
    public Image image;
    public AudioSource audioSource;
    

    public bool fadeOut = false;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!fadeOut)
            image.color = new Color(0, 0, 0, Mathf.Lerp(image.color.a, 0, .01f));
        else
            image.color = new Color(0, 0, 0, Mathf.Lerp(image.color.a, 1, .018f));
       
        if (audioSource.isPlaying)
        {
            print("yes");
        }
        if(fadeOut == true && !audioSource.isPlaying && image.color.a >= .99f)
        {
            print("QUIT GAME");
            Application.Quit();

        }
        else 
        {
           // print(image.color.a);
        }
    }
}
