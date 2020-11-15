using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpush : MonoBehaviour
{
	public float distance = 1f;

	public Pull GetPull;


	public GameObject rock;
	
	GameObject box;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{


		


	}

	public void  catchtrue()
    {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance);

		if (hit.collider != null && hit.collider.tag == "pushable")
		{



			hit.collider.gameObject.GetComponent<Pull>().enabled = true;







		}


	}
	public void collectobjects()
    {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance);

		if (hit.collider != null && hit.collider.tag == "Colectable")
		{



			GameObject.Find("CollectController").GetComponent<Colectables>().enabled = true;







		}
	}


	void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;

		Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);



	}
}
