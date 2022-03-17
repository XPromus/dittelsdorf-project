using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HouseTextures {

	public class TextureManager : MonoBehaviour {
	
		[Serializable]
		public struct HouseMaterial {
			public Material Material;
			public List<Texture2D> textures;
		}

		[SerializeField] private List<HouseMaterial> houseMaterials;

		private int currentTextureIndex = 0;
		private int numberOfTextures;

		private void Start() {
			
			var test = houseMaterials[0].textures.Count;

			foreach (var houseMaterial in houseMaterials) {
				if (houseMaterial.textures.Count != test) {
					Debug.LogError("Each texture list must contain the same amount of textures");
				}
			}
			
			numberOfTextures = test;
			ChangeTexture(0);
			
		}
	
		public void CycleTextures() {
			
			if (currentTextureIndex < numberOfTextures - 1) {
				currentTextureIndex++;
			} else {
				currentTextureIndex = 0;
			}
			
			ChangeTexture(currentTextureIndex);
			
		}
		
		private void ChangeTexture(int index) {
			
			foreach (var material in houseMaterials) {
				material.Material.mainTexture = material.textures[index];
			}

			currentTextureIndex = index;
			
		}
	
	}
	
}