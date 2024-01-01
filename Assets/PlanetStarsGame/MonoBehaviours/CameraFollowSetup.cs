/* 
    ------------------- Planet Stars Game -------------------

    Thank you for downloading the Planet Stars Game Utilities
    I hope you find them useful in your projects
    If you have any questions use the contact form
    Cheers!
    --------------------------------------------------
 */
 
using System.Collections.Generic;
using UnityEngine;

namespace PlanetStarsGame.MonoBehaviours {

    /*
     * Easy set up for CameraFollow, it will follow the transform with zoom
     * */
    public class CameraFollowSetup : MonoBehaviour {

        [SerializeField] private CameraFollow cameraFollow = null;
        [SerializeField] private Transform followTransform = null;
        [SerializeField] private float zoom = 50f;

        private void Start() {
            if (followTransform == null) {
                Debug.LogError("followTransform is null! Intended?");
                cameraFollow.Setup(() => Vector3.zero, () => zoom, true, true);
            } else {
                cameraFollow.Setup(() => followTransform.position, () => zoom, true, true);
            }
        }
    }

}