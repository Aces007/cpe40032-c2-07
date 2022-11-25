using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 2;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog, block of codes provide a cooldown for the dog to respawn.
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 2;
        }
        if (cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
        
    }
}
