using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour 
{
    
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;
    public GameObject coinInstance;
    public Text countText;
    private static int count;

    private void Start()
    {
        count = 0;
        SetCountText (); // for displaying score
    }
    void Update()
    {
        //rotation coin 180 degrees every second
        coinInstance.transform.Rotate(Vector3.up * (Time.deltaTime * 180), Space.World);
    }
    
    public void OnCoinClicked() {
        if (coinInstance != null) { 
        // Instantiate the CoinPoof Prefab where this coin is located
        Instantiate (coinPoof, new Vector3(coinInstance.transform.position.x, 0, coinInstance.transform.position.z), Quaternion.Euler(-90, 0, 0));
            // Make sure the poof animates vertically
            count = count + 5;
            SetCountText ();
            // Destroy this coin. Check the Unity documentation on how to use Destroy
            Destroy(coinInstance); }
    }
    void SetCountText()
    {
        countText.text = "Bonus Score: " + count.ToString();
    }
}
