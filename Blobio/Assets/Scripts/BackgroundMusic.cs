using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Reference to the AudioSource component
     private AudioSource audioSource;
     private AudioSource audioSource2;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        
        audioSource = GetComponent<AudioSource>();
        // Play the background music
        audioSource.Play();
    }

    // You can add more methods to control the background music, such as pausing or stopping it.
}