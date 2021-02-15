using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BallTransform : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 startPosition;
    bool IsKicked = false;
    public Text textbox;
    float score = 5;
  

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
	//Score Updating
	textbox.text = "Score: " + score;


	//Kicking functionality
     if (score > 0) 
        {
		if (Input.GetMouseButtonUp(0) && (IsKicked == false))
        	{
	    
            	rb = GetComponent<Rigidbody>();
	    	rb.AddRelativeForce(0,  100,  1000);
	    	IsKicked = true;
        	}
	
		if (Input.GetMouseButtonUp(1))
		{
	     	rb.velocity = Vector3.zero;
	     	rb.MovePosition(startPosition);
	     	IsKicked = false;
	     	score-= 1;
		}
	}

	//Rotate ball with mouse
            float mouseX = (Input.mousePosition.x / Screen.width ) - 0.5f;
    	    float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
	    transform.localRotation = Quaternion.Euler (new Vector4 (-1f * (mouseY * 180f), mouseX * 360f, 		  transform.localRotation.z));

    }




    //Respawning & set speed to 0 
	void OnTriggerEnter(Collider other)
	{
	     rb.velocity = Vector3.zero;
	     rb.MovePosition(startPosition);
	     IsKicked = false;
	     score+= 1;
	}

	
}
