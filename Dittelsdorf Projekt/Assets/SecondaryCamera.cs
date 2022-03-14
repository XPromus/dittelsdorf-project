using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryCamera : MonoBehaviour {

	[SerializeField] private GameObject secondaryCamera;
	[SerializeField] private GameObject secondaryScene;

	private void Start() {
		secondaryCamera.SetActive(false);
		secondaryScene.SetActive(false);
	}

	public void SceneSecondaryCamera() {
		secondaryCamera.SetActive(!secondaryCamera.activeSelf);
		secondaryScene.SetActive(!secondaryScene.activeSelf);
	}

}
