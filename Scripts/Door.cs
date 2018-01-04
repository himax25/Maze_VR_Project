using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    private static bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool opening = false;
    // Animation Clipping for door movements - Idle, Openning, Opened
    public Animator doorMovement;

    private AudioSource audioSource;
    public AudioClip doorLocked;
    public AudioClip doorOpened;

    void Start()
    {
        doorMovement = GetComponent<Animator>();
    }

    void Update()
    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if ((opening) && (!locked)) {
            GetComponent<BoxCollider>().enabled = false;
        } 
    }

    public void OnDoorClicked()
    {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        if ((locked == false) && (opening == false)) {
            opening = true;
            doorMovement.SetTrigger("TheKey");
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(doorOpened);
        } else
        {
            // (optionally) Else
            // Play a sound to indicate the door is locked
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(doorLocked);
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }

    public void Lock() {
        // You'll need to reset to "lock" here after reloading the game.
        locked = true;
        opening = false;
        }
}
