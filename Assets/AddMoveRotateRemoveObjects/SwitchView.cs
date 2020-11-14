using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchView : MonoBehaviour
{
	
	public GameObject eCam;
	public GameObject tCam;
	
	bool onEyeLevel;
	
	public static SwitchView sw;
	
	[HideInInspector]
	public bool canMoveObject;
	
    void Start(){
		sw = this;
		canMoveObject = false;
        onEyeLevel = false;
    }
	
	public void toggleCam(){
		
		if(onEyeLevel){
			
			eCam.SetActive(true);
			tCam.SetActive(false);
			canMoveObject = false;
			onEyeLevel = false;
			ObjectManager.om.HideObjectTool();
			
		}else{
			
			eCam.SetActive(false);
			tCam.SetActive(true);
			canMoveObject = true;
			onEyeLevel = true;
			
		}
		
	}
	
}
