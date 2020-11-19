using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotaController : MonoBehaviour
{
    private int idNota;

    public Text txtNota;
    public Text txtInfoNota;
    // Start is called before the first frame update

    private int notaFinal;
    private int acertos;
    void Start()
    {
        idNota = PlayerPrefs.GetInt("idNota");
        notaFinal = PlayerPrefs.GetInt("notaFinal" + idNota.ToString());
        acertos = PlayerPrefs.GetInt("acertos" + idNota.ToString());

        txtNota.text = notaFinal.ToString();
        txtInfoNota.text="Você acertou "+acertos.ToString()+ " de 5 perguntas!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
