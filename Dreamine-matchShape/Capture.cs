using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rect= UnityEngine.Rect;
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;
public class Capture : MonoBehaviour {


	static public Texture2D dstTexture;
	static public bool getImage, grab;
	//public GameObject cube;

	// Use this for initialization
	void Start () {
		dstTexture= new Texture2D(Screen.width/3, Screen.width/3,  TextureFormat.RGBA32, false);

	}
	
	// Update is called once per frame
	void Update () {
		if(grab){
			StartCoroutine(Impo());
		}
//		cube.GetComponent<Renderer> ().material.mainTexture = dstTexture;
	}


	IEnumerator Impo()
	{

		yield return new WaitForEndOfFrame();

		dstTexture.ReadPixels(new Rect(Screen.width/3, (Screen.height-Screen.width/3)/2,Screen.width/3, Screen.width/3), 0, 0, false);
//		Debug.Log("Impo");
//		Debug.Log(getImage);
		getImage = true;
		grab=false;

	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(0, 0,Screen.width/6, Screen.width/6), "ReadPixels")) {
			grab=true;
//			Debug.Log("here");
		}
	}


}
