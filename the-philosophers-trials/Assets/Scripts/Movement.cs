using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    public Transform cam;

    private float horizontal;
    private float vertical;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 rotation = new Vector3(transform.rotation.x, cam.rotation.y, transform.rotation.z);
        transform.rotation = Quaternion.Euler(rotation);

        Vector3 move = new Vector3(horizontal, 0, vertical);
        controller.Move(move * speed * Time.deltaTime);
    }
}
