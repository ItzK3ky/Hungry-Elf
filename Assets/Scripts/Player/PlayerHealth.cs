using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float health = 100f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void KillPlayer()
    {
        Debug.Log("Killed");
        GameObject.Destroy(gameObject);
    }

    //Only called by event
    public void DamagePlayer(Component sender, object data)
    {
        health -= (float)data;

        if(health <= 0)
        {
            KillPlayer();
        }
    }
}
