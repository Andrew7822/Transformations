using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
