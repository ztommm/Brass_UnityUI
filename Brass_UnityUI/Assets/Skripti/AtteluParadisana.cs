using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject Peter;
    public GameObject PeterFart;
    public GameObject Quagmire;
    public GameObject Brian;
    public GameObject paKreisi;
    public GameObject paLabi;
	public GameObject kurRadit;
	public Sprite[] koRadit;
	public GameObject slaideris1;
	public GameObject slaideris2;


    public void PeterAttelosana(bool vertiba)
    {
        Peter.SetActive(vertiba);
        paKreisi.GetComponent<Toggle>().interactable = vertiba;
        paLabi.GetComponent<Toggle>().interactable = vertiba;
    }

    public void BrianAttelosana(bool vertiba)
    {
        Brian.SetActive(vertiba);
    }

    public void QuagmireAttelosana(bool vertiba)
    {
        Quagmire.SetActive(vertiba);
    }

    public void PeterFartAttelosana(bool vertiba)
    {
        PeterFart.SetActive(vertiba);
    }

    public void PaKreisiPeter()
    {
        Peter.transform.localScale = new Vector2(1, 1);
    }

    public void PaLabiPeter()
    {
        Peter.transform.localScale = new Vector2(-1, 1);
    }

	public void izkritosais(int indekss){
		if (indekss == 0)
			kurRadit.GetComponent<Image> ().sprite = koRadit [0];

		else if(indekss == 1)
			kurRadit.GetComponent<Image> ().sprite = koRadit [1];

		else if(indekss == 2)
			kurRadit.GetComponent<Image> ().sprite = koRadit [2];
	}


    
    public void mainitLielumuY()
    {
		float pasreizejaVertiba2 = slaideris2.GetComponent<Slider>().value;
		float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
        kurRadit.transform.localScale =
			new Vector2(pasreizejaVertiba, 1f * pasreizejaVertiba2);
		
    }
    public void mainitLielumuX()
    {
		float pasreizejaVertiba2 = slaideris2.GetComponent<Slider>().value;
		float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
        kurRadit.transform.localScale =
			new Vector2(1f * pasreizejaVertiba, pasreizejaVertiba2);
    }

    public void mainitRotaciju(){
		float pasreizejaVertiba = slaideris2.GetComponent<Slider> ().value;
		kurRadit.transform.localRotation =
			Quaternion.Euler (0, 0, pasreizejaVertiba * 360);
	}
}
