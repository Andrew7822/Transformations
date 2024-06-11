using UnityEngine;

public class Magnifier : MonoBehaviour
{
    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime;
    }
}
