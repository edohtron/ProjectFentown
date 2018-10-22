using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldDataScript : MonoBehaviour {

    private SceneControllerScript sceneController;

    // Use this for initialization
    void Start () {
        if (sceneController == null) {
            sceneController = GameObject.Find("MasterSceneController").GetComponent<SceneControllerScript>();
        }
    }
	
	// Update is called once per frame
	void Update () {
  
	}

    public bool InWorldScene() {
        if (sceneController.currentScene == SceneManager.GetActiveScene()) {
            return true;
        }

        return false;
    }
}
