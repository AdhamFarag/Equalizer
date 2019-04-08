using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public int score1;
	public Text scoretext;
	public Color colorInSprite;
	public changecolor ChangeColor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "" + score1;
	}
	public void OnMouseDown(){
	}
}
