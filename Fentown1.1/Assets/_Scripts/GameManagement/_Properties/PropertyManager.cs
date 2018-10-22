using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSettings {

    public static class PropertyManager {

        // SCROLL & ROTATE
        public static float ScrollSpeed { get { return 20.0f; } }
        public static float RotateSpeed { get { return 100.0f; } }
        public static float RotateAmount { get { return 10.0f; } }
        public static int ScrollWidth { get { return 40; } }

        // CAMERA
        public static float MinCameraHeight { get { return 10.0f; } }
        public static float MaxCameraHeight { get { return 30.0f; } }

        // INVALID ACTIONS
        public static Vector3 InvalidPosition { get { return invalidposition; } }
        private static Vector3 invalidposition = new Vector3(-99999 , -99999 , -99999);
        private static Bounds InvalidBounds { get { return invalidBounds; } }

        public static void StoreSelectBoxItems(GUISkin skin) { selectBoxSkin = skin; }
        public static GUISkin SelectBoxSkin { get { return selectBoxSkin; } }
        private static GUISkin selectBoxSkin;
        private static Bounds invalidBounds = new Bounds(new Vector3(-99999 , -99999 , -99999) , new Vector3(0 , 0 , 0));

        // OTHER
        public static int Details_Bar_Height { get { return 40; } }
    }

}
