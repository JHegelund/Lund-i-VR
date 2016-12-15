using UnityEngine;
using System.Collections;

public class moviescript : MonoBehaviour {

	/*public MovieTexture movTexture;*/




		void Start() {
		Handheld.PlayFullScreenMovie("Materials/ILL-BE-AROUND-THE-SPINNERS.ogv", Color.black, FullScreenMovieControlMode.CancelOnInput);

		/*GetComponent<Renderer>().material.mainTexture = movTexture;
			movTexture.Play();*/
		}

	}
