using UnityEngine;
using System.Collections.Generic;

public class CameraSwapSystem : MonoBehaviour
{
    //THIS IS AN EXAMPLE SCRIPT SHOWCASING A VERY SIMPLE CAMERA SWITCHING SYSTEM. 
    //===============================
    //NOTE: This script is meant for projects where the player/object is moving in a controlled and linear fashion through the space. 

    
    //Step 1: We create two Camera Component variables- cameraOff turns off the current active camera. cameraOn enables the new camera. 
    public Camera cameraOn;
    public Camera cameraOff;

    //YOU CAN USE ARRAYS TO MAKE A LIST OF CAMERAS IN YOUR SCENE BASED ON TAGS. 

    public GameObject[] allCameras;//Step 1.1: Create an array that will store all the cameras in the scene. 

    void Start()
    {
        allCameras = GameObject.FindGameObjectsWithTag("MainCamera");//Step 2.1: We tell Unity to add every gameobject with the tag "MainCamera" into our array. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)//Step 2: When the trigger/collider detects the player, it will switch the camera to a new view. 
    {
        
        if (other.gameObject.tag == "Player")//NOTE: Since you are doing a physics assignment it's important to specify which object will activate the trigger/collider.
        {
           //Once the player collides with the trigger, it will switch to the next camera while disablin the previous one.  
            cameraOn.enabled = true;
            cameraOff.enabled = false;

            //=========================
            //NOTE: IF YOU ARE NOT USING THE ARRAY METHOD LEAVE THE BELOW CODE COMMENTED OUT. 

            //Step 3.1: Similar to the above method, we can call on cameras within the list and disable/enable them through there. 
            //The downside to this however is that you have to remember where in the array Unity assigns the camera gameobjects.  

            //Camera offCam = allCameras[5].GetComponent<Camera>();   
            //Camera onCam= allCameras[4].GetComponent<Camera>();
            //onCam.enabled = true;
            //offCam.enabled = false;

        }
    }
}
