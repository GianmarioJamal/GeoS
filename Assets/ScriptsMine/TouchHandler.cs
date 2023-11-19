using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    // Define the URL you want to open
    //private string googleLink = "http://www.google.com/";
    public string googleLink = "http://www.google.com/";

    void Update()
    {
        // Check if a touch occurred
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Raycast from the touch position to detect if it hits the object
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            // Check if the ray hits the object
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the object that was hit is the one you want to open the link for
                if (hit.collider.gameObject == gameObject)
                {
                    // Open the Google link in the default web browser
                    Application.OpenURL(googleLink);
                }
            }
        }
    }
}
