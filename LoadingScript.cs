using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour {

	public float loadingTime;
	public Image loadingBar;

	// Use this for initialization
	void Start () {
		loadingBar.fillAmount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (loadingBar.fillAmount <= 1) {
			loadingBar.fillAmount += 1.0f / loadingTime * Time.deltaTime;
		}
		if (loadingBar.fillAmount == 1.0f) {
			Application.LoadLevel(1);
		}
	}
}
