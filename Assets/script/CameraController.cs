using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensibildiad =10.0f;
	public Transform objetivo;
	Vector3 mause= Vector3.zero;
	Vector3 monto= Vector3.zero;
	public Vector3 posicion =new Vector3(0,0,1f);
	RaycastHit hit;
	float hitDistancia=0;
	// tangente del campo de vision
	float tanFOV;
	Camera cam;
	Vector3 apuntaCamara= Vector3.zero;

	Vector3 posicionCamara= Vector3.zero;
	Vector3 posicionCamaraSinOclusion= Vector3.zero;
	Quaternion rotacionCamara= Quaternion.identity;

	Vector3 centropantalla = Vector3.zero;
	Vector3 alturaPantalla = Vector3.zero;
	Vector3 anchoPantalla = Vector3.zero;
	Vector3[] esquinas = new Vector3[5];

	void Start () {
		cam = gameObject.GetComponent<Camera>();
		float tangente = cam.fieldOfView*0.5f*Mathf.Deg2Rad;
		tanFOV = Mathf.Tan(tangente)*cam.nearClipPlane;

	}

	void Update(){
		centropantalla= (rotacionCamara*Vector3.forward)*cam.nearClipPlane;
		alturaPantalla=(rotacionCamara*Vector3.up)*tanFOV;
		anchoPantalla = (rotacionCamara*Vector3.right)*tanFOV*cam.aspect;
		esquinas[0] = posicionCamara + centropantalla -alturaPantalla -anchoPantalla;
		esquinas[1]=posicionCamara + centropantalla +alturaPantalla -anchoPantalla;
		esquinas[2]=posicionCamara + centropantalla +alturaPantalla +anchoPantalla;
		esquinas[3]=posicionCamara + centropantalla -alturaPantalla +anchoPantalla;
		esquinas[4]=posicionCamara + centropantalla;
		hitDistancia = 1000000;
		for (int i = 0; i < 5; i++)
		{
			if(Physics.Linecast(objetivo.transform.position + posicion, esquinas[i],out hit)){
				Debug.DrawLine(objetivo.transform.position+ posicion,esquinas[i],Color.red);
				Debug.DrawRay(hit.point, Vector3.up*0.05f,Color.white);
				hitDistancia=Mathf.Min(hitDistancia,hit.distance);
			}
			else
			{
				Debug.DrawLine(objetivo.transform.position+ posicion,esquinas[i],Color.blue);
			}
		}
		if(hitDistancia>999999){
			hitDistancia = 0;
		}
			
	}
	void LateUpdate() {
		mause.Set(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);

		monto += mause*sensibildiad;
		monto.z =Mathf.Clamp(monto.z,50,100);
		monto.y = Mathf.Clamp(monto.y,15,89);
		Vector3 v3 = new Vector3(1,0,0);
		rotacionCamara = Quaternion.AngleAxis(-monto.x, Vector3.up)*Quaternion.AngleAxis(monto.y,v3);
		apuntaCamara= rotacionCamara*Vector3.forward;
		posicionCamara= objetivo.transform.position+ posicion-apuntaCamara*monto.z*0.1f;

		posicionCamaraSinOclusion=objetivo.transform.position+posicion-apuntaCamara*hitDistancia;
		
		transform.rotation = rotacionCamara;
		if(hitDistancia>0){
			transform.position = posicionCamaraSinOclusion;
		}
		else{

		transform.position = posicionCamara;
		}
	}
}
