using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSettings;

public class PlayerInputScript : MonoBehaviour {

    private Camera _camera;
    private WorldDataScript worldData;

    private bool isPoiSelected;

	// Use this for initialization
	void Start () {
        _camera = Camera.main;
        worldData = GameObject.Find("WorldData").GetComponent<WorldDataScript>();

        isPoiSelected = false;
	}
	
	// Update is called once per frame
	void Update () {

        MouseActivity();

        if (!isPoiSelected) {
            MoveCamera();
            //CameraZoom();
        }
	}

    public void TogglePoiInterface(bool tf) {
        isPoiSelected = tf;
    }

    private void MouseActivity() {
        if (Input.GetMouseButtonDown(0)) {
            LeftMouseClick();
        }
        else if (Input.GetMouseButtonDown(1)) {
            RightMouseClick();
        }
    }

    private void LeftMouseClick() {

    }

    private void RightMouseClick() {

    }

    private void MoveCamera() {
        float xPos = Input.mousePosition.x;
        float yPos = Input.mousePosition.y;

        Vector3 movement = new Vector3(0 , 0 , 0);

        // horizontal cam movement
        if (xPos >= 0 && xPos < PropertyManager.ScrollWidth) {

            movement.x -= PropertyManager.ScrollSpeed;
        }

        else if (xPos <= Screen.width && xPos > Screen.width - PropertyManager.ScrollWidth) {

            movement.x += PropertyManager.ScrollSpeed;
        }

        // vertical cam movement
        if (yPos >= 0 && yPos < PropertyManager.ScrollWidth) {

            movement.z -= PropertyManager.ScrollSpeed;
        }

        else if (yPos <= Screen.height && yPos > Screen.height - PropertyManager.ScrollWidth) {

            movement.z += PropertyManager.ScrollSpeed;
        }

        // make sure movement is in direction cam is facing
        // ignore  vertical tilt of camera

        movement = Camera.main.transform.TransformDirection(movement);
        movement.y = 0;

        // scroll from ground
        movement.y -= PropertyManager.ScrollSpeed * Input.GetAxis("Mouse ScrollWheel"); // can rename input

        // calculate desired camera pos based on recieved input
        Vector3 origin = Camera.main.transform.position;
        Vector3 destination = origin;

        destination.x += movement.x;
        destination.y += movement.y;
        destination.z += movement.z;

        // limit movement from ground between min and max height
        if (destination.y > PropertyManager.MaxCameraHeight) {
            destination.y = PropertyManager.MaxCameraHeight;
        }

        else if (destination.y < PropertyManager.MinCameraHeight) {
            destination.y = PropertyManager.MinCameraHeight;
        }


        if (destination != origin) {
            Camera.main.transform.position = Vector3.MoveTowards(origin , destination , Time.deltaTime * PropertyManager.ScrollSpeed);

        }


    }

    private GameObject FindHitObject() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray , out hit, 50)) {
            return hit.collider.gameObject;
        }

        return null;
    }

    private Vector3 FindHitPoint() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray , out hit)) {
            return hit.point;
        }

        return PropertyManager.InvalidPosition;
    }

    //private void CameraZoom() {
    //    Vector3 movement = new Vector3(0 , 0 , 0);
    //
    //    // scroll from ground
    //    movement.y -= PropertyManager.ScrollSpeed * Input.GetAxis("Mouse ScrollWheel"); // can rename input
    //}
}
