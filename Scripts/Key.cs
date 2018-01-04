using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public Door door;
    public GameObject keyPoof;
    public GameObject keyInstance;
    
    // public GameObject directions;

	void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        keyInstance.transform.Rotate(Vector3.up * (Time.deltaTime * 180), Space.World);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        if (keyInstance != null)
        {
            Instantiate(keyPoof, transform.position, Quaternion.Euler(-90, 0, 0));

            // Call the Unlock() method on the Door
            // var openDoor = door.GetComponent<Door>();
            door.Unlock();
            // Set the Key Collected Variable to true
            // Destroy the key. Check the Unity documentation on how to use Destroy
            Destroy(keyInstance);
        }
    }

}
