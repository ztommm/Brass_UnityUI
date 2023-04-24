using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nepieciešams, lai strādātu ar UI elementiem
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {

	//mainīgais, kurā uzglabās tekstu no input field
	private string teksts;
	private int teksts1;
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
		int.TryParse(ievadesLauksVecums.GetComponent<Text>().text, out teksts1);
		nejausais = Random.Range (0, varianti.Length);
		tekstaAttelosana.GetComponent<Text>().text = 
			varianti[nejausais]+teksts.ToUpper()+""
			+ " ir "+teksts1+" gadus vecs!";
	}       

}
