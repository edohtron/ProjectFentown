using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldDataScript : MonoBehaviour {

    private SceneControllerScript sceneController;
    [SerializeField] private bool inWorldScene;

    // Use this for initialization
    void Start () {
        if (sceneController == null) {
            sceneController = GameObject.Find("MasterSceneController").GetComponent<SceneControllerScript>();
        }

        inWorldScene = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (!inWorldScene) {
            if (sceneController.currentScene == SceneManager.GetActiveScene()) {
                ToggleInWorldScene(true);
            }
        }
	}

    public void ToggleInWorldScene(bool tf) {
        inWorldScene = tf;
    }

    public bool InWorldScene() {
        if (inWorldScene) {
            return true;
        }

        return false;
    }
}
