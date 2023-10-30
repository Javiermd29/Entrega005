using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Entrega05 : MonoBehaviour
{
    [SerializeField] private GameObject camera;

    [SerializeField] private float verticalSpeed = 5f;
    [SerializeField] private float lateralSpeed = 5f;

    [SerializeField] private Vector3 offset;
    private bool firstTime = true;

    private float verticalInput;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left * lateralSpeed * Time.deltaTime * verticalInput);

        camera.transform.position = transform.position + offset;

        if (transform.position.z > 220 && firstTime)
        {
            Debug.Log("HAS GANADO");
            firstTime = false;
        }

    }
}
