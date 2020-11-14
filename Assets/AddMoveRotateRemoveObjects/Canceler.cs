using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Canceler : MonoBehaviour
{
	void OnMouseDown(){
		if (!EventSystem.current.IsPointerOverGameObject()){
			ObjectManager.om.HideObjectTool();
		}
	}
}
