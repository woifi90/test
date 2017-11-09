using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageGenerator : MonoBehaviour {

	public Sprite[] images;
	private bool[] used;
	System.Random rand;

	public GameObject[] targets;

	public GameObject imagePrefab;

	void Start(){
		rand = new System.Random (System.DateTime.UtcNow.Hour);
		RefreshImages ();
	}
			
	public void RefreshImages(){
		used = new bool[images.Length];

		foreach (GameObject target in targets) {

			bool init = true;
			foreach (Transform trafo in target.GetComponentsInChildren<Transform>()) {
				if (!init)
					Destroy (trafo.gameObject);
				init = false;
			}
			
			int random = rand.Next(0, images.Length);
			while(used[random] != false){
				random = rand.Next(0, images.Length);
			}

			GameObject go = Instantiate (imagePrefab, target.transform);
			go.GetComponent<SpriteRenderer> ().sprite = images [random];
			used [random] = true;
		}
	}
}
