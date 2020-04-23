using UnityEngine;
using System.Collections;

public class menuutama : MonoBehaviour {

	// Use this for initialization
	public void downloadmarker(){
		//Application.OpenURL ("https://drive.google.com/open?id=0BzYRCnl6PQdWanNCcHhlUDZ0alE");
		//revisimarker
		Application.OpenURL ("https://drive.google.com/open?id=0BzYRCnl6PQdWMDBtYlR6SXJwWG8");
	}

	public void videopanduan(){
		Application.OpenURL ("https://youtu.be/X-zkORaKxb4");
		
	}

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
