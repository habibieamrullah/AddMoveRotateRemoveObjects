using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectChooser : MonoBehaviour
{
	
	public GameObject addObjectButtonPrefab;
	public GameObject container;
	public string[] availableObjects;
	
    // Start is called before the first frame update
    void Start()
    {
		for(int i = 0; i < availableObjects.Length; i++){
			MakeButton(availableObjects[i]);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void MakeButton(string objectName)
	{
		GameObject button = (GameObject) Instantiate(addObjectButtonPrefab);

		button.transform.position = container.transform.position;
		button.GetComponent<RectTransform>().SetParent(container.transform);
		button.GetComponent<Image>().sprite = Resources.Load<Sprite>(objectName + "-thumb");
		button.GetComponent<Button>().onClick.AddListener(() => AddNewObjectToScene(objectName));
	}
	
	public void AddNewObjectToScene(string objectName){
		Debug.Log("Adding " + objectName + " to scene.");
		ObjectManager.om.HideObjectChooser();
		ObjectManager.om.AddObjectToScene(objectName);
		
	}
}
