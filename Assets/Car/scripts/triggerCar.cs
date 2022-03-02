using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Car{
public class triggerCar : MonoBehaviour {
public CarUserControl Car;
public GameObject Player;
public Rigidbody rb;
public GameObject camara;
public Camera_Follow Follow;
public string TagCamera="MainCamera";
public string TagPlayer="Jugador";
public string ButtonIn_out_Car="Fire1";
public float SalirX, SalirZ;

private void Update() {
if(camara==null){
	camara = GameObject.FindWithTag(TagCamera);
	}

if(Car.enabled==true){
	instanciar();
	}
}
public void instanciar(){
if(Input.GetButtonDown(ButtonIn_out_Car))
		{
	Instantiate(Player,transform.position+ new Vector3(SalirX, 0, SalirZ), Quaternion.identity);
Car.enabled=false;
camara.SetActive(true);
Follow.enabled=true;
rb.velocity=Vector3.zero;
		}
}

void OnTriggerEnter(Collider other) {
	if(other.tag==TagPlayer){
		Destroy(other.gameObject);
		camara.SetActive(false);
		Follow.enabled=false;
		Car.enabled=true;
		}
	}

}

	
}

