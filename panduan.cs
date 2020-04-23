using UnityEngine;
using System.Collections;

public class panduan : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android)
			
		{
			
			if (Input.GetKey(KeyCode.Escape))
				
			{
				
				// masukkan aksi apa yang diinginkan disini🙂
				Application.LoadLevel (1);
				//biasanya sebelah kanan @Back@
				
				return;
			}else if (Input.GetKey(KeyCode.Menu)){
				//ini untuk tombol menu, biasa disebelah kiri
				Application.Quit ();
				//masukkan aksi disini
			}}
	}
}
