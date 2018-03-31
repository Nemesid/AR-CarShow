using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotate : MonoBehaviour {

	public bool isRotate = true;
	public GameObject Lambo;
	public GameObject Benz;
	public GameObject Viper;
	public void Rotate()
	{
		Lambo.transform.Rotate (Vector3.right);
	}
}
