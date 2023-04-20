using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nepieciešams, lai strādātu ar UI elementiem
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	/*int kadri = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("Programma tika startēta!");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Kadrs: "+kadri);
		kadri++;

		if (kadri == 10) {
			Debug.Log ("Tu sasniedzi 10. kadru!");
		}
	}*/

	//mainīgais, kurā uzglabās tekstu no input field
	private string teksts;
    private string teksts1;
    //lauks, kurā ievada tekstu
    public GameObject ievadesLauksVards;
    public GameObject ievadesLauksVecums;
    //text objekts, kurā attēlos tekstu pēc pogas nospiešanas
    public GameObject tekstaAttelosana;
	//masīvs ar iespējamajiem teksta sākumiem
	private string[] varianti = {"Varenais ", "Brīnišķīgais ", 
	"Ātrais ", "Spēcīgais "};
	//mainīgais uzglabās random skaitli
	int nejausais;
	

	public void NolasitTekstu(){
		teksts = ievadesLauksVards.GetComponent<Text>().text;
		teksts1 = ievadesLauksVecums.GetComponent<Text>().text;
		nejausais = Random.Range (0, varianti.Length);
		tekstaAttelosana.GetComponent<Text>().text = 
			varianti[nejausais]+teksts.ToUpper()+""
			+ " ir "+teksts1+" gadus vecs!";
	}		


}
