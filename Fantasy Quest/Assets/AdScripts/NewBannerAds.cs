using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class NewBannerAds : MonoBehaviour
{
    [SerializeField] BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;

    [SerializeField] string _androidAdUnitId = "Banner_Android";
    [SerializeField] string _iOSAdUnitId = "Banner_iOS";
    private string _adUnitId = null; // This will remain null for unsupported platforms.

    void Start()
    {
        // Get the Ad Unit ID for the current platform:
#if UNITY_IOS
        _adUnitId = _iOSAdUnitId;
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif

        // Set the banner position:
        Advertisement.Banner.SetPosition(_bannerPosition);

        // Load and show the banner ad:
        LoadAndShowBanner();
    }

    private void LoadAndShowBanner()
    {
        // Set up options to notify the SDK of load events:
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        // Load the banner:
        Advertisement.Banner.Load(_adUnitId, options);
    }

    private void OnBannerLoaded()
    {
        Debug.Log("Banner loaded successfully.");

        // Show the banner ad:
        Advertisement.Banner.Show(_adUnitId, new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        });
    }

    private void OnBannerError(string message)
    {
        Debug.LogError($"Banner failed to load: {message}");
        // Optionally retry or take alternative actions
    }

    private void OnBannerClicked()
    {
        Debug.Log("Banner clicked.");
    }

    private void OnBannerShown()
    {
        Debug.Log("Banner is now visible.");
    }

    private void OnBannerHidden()
    {
        Debug.Log("Banner hidden.");
    }
}
