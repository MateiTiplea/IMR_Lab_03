using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectGrabLeave : MonoBehaviour
{
    public Transform throwPosition;

    public void saveLocation()
    {
        throwPosition.position = transform.position;
    }
}
