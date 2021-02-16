//Phu Pham
//101250748
//Assignment 1


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieMove : MonoBehaviour
{
public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	//Constantly move the goalie to the left
	transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    //Change direction when goalie is at border
    void OnTriggerEnter(Collider other)
    {	
	speed = speed * -1;
    }
}
