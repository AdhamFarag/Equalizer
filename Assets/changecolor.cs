using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class changecolor : MonoBehaviour {
	public Color col;
	public Color col1;
	public Color col2;
	public SpriteRenderer SR;
	public score SCORE;
	public bool canscore;
	// Use this for initialization
	void Start () {
		SR = this.gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void OnMouseDown(){
		if (SR.color == col1) {
			SR.color = col1;
			SCORE.score1 += 0;
		}
		if (SR.color == col) {
			SR.color = col2;
			SCORE.score1 += 1;
		}
		if (SR.color == col2) {
			SR.color = col2;
			SCORE.score1 += 0;
		}

	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "line") {
			SR.color = col;

		}
	
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "line") {
			SR.color = col1;
		
		}
	}
}
