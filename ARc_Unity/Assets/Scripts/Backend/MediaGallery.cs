using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediaGallery : DatabaseObject {

    // variables
    private Profiable profiable;
    private List<Sprite> images;

    private string constantLabel = "Media Gallery";

    // constructors
    private void init()
    {
        profiable = null;
        images = new List<Sprite>();
        this.databaseObjectInit(constantLabel);
    }

    private void init(Profiable profiable, List<Sprite> images)
    {
        this.profiable = profiable;
        this.images = images;
        this.databaseObjectInit(constantLabel);
    }

    public static MediaGallery CreateInstance()
    {
        MediaGallery gallery = CreateInstance<MediaGallery>();
        gallery.init();
        return gallery;
    }

    public static MediaGallery CreateInstance(Profiable profiable, List<Sprite> images)
    {
        MediaGallery gallery = CreateInstance<MediaGallery>();
        gallery.init(profiable, images);
        return gallery;
    }

    // setters
    protected override void setTypeID() {
        this.typeID = DatabaseObject.MEDIAGALLERY;
    }

    public void setProfiable(Profiable profiable) {
        this.profiable = profiable;
        this.label = profiable.getLabel() + " " + constantLabel;
    }

    // getters
    public Profiable getProfiable() {
        return profiable;
    }

    public List<Sprite> getImages()
    {
        return images;
    }

}
