using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpush : MonoBehaviour
{
	public float distance = 1f;

	public Transform player;



	public void catchtrue()
	{
		if (this.transform.position.x > player.transform.position.x)
		{
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance);

			if (hit.collider != null && hit.collider.tag == "pushable")
			{

				hit.collider.gameObject.GetComponent<Pull>().enabled = true;

			}
		}
		else if (this.transform.position.x < player.transform.position.x)
		{
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, distance);

			if (hit.collider != null && hit.collider.tag == "pushable")
			{

				hit.collider.gameObject.GetComponent<Pull>().enabled = true;

			}
		}
		
		
		//if (this.transform.position.y > player.transform.position.y)
		//{
		//	RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distance);

		//	if (hit.collider != null && hit.collider.tag == "pushable")
		//	{

		//		hit.collider.gameObject.GetComponent<Pull>().enabled = true;

		//	}
		//}
		//else if (this.transform.position.y < player.transform.position.y)
		//{
		//	RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance);

		//	if (hit.collider != null && hit.collider.tag == "pushable")
		//	{

		//		hit.collider.gameObject.GetComponent<Pull>().enabled = true;

		//	}
		//}




	}


	public void catchfalse()
	{

		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance);
		RaycastHit2D hitL = Physics2D.Raycast(transform.position, Vector2.left, distance);
		//RaycastHit2D hitU = Physics2D.Raycast(transform.position, Vector2.up, distance);
		//RaycastHit2D hitD = Physics2D.Raycast(transform.position, Vector2.down, distance);


		if (hit.collider != null && hit.collider.tag == "pushable")
		{

			hit.collider.gameObject.GetComponent<Pull>().enabled = false;

		}
		else if (hitL.collider != null && hitL.collider.tag == "pushable")
		{

			hitL.collider.gameObject.GetComponent<Pull>().enabled = false;

		}
		//else if (hitU.collider != null && hitU.collider.tag == "pushable")
		//{

		//	hitU.collider.gameObject.GetComponent<Pull>().enabled = false;

		//}
		//else if (hitD.collider != null && hitD.collider.tag == "pushable")
		//{

		//	hitD.collider.gameObject.GetComponent<Pull>().enabled = false;

		//}



	}
	public void collectobjects()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance);

		if (hit.collider != null && hit.collider.tag == "Colectable")
		{

			GameObject.Find("CollectController").GetComponent<Colectables>().enabled = true;

		}
	}



}

