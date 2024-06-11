using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        int speed = 50;

        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
