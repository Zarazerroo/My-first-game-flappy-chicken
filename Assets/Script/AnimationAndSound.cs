using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAndSound : MonoBehaviour
{
    private Animator animator;
    private bool isJumping = false;
    public AudioClip jumpAudioClip; // Drag your jump audio clip to this field in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();

        // Get or add an AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Check for the space bar input
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            // Set the boolean parameter to true
            isJumping = true;

            // Trigger the animation
            animator.SetBool("IsJumping", true);

            // Play the jump audio
            if (jumpAudioClip != null)
            {
                audioSource.PlayOneShot(jumpAudioClip);
            }
        }
    }

    // This function is called at the end of the animation (set it up in the animation window)
    public void OnJumpAnimationEnd()
    {
        // Set the boolean parameter back to false
        isJumping = false;

        // Reset the animation state
        animator.SetBool("IsJumping", false);
    }
}
