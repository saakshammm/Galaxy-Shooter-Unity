using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2.5f;
    void Start()
    {
        transform.position = new Vector3(0, 7.7f, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -7.0f)
        {
            transform.position = new Vector3(Random.Range(-9.0f, 9.0f), 7.7f, 0);
        }
    }
}
