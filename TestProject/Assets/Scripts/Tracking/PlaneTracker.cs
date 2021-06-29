using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaneTracker : MonoBehaviour
{
    [SerializeField] private GameObject _trackedObject;
    private ARRaycastManager _raycastManager;

    private void Start()
    {
        _raycastManager = GetComponent<ARRaycastManager>();
    }

    private void Update()
    {
        var hits = new List<ARRaycastHit>();
        var screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);

        if (_raycastManager.Raycast(screenCenter, hits, TrackableType.Planes))
        {
            _trackedObject.SetActive(true);
            _trackedObject.transform.position = hits[0].pose.position;
            
        }
        else
        {
            _trackedObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        _trackedObject.SetActive(false);
    }
}