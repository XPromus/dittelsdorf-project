using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMap : MonoBehaviour {

	[Serializable]
	public struct MapMode {
		public string name;
		public Material mapMaterial;
	}

	[SerializeField] private ToggleTime toggleTime;
	[SerializeField] private MapMode[] mapModes;
	private ToggleGroup mapToggleGroup;
	private List<Transform> toggleChildren = new List<Transform>();

	private void Start() {

		mapToggleGroup = GetComponent<ToggleGroup>();
		var children = new List<Transform>();

		for (var i = 0; i < transform.childCount; i++) {

			var child = transform.GetChild(i);
			var toggle = child.GetComponent<Toggle>();

			if (toggle == null) continue;
			children.Add(child);
			toggle.group = mapToggleGroup;
			
		}

		toggleChildren = children;
		mapToggleGroup.SetAllTogglesOff();
		SetMapModeTo();
		
	}

	public void SetMapModeTo() {

		if (!mapToggleGroup.AnyTogglesOn()) {
			toggleTime.SetNormalMap();
			return;
		}
		
		for (var i = 0; i < toggleChildren.Count; i++) {
			if (toggleChildren[i].GetComponent<Toggle>().isOn) {
				toggleTime.ChangeMap(mapModes[i].mapMaterial);
			}
		}

	}
	
}
