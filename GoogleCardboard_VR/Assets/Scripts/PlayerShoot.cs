using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera cameraPlayer;
    // Update is called once per frame
    void Update()
    {
        
            Shoot();
        
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cameraPlayer.transform.position, cameraPlayer.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            RotationRandom target = hit.transform.GetComponent<RotationRandom>();
            
            if(target != null)
            {
                target.TakeDamage(damage);
            }

        }
    }

    void PlayerGame()
    {
        RaycastHit playGame;
        if (Physics.Raycast(cameraPlayer.transform.position, cameraPlayer.transform.forward, out playGame, range))
        {

        }

    }
}
