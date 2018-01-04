using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{
    public Door door1;
    public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
        door1.Lock();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}