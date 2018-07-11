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

    // constructors
    private void init()
    {
        profiable = null;
        images = new List<RawImage>();
        videos = new List<VideoClip>();
        this.databaseObjectInit();
    }

    private void init(string label, Profiable profiable, List<RawImage> images, List<VideoClip> videos)
    {
        this.profiable = profiable;
        this.images = images;
        this.videos = videos;
        this.databaseObjectInit(label);
    }

    public static MediaGallery CreateInstance()
    {
        MediaGallery gallery = CreateInstance<MediaGallery>();
        gallery.init();
        return gallery;
    }

    public static MediaGallery CreateInstance(string label, Profiable profiable, List<RawImage> images, List<VideoClip> videos)
    {
        MediaGallery gallery = CreateInstance<MediaGallery>();
        gallery.init(label, profiable, images, videos);
        return gallery;
    }

    // setters
    protected override void setTypeID() {
        this.typeID = DatabaseObject.MEDIAGALLERY;
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
