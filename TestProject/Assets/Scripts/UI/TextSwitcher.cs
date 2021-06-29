using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(TMP_Text))]
public class TextSwitcher : MonoBehaviour
{
    [Header("Image tracking")]
    [SerializeField] private ImageTracker _imageTracker;
    [SerializeField] string _imageTrackerText = "Image tracking";

    [Header("Plane tracking")]
    [SerializeField] private PlaneTracker _planeTracker;
    [SerializeField] string _planeTrackerText = "Plane tracking";

    private TMP_Text _currentTracking;

    private void Start()
    {
        _currentTracking = GetComponent<TMP_Text>();
        OnButtonClicked();
    }

    public void OnButtonClicked()
    {
        if (_imageTracker.enabled)
            _currentTracking.text = _imageTrackerText;
        else if (_planeTracker.enabled)
            _currentTracking.text = _planeTrackerText;
        else
            _currentTracking.text = "";
    }
}
