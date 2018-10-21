using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour {

    public string objectName;
    public Sprite objectIcon;

    protected bool currentlySelected = false;

    public void SetSelection(bool selected) { currentlySelected = selected; }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
