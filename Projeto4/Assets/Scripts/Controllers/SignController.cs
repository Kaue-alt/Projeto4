using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignController : MonoBehaviour
{
    public GameObject avisoCobra;
    public GameObject avisoColec;
    public GameObject avisoQuiz;

    public GameObject reset;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.gameObject.transform.position.y < reset.transform.position.y)
            {

                avisoCobra.SetActive(true);
            }
            if (this.gameObject.transform.position.x > reset.transform.position.x)
            {

                avisoColec.SetActive(true);
            }
            if (this.gameObject.transform.position.y > reset.transform.position.y)
            {

                avisoQuiz.SetActive(true);
            }
        }
       


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.gameObject.transform.position.y < reset.transform.position.y)
            {

                avisoCobra.SetActive(false);
            }
            if (this.gameObject.transform.position.x > reset.transform.position.x)
            {

                avisoColec.SetActive(false);
            }
            if (this.gameObject.transform.position.y > reset.transform.position.y)
            {

                avisoQuiz.SetActive(false);
            }
        }
    }




        //private void OnTriggerStay2D(Collision2D other)
        //{
        //    if (other.CompareTag("Player"))
        //    {
        //        if (this.gameObject.transform.position.y < reset.transform.position.y)
        //        {

        //            avisoCobra.SetActive(true);
        //        }
        //        if (this.gameObject.transform.position.x> reset.transform.position.x)
        //        {

        //            avisoColec.SetActive(true);
        //        }
        //        if (this.gameObject.transform.position.y > reset.transform.position.y)
        //        {

        //            avisoQuiz.SetActive(true);
        //        }
        //    }
        //    else
        //    {
        //        avisoCobra.SetActive(false);
        //        avisoQuiz.SetActive(false);
        //        avisoColec.SetActive(false);


        //    }
        //}
        // Start is called before the first frame update

    }
