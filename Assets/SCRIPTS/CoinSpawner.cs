using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
        //the prefab that we want to instantiat:
        [SerializeField] private GameObject coinprefab;


    // Start is called before the first frame update




    // Update is called once per frame
    void Update()
    {
        // when player presses "spacebar"....
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //....spawn a coin 
            Instantiate(coinprefab, transform.position, Quaternion.identity, transform);
        }
    }
}
