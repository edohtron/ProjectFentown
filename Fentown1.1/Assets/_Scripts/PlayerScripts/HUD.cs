using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    public GameObject _HUD;

	// Use this for initialization
	void Start () {
        _HUD.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleHUD(bool tf) {
        if (tf) {
            _HUD.SetActive(true);
        }

        if (!tf) {
            _HUD.SetActive(false);
        }
    }
}
