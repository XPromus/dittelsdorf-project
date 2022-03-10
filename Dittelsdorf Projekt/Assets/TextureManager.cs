using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HouseTextures {

	public class TextureManager : MonoBehaviour {
	
		[Serializable]
		public struct HouseMaterial {
			public Material Material;
			public Texture2D Texture_1;
			public Texture2D Texture_2;
		}

		[SerializeField] private List<HouseMaterial> houseMaterials;

		private bool currentTexture = true;
	
		public void ChangeTexture() {

			foreach (var material in houseMaterials) {
				material.Material.mainTexture = currentTexture ? material.Texture_2 : material.Texture_1;
			}
			
			currentTexture = !currentTexture;
		
		}
	
	}
	
}