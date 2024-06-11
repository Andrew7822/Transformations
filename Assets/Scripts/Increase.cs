using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase : MonoBehaviour
{
    void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime;
    }
}
