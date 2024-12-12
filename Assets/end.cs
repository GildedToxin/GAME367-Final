using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public fade image;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<PlayerMovement>()) return;
        image = FindAnyObjectByType<fade>();

        image.fadeOut = true;

    }
}
