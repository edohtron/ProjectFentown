using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerResources : MonoBehaviour {

   // public SceneControllerScript _sceneController;

    static public int Money;

    //private void Awake() {
    //    if (_sceneController == null) {
    //        _sceneController = GameObject.Find("MasterSceneController").GetComponent<SceneControllerScript>();
    //    }       
    //}

    // Use this for initialization
    void Start () {
        Money = 5;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            AddMoneys(10);
            Debug.Log(Money);
        }


	}

    public void AddMoneys(int val) {
        Money += val;

    }
}
