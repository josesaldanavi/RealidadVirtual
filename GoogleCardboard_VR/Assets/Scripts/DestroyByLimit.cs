using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByLimit : MonoBehaviour
{
    private float life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }

    

}
