using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementController : MonoBehaviour
{

   public Rigidbody2D backTyre, frontTyre,car;
    public float speed, movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        backTyre.AddForce(new Vector2(movement,0)*speed*Time.fixedDeltaTime);
        frontTyre.AddTorque(movement * speed * Time.fixedDeltaTime);
        car.AddTorque(-movement * speed * Time.fixedDeltaTime);

    }
}
