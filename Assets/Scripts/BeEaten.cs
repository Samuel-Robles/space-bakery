using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BeEaten : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("E key was pressed");
            GameObject objectToDisappear = GameObject.Find("SpaceshipCake");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("R key was pressed");
            GameObject objectToDisappear = GameObject.Find("TwoAliensCake");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            print("R key was pressed");
            GameObject objectToDisappear = GameObject.Find("aliencupcake");
            objectToDisappear.GetComponent<Renderer>().enabled = false;
        }
    }
}
