
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;



public class ads : MonoBehaviour, IUnityAdsListener
{

    string gameId = "3826179";
    string myPlacementId = "video";
    public string placementId = "bannerPlacement";

    bool testMode = false;
    public static bool play;


    // Initialize the Ads listener and service:
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
        // StartCoroutine(ShowBannerWhenInitialized());


///Propaganda rodapé:

            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show("banner");
        



    }


    public void sair()
    {
        gerador.gameOver();

        SceneManager.LoadScene("menu");

    }

    // public void OnUnityAdsReady(string placementId){
    //     if (placementId.Equals("banner"))
    //     {
    //         Advertisement.Banner.SetPosition(BannerPosition.CENTER);
    //         Advertisement.Banner.Show("banner");
    //     }
    // }
    public void ShowRewardedVideo()
    {
        if (!gerador.assistido)
        {
            controlShap.perdeu = false;
            gerador.assistido = true;

            play = true;
            // SceneManager.LoadScene("SampleScene");



 // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
        }



        // // Check if UnityAds ready before calling Show method:
        // if (Advertisement.IsReady(myPlacementId))
        // {
        //     Advertisement.Show(myPlacementId);
        // }
        // else
        // {
        //     Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        // }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            gerador.assistido = true;

            // SceneManager.LoadScene("SampleScene");

            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            gerador.ponto = 0;

            // SceneManager.LoadScene("menu");

            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            gerador.ponto = 0;

            // SceneManager.LoadScene("menu");


        }
    }


    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            // Optional actions to take when the placement becomes ready(For example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
}