using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationImage : MonoBehaviour {

    // variables
    private ProfileManager profileManager;
    public Image image;

    //set up
    public void setup(ProfileManager profileManager, Sprite sprite) {
        this.profileManager = profileManager;
        if(sprite != null) {
            this.image.sprite = sprite;
        }
        this.transform.SetAsLastSibling();
        profileManager.gameObject.SetActive(false);
    }

    //back
    public void back() {
        if (profileManager != null) {
            profileManager.gameObject.SetActive(true);
        }
        Destroy(this.gameObject);
    }

}
