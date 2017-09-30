using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedAnimationControllerScript : MonoBehaviour {
    private Animator anim;
    public AudioSource audioSource;
    public AudioClip footstepsAudio;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.A))
        {
            anim.SetBool("FacingRight", false);
            anim.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("FacingRight", true);
            anim.SetBool("isMoving", true);
        }
        else
            anim.SetBool("isMoving", false);
    }

    public void playFootstepsSound()
    {
        audioSource.PlayOneShot(footstepsAudio);
    }
}
