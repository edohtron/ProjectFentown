using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    public GameObject _HUD;
    public GUISkin detailBarSkin;
    private const int ORDERS_BAR_WIDTH = 150, DETAILS_BAR_HEIGHT = 25, SELECTION_NAME_HEIGHT = 30;

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

    private void OnGUI() {
        DrawDetailsBar();
    }

    public bool MouseInBounds() {
        Vector3 mousePos = Input.mousePosition;
        bool insideWidth = mousePos.x >= 0 && mousePos.x <= Screen.width; /* - ORDERS_BAR_WIDTH*/
        bool insideHeight = mousePos.y >= 0 && mousePos.y <= Screen.height - DETAILS_BAR_HEIGHT;
        return insideWidth && insideHeight;
    }

    private void DrawDetailsBar() {
        GUI.skin = detailBarSkin;
        GUI.BeginGroup(new Rect(0 , 0 , Screen.width , DETAILS_BAR_HEIGHT));
        GUI.Box(new Rect(0 , 0 , Screen.width , DETAILS_BAR_HEIGHT) , "YO");
        GUI.EndGroup();
    }



}
