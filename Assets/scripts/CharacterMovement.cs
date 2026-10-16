using System;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb; //declaro la variable
    private Vector3 movementDirection;
    
    [Header("Movement Properties")]
    [SerializeField] private float horizontalMovement;
    [SerializeField] private float verticalMovement;
    [SerializeField] private float movementVelocity = 25;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //inicializo la variable
        movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);
    }
    //se ejecuta si o si 100v/s
    //ej evitar q se mueva mas rapido en un pc q en otro
    void FixedUpdate()
    {
        rb.AddForce(movementDirection * movementVelocity, ForceMode.Acceleration);
    }
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);
    }
}



