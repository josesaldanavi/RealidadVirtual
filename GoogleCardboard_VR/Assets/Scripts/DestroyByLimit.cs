﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByLimit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
