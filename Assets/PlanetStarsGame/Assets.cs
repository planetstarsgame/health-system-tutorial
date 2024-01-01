/* 
    ------------------- Planet Stars Game -------------------

    Thank you for downloading the Planet Stars Game Utilities
    I hope you find them useful in your projects
    If you have any questions use the contact form
    Cheers!
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlanetStarsGame {

    /*
     * Global Asset references
     * Edit Asset references in the prefab CodeMonkey/Resources/CodeMonkeyAssets
     * */
    public class Assets : MonoBehaviour {

        // Internal instance reference
        private static Assets _i; 

        // Instance reference
        public static Assets i {
            get {
                if (_i == null) _i = Instantiate(Resources.Load<Assets>("PlanetStarsGameAssets")); 
                return _i; 
            }
        }


        // All references
        
        public Sprite s_White;
        public Sprite s_Circle;

        public Material m_White;

    }

}
