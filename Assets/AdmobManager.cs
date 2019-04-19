using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobManager : MonoBehaviour
{
    private BannerView bannerView;

    private string appID = "ca-app-pub-6620332441930474~4498556904";
    private string bannerID = "ca-app-pub-6620332441930474/6905228392";
    private string regularID = "ca-app-pub-6620332441930474/9695043267";

    private void Awake()
    {
        MobileAds.Initialize(appID);
    }

    public void OnclickShowBanner()
    {
        this.RequestBanner();
    }
    public void OnclickShowrAD()
    {
        this.RequestRegularAD();
    }
    private void RequestBanner()
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }

    private void RequestRegularAD()
    {
        InterstitialAd AD = new InterstitialAd(regularID);

        AdRequest request = new AdRequest.Builder().Build();

        AD.LoadAd(request);
        AD.Show();
    }

}
