using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationButton : MonoBehaviour {

    // variables
    public LocationImage locationImagePrefab;
    private ProfileManager profileManager;
    private Sprite sprite;

    // set up
    public void setup(ProfileManager profileManager, Sprite sprite) {
        this.profileManager = profileManager;

        if(sprite == null) {
            this.sprite = Resources.Load<Sprite>("Sprites/LocationSprites/Default");
        } else {
            this.sprite = sprite;
        }
    }

    // on click
    public void showLocation() {
        if (profileManager == null) return;
        LocationImage location = Instantiate(locationImagePrefab, profileManager.GetComponentInParent<Canvas>().transform) as LocationImage;
        location.setup(profileManager, sprite);
    }

}
