using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;
    void Start()
    {
       Vector3 pos = transform.position;
       pos.y -= 0.7f;
       transform.position = pos;
    }


    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);

        if (transform.position.y > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
