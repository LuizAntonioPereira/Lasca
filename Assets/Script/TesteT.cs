using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteT : MonoBehaviour {
	
	public bool teste = false;
	public int t = 0;	
	public float direcao;
	public float cuboponto;
	public float cuboponto1;
	public float antigoposicao;
	public float atualtamanho;

	// Use this for initialization
	void Start () {
	antigoposicao = transform.localScale.z;	
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			teste = true;
			 direcao = (Random.Range(-1.0f, 1.0f)) > 0 ? 1f : -1f;
			
			if(teste){				
			atualtamanho = transform.localScale.z - Mathf.Abs(antigoposicao);
			float t = transform.localScale.z - atualtamanho;
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);		
			
			if(direcao == 1){
			cuboponto = transform.position.z + (t / 2f * direcao);
			//Destroy(objeto,2f);
			}else{
			cuboponto1 = cuboponto + t / 2f;
			//Destroy(objeto,2f);
			//y += 0.1f;
				}
			
			var objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);
			objeto.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z-direcao);			
			objeto.transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y, cuboponto);
				
			}
			teste = false;
		}
	}
}
