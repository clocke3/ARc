using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MediaGalleryBlock : Panel
{
    // variables
    private MediaGallery gallery;
    public Text label;
    public Text profiableHeader;
    public DatabaseObjectButton profiableButton;
    public GameObject picturesParent;
    public Image imagePrefab;
    public Text noPicsLabel;

    // panel stuff
    protected override void setToRepresent(DatabaseObject databaseObject)
    {
        if (databaseObject is MediaGallery) gallery = databaseObject as MediaGallery;
    }

    protected override void setAttributes()
    {
        if (gallery.getProfiable() != null)
        {
            Profiable profiable = gallery.getProfiable();

            // set up gallery label
            label.text = profiable.getLabel() + " Gallery";

            // set up profiable header
            switch (profiable.getTypeID())
            {
                case DatabaseObject.DEPARTMENT:
                    profiableHeader.text = "Department:";
                    break;
                case DatabaseObject.EMPLOYEE:
                    profiableHeader.text = "Employee:";
                    break;
                default:
                    break;
            }

            // set up profiable button
            profiableButton.setup(this, profiable);
        }

        // set up pictures
        if (gallery.getImages() != null)
        {
            if (gallery.getImages().Count == 0 || gallery.getImages()[0] == null)
            {
                noPicsLabel.gameObject.SetActive(true);
            }
            else
            {
                List<Sprite> images = gallery.getImages();
                foreach (Sprite image in images)
                {
                    Image imageHolder = Instantiate(imagePrefab, transform.position, Quaternion.identity) as Image;
                    imageHolder.sprite = image;
                    imageHolder.transform.SetParent(picturesParent.transform, true);
                }
            }
        } else {
            noPicsLabel.gameObject.SetActive(true);
        }
    }
}
