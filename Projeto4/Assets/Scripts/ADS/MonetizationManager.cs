using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class MonetizationManager : MonoBehaviour
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

        Advertisement.Initialize(gameId, Debug.isDebugBuild);
    }

    public void ShowInterstitial()
    {
        Advertisement.Show("Interstitial");
    }


}
