using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotSpeed;

    void Update()
    {
        transform.Rotate(Vector3.right, rotSpeed * Time.deltaTime);
    }
}
