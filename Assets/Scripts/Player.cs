using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    public Transform enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);
        inputFromPlayer.Normalize();
        // Move the Player based on Values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);
    }
}
