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

    // constructor
    public MediaGallery() : base("") {
        videos = new List<VideoClip>();
        images = new List<RawImage>();
        profiable = null;
    }

    public MediaGallery(string label, Profiable profiable, List<RawImage> images, List<VideoClip> videos) : base(label) {
        this.profiable = profiable;
        this.videos = videos;
        this.images = images;
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
