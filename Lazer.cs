using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f; // defines the speed of the lazer  

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed); // with this code, lazer goes up

        if (transform.position.y > 10.0f) // till where the lazer will go 
        {
            Destroy(this.gameObject); // destroyes the clone
        }
    }
}
