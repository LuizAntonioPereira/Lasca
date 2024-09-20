using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciar : MonoBehaviour {
	
	public Transform Spawnner1;
	public Transform Spawnner;	
	public GameObject TextInicial;
	public GameObject TextFinal;
	public GameObject Pontua;
	public GameObject Rank;		
	public enum pode {sim,nao}
	public pode troca;
	public enum proximo {e,d}
	public proximo p;
	public static int contar = 0;
	public float y = 0.1f;
	
	// Use this for initialization
	void Start () {
		Spawnner1.transform.position = new Vector3(Spawnner1.transform.position.x,0.55f,Spawnner1.transform.position.z);
		Spawnner.transform.position = new Vector3(Spawnner.transform.position.x,0.65f,Spawnner.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
				
			// Nesse techo tiro da tela Inicial e mando começar o jogo.	
			switch(troca){
			case pode.sim:{
				
				//if(Input.touchCount > 0){
				if(Input.GetButtonDown("Fire1")){
				Plataforma1.apertar1 = false;
				Instantiate(Spawnner1);			
				TextInicial.SetActive(false);
				TextFinal.SetActive(false);
				Rank.SetActive(false);
				troca = pode.nao;
				Gerenciar.contar++;
				
				}
			}
			break;
			// Nesse techo o jogador pode parar da gravidade ao objeto.
			case pode.nao:{
				//if(Input.touchCount > 0){
				
				//if(Spawnner1){}
				if(Input.GetButtonDown("Fire1")){
					switch(p){
						case proximo.e:{
							Plataforma.apertar = false;
							Plataforma1.apertar1 = true;
							Spawnner.transform.position = new Vector3(Spawnner.transform.position.x,Spawnner.transform.position.y + y,Spawnner.transform.position.z);
							Instantiate(Spawnner);
							p = proximo.d;
							Gerenciar.contar++;
							y += 0.095f;
							}
						break;
						case proximo.d:{
							//float l = l * contar;
							Plataforma1.apertar1 = false;
							Plataforma.apertar = true;							
							Spawnner1.transform.position = new Vector3(Spawnner1.transform.position.x,Spawnner.transform.position.y + y,Spawnner1.transform.position.z);
							Instantiate(Spawnner1);
							p = proximo.e;							
							Gerenciar.contar++;
							y += 0.095f;	
						}
						break;
					}
				}
			break;
			}
		}
	}	
}