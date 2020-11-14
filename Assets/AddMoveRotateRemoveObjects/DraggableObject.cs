using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableObject : MonoBehaviour{
	
	 private Vector3 screenPoint;
	 private Vector3 offset;
	 
	 void OnMouseDown(){
		 
		 if(SwitchView.sw.canMoveObject && !EventSystem.current.IsPointerOverGameObject()){
			 
			 ObjectManager.om.selectedObject = gameObject.name;
			 ObjectManager.om.ShowObjectTool();
			 
			 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			 offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		 }
		
	 }
	 
	 void OnMouseDrag(){
		 if(SwitchView.sw.canMoveObject && !EventSystem.current.IsPointerOverGameObject()){
			 
			 Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);		 
			 Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			 transform.position = curPosition;
			 
		 }
	 }
}
