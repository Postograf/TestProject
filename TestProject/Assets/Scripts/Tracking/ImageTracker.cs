using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracker : MonoBehaviour
{
    [SerializeField] private GameObject _trackedObject;

    private ARTrackedImageManager _trackedImageManager;
    private ARTrackedImage _trackedImage;

    private void Awake()
    {
        _trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        _trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }
    
    private void OnDisable()
    {
        _trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        _trackedObject.SetActive(false);
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs obj)
    {
        if ((_trackedImage == null || obj.removed.Contains(_trackedImage)) && obj.added.Count > 0) 
        {
            _trackedImage = obj.added[0];
        }

        if (_trackedImage != null)
        {
            _trackedObject.transform.position = _trackedImage.transform.position;
            _trackedObject.SetActive(true);
        }
        else
        {
            _trackedObject.SetActive(false);
        }
    }
}
