using System;
using UnityEngine;
using UnityEngine.UI;

public class SecondaryCameraUI : MonoBehaviour {

	[Serializable]
	public struct AspectRatio {
		public int width;
		public int height;
	}

	[Header("Size")]
	[SerializeField] private float minSizeMultiplier = 0.5f;
	[SerializeField] private float maxSizeMultiplier = 2f;
	[SerializeField] private float defaultSize = 256f;

	[Header("Objects")] 
	[SerializeField] private Slider sizeSlider;
	[SerializeField] private RawImage cameraRenderImage;
	[SerializeField] private RectTransform renderTransform;
	
	
	private void Start() {
		sizeSlider.minValue = minSizeMultiplier;
		sizeSlider.maxValue = maxSizeMultiplier;
		cameraRenderImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
	}

	private void Update() {
		var size = defaultSize * sizeSlider.value;
		renderTransform.sizeDelta = new Vector2(size, size);
	}

}
