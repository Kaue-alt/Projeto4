using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class MonetizationManager : MonoBehaviour//, IUnityAdsListener
{
    void Start()
    {
        DontDestroyOnLoad(this);

        string gameId = "";

#if UNITY_IOS
        gameId = "3880052";
#elif UNITY_ANDROID
        gameId = "3880053";
#endif
        //Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, Debug.isDebugBuild);
    }

    public void ShowInterstitial()
    {
        Advertisement.Show("Interstitial");
    }

    //------------------------------------------------------------------------------------- 
    //public void OnUnityAdsReady(string placementId)
    //{
        //executa quando um placemenrId está pronto para ser mostrado na tela
    //}

    //public void OnUnityAdsDidError(string message)
    //{
        //Debug.LogError("UNITY ADS ERROR: " + message);
    //}

    //public void OnUnityAdsDidStart(string placementId)
    //{
        
    //}

    //public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    //{
        //if (placementId == "rewardedVideo" && showResult == ShowResult.Finished)
        //{

        //}

    //}

    //public void ShowRewarded()
    //{
        //Advertisement.Show("rewardedVideo");
    //}
}
