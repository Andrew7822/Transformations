using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(Vector3.down * 50 * Time.deltaTime);
    }
}
