using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSettings;

public class WorldObject : MonoBehaviour {

    public string objectName;
    public Sprite objectIcon;

    public void SetSelection(bool selected) { currentlySelected = selected; }

    protected bool currentlySelected = false;
    protected Rect playingArea = new Rect(0.0f , 0.0f , 0.0f , 0.0f);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void MouseClick(GameObject hitObject, Vector3 hitPoint, PlayerScript controller) {
        if (currentlySelected && hitObject && hitObject.name != "Ground") {
            WorldObject worldObject = hitObject.transform.root.GetComponent<WorldObject>();
            if (worldObject) {
                //ChangeSelection(worldObject , controller);
            }
        }
    }

    public void SetSelection(bool selected , Rect playingArea) {
        currentlySelected = selected;
        if (selected) {
            this.playingArea = playingArea;
        }
    }

    //private void ChangeSelection(WorldObject worldObject , PlayerScript controller) {
    //
    //    SetSelection(false , playingArea);
    //    if (controller.selectedObject) {
    //        controller.selectedObject.SetSelection(false , playingArea);
    //    }
    //    controller.selectedObject = worldObject;
    //    worldObject.SetSelection(true);
    //}
}
