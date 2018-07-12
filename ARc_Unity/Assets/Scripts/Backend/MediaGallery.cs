using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class MediaGallery : DatabaseObject {

    // variables
    private Profiable profiable;
    private List<RawImage> images;
    private List<VideoClip> videos;

    private string constantLabel = "Media Gallery";

    // constructors
    private void init()
    {
        profiable = null;
        images = new List<RawImage>();
        videos = new List<VideoClip>();
        this.databaseObjectInit(constantLabel);
    }

    private void init(Profiable profiable, List<RawImage> images, List<VideoClip> videos)
    {
        this.profiable = profiable;
        this.images = images;
        this.videos = videos;
        this.databaseObjectInit(constantLabel);
    }

    public static MediaGallery CreateInstance()
    {
        MediaGallery gallery = CreateInstance<MediaGallery>();
        gallery.init();
        return gallery;
    }

    public static MediaGallery CreateInstance(Profiable profiable, List<RawImage> images, List<VideoClip> videos)
    {
        MediaGallery gallery = CreateInstance<MediaGallery>();
        gallery.init(profiable, images, videos);
        return gallery;
    }

    // setters
    protected override void setTypeID() {
        this.typeID = DatabaseObject.MEDIAGALLERY;
    }

    public void setProfiable(Profiable profiable) {
        this.profiable = profiable;
    }

    // getters
    public Profiable getProfiable() {
        return profiable;
    }

    public List<RawImage> getImages()
    {
        return images;
    }

    public List<VideoClip> getVideos()
    {
        return videos;
    }

}
