using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondaryCameraUI : MonoBehaviour {

	[Serializable]
	public struct AspectRatio {
		public int width;
		public int height;
	}

	[SerializeField] private AspectRatio renderImageAspectRatio;
	
	private RawImage cameraRenderImage;
	private RectTransform renderTransform;
	
	
	private void Start() {
		
		cameraRenderImage = GetComponent<RawImage>();
		renderTransform = GetComponent<RectTransform>();
		renderTransform.sizeDelta = new Vector2(cameraRenderImage.texture.width, cameraRenderImage.texture.height);

	}
}
