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
    public RawImage imagePrefab;
    public GameObject videosParent;
    public VideoPlayer videoPlayerPrefab;

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
            List<RawImage> images = gallery.getImages();
            foreach (RawImage image in images)
            {
                RawImage imageHolder = Instantiate(imagePrefab, transform.position, Quaternion.identity) as RawImage;
                imageHolder = image;
                imageHolder.transform.SetParent(picturesParent.transform, true);
            }
        }

        // set up videos
        if (gallery.getVideos() != null)
        {
            List<VideoClip> videos = gallery.getVideos();
            foreach (VideoClip video in videos)
            {
                VideoPlayer videoPlayer = Instantiate(videoPlayerPrefab, transform.position, Quaternion.identity) as VideoPlayer;
                videoPlayer.clip = video;
                videoPlayer.transform.SetParent(videosParent.transform, true);
            }
        }
    }
}
