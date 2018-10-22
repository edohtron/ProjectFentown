using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private HUD hud;

    public bool isPlayer;
    public string playerName;
    // public Sprite playerIcon; flag, banner, sigil, icon?

    public GameObject selectedObject; 
    public GameObject [] selectedObjects;

	// Use this for initialization
	void Start () {
        hud = GetComponent<HUD>();
        isPlayer = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetSelectedObject(GameObject go) {
        selectedObject = go;
        selectedObject.GetComponent<WorldObject>().SetSelection(true);
    }

    public void SetSelectedObjects() {

    }

    public void ClearSelectedObject() {
        selectedObject = null;
    }

    public void ClearSelectedObjects() {
        if (selectedObjects != null) {
            
        }
    }
}
