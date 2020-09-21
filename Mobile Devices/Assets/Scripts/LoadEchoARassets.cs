using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AsImpL;
using Siccity.GLTFUtility;
using System.Globalization;
using UnityEngine.Video;
using UnityEngine.Networking;
using SimpleJSON;
using System.IO;

public class LoadEchoARassets : MonoBehaviour
{

    public string APIKey = "orange-pine-2283";
    private string serverURL;

    private echoAR echo = new echoAR();

    public List<string> keys = new List<string>();



    // echoAR Database
    static public Database dbObject;

    public void LionKeyFun()
    {
        // Debug logs control
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
            Debug.logger.logEnabled = false;
#endif

        // The echoAR server details
        serverURL = "https://console.echoar.xyz/query?key=" + APIKey;

        // Run the database query subroutine followed by assets download subroutine
        try
        {
            // Query database for all the entires
            //StartCoroutine(echo.QueryDatabase(serverURL));
            // What to query a single entry? Replace the above line with:
            StartCoroutine(echo.QueryDatabase(serverURL + "&entry=" + keys[0]));
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }

    }

    public void TigerKeyFun()
    {
        // Debug logs control
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
            Debug.logger.logEnabled = false;
#endif

        // The echoAR server details
        serverURL = "https://console.echoar.xyz/query?key=" + APIKey;

        // Run the database query subroutine followed by assets download subroutine
        try
        {
            // Query database for all the entires
            StartCoroutine(echo.QueryDatabase(serverURL));
            // What to query a single entry? Replace the above line with:
            // StartCoroutine(QueryDatabase(serverURL + "&entry=<ENTRY_ID>"));
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }

    }

    public void BearKeyFun()
    {
        // Debug logs control
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
            Debug.logger.logEnabled = false;
#endif

        // The echoAR server details
        serverURL = "https://console.echoar.xyz/query?key=" + APIKey;

        // Run the database query subroutine followed by assets download subroutine
        try
        {
            // Query database for all the entires
            StartCoroutine(echo.QueryDatabase(serverURL));
            // What to query a single entry? Replace the above line with:
            // StartCoroutine(QueryDatabase(serverURL + "&entry=<ENTRY_ID>"));
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }

    }

    public void wolfKeyFun()
    {
        // Debug logs control
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
            Debug.logger.logEnabled = false;
#endif

        // The echoAR server details
        serverURL = "https://console.echoar.xyz/query?key=" + APIKey;

        // Run the database query subroutine followed by assets download subroutine
        try
        {
            // Query database for all the entires
            StartCoroutine(echo.QueryDatabase(serverURL));
            // What to query a single entry? Replace the above line with:
            // StartCoroutine(QueryDatabase(serverURL + "&entry=<ENTRY_ID>"));
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }

    }
    public void cowKeyFun()
    {
        // Debug logs control
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
            Debug.logger.logEnabled = false;
#endif

        // The echoAR server details
        serverURL = "https://console.echoar.xyz/query?key=" + APIKey;

        // Run the database query subroutine followed by assets download subroutine
        try
        {
            // Query database for all the entires
            StartCoroutine(echo.QueryDatabase(serverURL));
            // What to query a single entry? Replace the above line with:
            // StartCoroutine(QueryDatabase(serverURL + "&entry=<ENTRY_ID>"));
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }

    }

}
