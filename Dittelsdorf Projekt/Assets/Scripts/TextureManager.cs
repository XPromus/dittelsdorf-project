using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HouseTextures {

	public class TextureManager : MonoBehaviour {
	
		[Serializable]
		public struct HouseMaterial {
			public HouseParts HousePart;
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

		public void ChangeRoofTexture() {
			foreach (var material in houseMaterials) {
				if (material.HousePart == HouseParts.ROOF) {
					material.Material.mainTexture = currentTexture ? material.Texture_2 : material.Texture_1;
				}
			}
		}

		public void ChangeWallTexture() {
			foreach (var material in houseMaterials) {
				if (material.HousePart == HouseParts.WALL) {
					material.Material.mainTexture = currentTexture ? material.Texture_2 : material.Texture_1;
				}
			}
		}

		public enum HouseParts {
			ROOF,
			WALL
		}
	
	}
	
}