using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BeEaten : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip clip;
    private float volume=1f;
    private bool spaceshipExists = true;
    private bool twoaliensExists = true;
    private bool alienExists = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && spaceshipExists)
        {
            print("E key was pressed");
            GameObject objectToDisappear = GameObject.Find("SpaceshipCake");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
            objectToDisappear = GameObject.Find("E");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            spaceshipExists = false;
        }
        if (Input.GetKeyDown(KeyCode.R) && twoaliensExists)
        {
            print("R key was pressed");
            GameObject objectToDisappear = GameObject.Find("TwoAliensCake");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
            objectToDisappear = GameObject.Find("R");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
            audioSource.PlayOneShot(clip, volume);
            audioSource.Play();
            twoaliensExists = false;
        }
        if (Input.GetKeyDown(KeyCode.T) && alienExists)
        {
            print("R key was pressed");
            GameObject objectToDisappear = GameObject.Find("aliencupcake");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
            objectToDisappear = GameObject.Find("T");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
            audioSource.PlayOneShot(clip, volume);
            audioSource.Play();
            alienExists = false;
        }
    }
}
