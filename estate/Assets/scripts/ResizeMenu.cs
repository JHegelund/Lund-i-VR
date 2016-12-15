using UnityEngine;
using System.Collections;

public class ResizeMenu : MonoBehaviour {
	public int i = 0;
	// Use this for initialization
	public void resize(){
		if (i == 0) {
			i = 1;
			transform.localScale += new Vector3 (-0.6F, 0, 0F);
		} else {
			i = 0;
			transform.localScale += new Vector3 (0.6F, 0, 0F);
		}
	}
}
