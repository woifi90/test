using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageGenerator : MonoBehaviour {

	public Sprite[] images;
	private bool[] used;

	public GameObject[] targets;

	public GameObject imagePrefab;
			
	public void RefreshImages(){
		used = new bool[images.Length];

		foreach (GameObject target in targets) {
			
			int random = Random.Range (0, images.Length);
			while(used[random] != false){
				random = Random.Range (0, images.Length);
			}

			GameObject go = Instantiate (imagePrefab, target.transform);
			go.GetComponent<SpriteRenderer> ().sprite = images [random];
			used [random] = true;
		}

		Debug.Log ("Restarted!");
	}
}
