using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{

		transform.GetComponent<Renderer> ().material.color = other.GetComponent<SpriteRenderer> ().color;

	}
}
