using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ImageTracker), typeof(PlaneTracker))]
public class TrackingSwitcher : MonoBehaviour
{
    private ImageTracker _imageTracker;
    private PlaneTracker _planeTracker;

    private void Awake()
    {
        _imageTracker = GetComponent<ImageTracker>();
        _planeTracker = GetComponent<PlaneTracker>();

        _imageTracker.enabled = true;
        _planeTracker.enabled = false;
    }

    public void OnButtonClicked()
    {
        SwitchTracking();
    }

    private void SwitchTracking()
    {
        _imageTracker.enabled = !_imageTracker.enabled;
        _planeTracker.enabled = !_planeTracker.enabled;
    }
}
