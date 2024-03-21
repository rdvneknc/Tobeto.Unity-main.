using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        Destroy(other.gameObject);
    }
}
