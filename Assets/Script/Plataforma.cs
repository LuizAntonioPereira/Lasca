using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {
	
	private float velocidade = 1f;
	public bool ir = true;
	public bool volta = false;
	public float anda = 0f;
	public static bool apertar = false;
	public bool colidir = false;
	public Rigidbody rig;
	

	// Inicializar com cor aleatoria.
	void Start () {
		GetComponent<MeshRenderer>().material.SetColor("_Color", Color.HSVToRGB((Gerenciar.contar / 100f) % 1f, 1f, 1f));
	}	
	
	public void Update () {
		
		//Butão ou Toque na tela para o objeto cai e para.
		//Objeto recebi gravidade e para de se movimentar.
		
		//if(tocar na tela){velocidade = 0;}
		//if(Input.touchCount > 0){
		if(Plataforma.apertar){
			
			velocidade = 0;
			rig.useGravity = true;
			
		}else{
			
			//Objeto se movimenta indo voltando.
			
			if(ir != true && volta == true){
				transform.position -= transform.forward * Time.deltaTime * velocidade;
				anda += Time.deltaTime * velocidade;
				if(anda >= 0){
					ir = true;
					volta = false;
				}
			}else{
				transform.position += transform.forward * Time.deltaTime * velocidade;
				anda -= Time.deltaTime * velocidade;
				if(transform.position.z >= 2.5 && volta == false){
					ir = false;
					volta = true;
				}
			}		
		}
	}
}