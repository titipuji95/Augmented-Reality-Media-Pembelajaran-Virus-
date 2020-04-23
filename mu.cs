using UnityEngine;
using System.Collections;

public class mu : MonoBehaviour {
	
	public bool statusFlash=false;
	// Use this for initialization
	public Canvas menu;
	public Canvas keluar;
	void Start () {
		menu.enabled = true;
		keluar.enabled = false;
	}
	// membuat variabel
	public void kamera(){
		Application.LoadLevel ("AR-Camera");
	}
	
	public void materi(){
		Application.LoadLevel ("materi");
	}
	
	public void evaluasi(){
		Application.LoadLevel ("Persistant");
	}
	
	public void panduan(){
		Application.LoadLevel ("panduan");
	}
	public void unduh(){
		Application.LoadLevel ("unduh");
	}
	public void tentang(){
		Application.LoadLevel ("tentang");
	}
	

	public void Keluar(){
		menu.enabled = false;
		keluar.enabled = true;
		
	}
	
	public void btYes(){
		Application.Quit ();
		
	}
	
	public void btNo(){
		menu.enabled = true;
		keluar.enabled = false;
		
	}


	//=====================================flash coba
	public void flashnyala(){
				Vuforia.CameraDevice.Instance.SetFlashTorchMode (true);
		}
	public void flashmati(){
		Vuforia.CameraDevice.Instance.SetFlashTorchMode (false);
	}
		
	// Update is called once per frame
	void Update () {
		/*if (Application.platform == RuntimePlatform.Android)
			
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
			}}*/
	}
}

