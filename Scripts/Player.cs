using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float _speed = 5.3f; // speed of the space ship
    [SerializeField]
    private GameObject _lazerPrefab;
    [SerializeField]
    private float _fireRate = 0.1f;
    [SerializeField]
    private float _canFire = -1f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0); // sets the initial position
    }

    void Update()
    {
        CalculateMovement(); // calls the movement function

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            FireLazer();
        }
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // takes the horizontal input
        float verticalInput = Input.GetAxis("Vertical"); // takes the vertical input

        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime); // translates for horizontal
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime); // translates for vertical


        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.9f, 0), 0); // clamps the value of y bw -3.9f and 0

        // loop for the x value. the horizontal values.
        if (transform.position.x <= -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }

        else if (transform.position.x >= 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
    }

    void FireLazer()
    {
        _canFire = Time.time + _fireRate; // delay
        Instantiate(_lazerPrefab, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity); // what happenes when space key is  pressed
    }

}
