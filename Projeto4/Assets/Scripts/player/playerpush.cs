using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpush : MonoBehaviour
{
	public float distance = 1f;
	

	
    bool pulling =false;
	GameObject box;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance);

		if (hit.collider !=null && hit.collider.tag=="pushable")
		{
			
			if (Input.GetKeyDown(KeyCode.E))
			{
				hit.collider.gameObject.GetComponent<Pull>().enabled = true;


				Debug.Log("Pegou");
			}else if (Input.GetKeyUp(KeyCode.E))
			{
				hit.collider.gameObject.GetComponent<Pull>().enabled = false;

			}

			Debug.Log("Ta vendo");


		}
		

	}


	


	void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;

		Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);



	}
}
