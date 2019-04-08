using UnityEngine;
using System.Collections;

public class equalizrscript : MonoBehaviour {
	public GameObject prefab;
	public int cubesnumber;
	public float radius = 5;
	public GameObject[] arrayofcubes;
	public int speed;
	public int hieght;
	// Use this for initialization
	void Start () {
		
		arrayofcubes = GameObject.FindGameObjectsWithTag ("cubes");
	}
	
	// Update is called once per frame
	void Update () {
		float[] frequencies = AudioListener.GetSpectrumData (2048, 0, FFTWindow.Rectangular);
		for (int i = 0; i < cubesnumber; i++) {
			Vector3 oldscale = arrayofcubes[i].transform.localScale;
			oldscale.y = Mathf.Lerp (oldscale.y, frequencies [i] *hieght, Time.deltaTime *speed);
			arrayofcubes [i].transform.localScale = oldscale;
		}
	}
}
