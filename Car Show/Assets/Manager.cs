using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public GameObject Lambo;
	public GameObject Benz;
	public GameObject Viper;
	public GameObject MainMenu;
	public GameObject onCanv;
	public GameObject CarStage;
	public GameObject closecanv;
	public GameObject MarkerMenu;
	public void LamboCar()
	{
		MainMenu.SetActive (false);
		Lambo.SetActive(true);
		onCanv.SetActive (true);
		CarStage.SetActive (true);
	}
	public void BenzCar()
	{
		MainMenu.SetActive (false);
		Benz.SetActive(true);
		onCanv.SetActive (true);
		CarStage.SetActive (true);
	}
	public void ViperCar()
	{
		MainMenu.SetActive (false);
		Viper.SetActive(true);
		onCanv.SetActive (true);
		CarStage.SetActive (true);
	}
	public void BackButton()
	{
		MainMenu.SetActive (true);
		Lambo.SetActive (false);
		Viper.SetActive (false);
		Benz.SetActive (false);
		onCanv.SetActive (false);
		CarStage.SetActive (false);
		closecanv.SetActive (false);
		MarkerMenu.SetActive (false);
	}
	public void AppQuit()
	{
		Application.Quit ();
	}
	public void ScanMarker()
	{
		MainMenu.SetActive (false);
		MarkerMenu.SetActive (true);
	}
}
