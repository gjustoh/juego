using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secure : MonoBehaviour
{
    private WWWForm secureform = null;
    private const string CONNECTION_PASSWORD= "oG(!%](d]%%},Zz._leGWP<|KNw8^4";
    private const string ANDROID_PASSWORD= "uN-{UvuE2tp!8|0a!2-VyBBLz9x*;F";
    public  WWWForm secureformulario{
        get{
            return secureform;
        }
    }
    public secure(){
        secureform = new WWWForm();
        secureform.AddField("connectionPass",CONNECTION_PASSWORD);
    #if UNITY_ANDROID
        secureform.AddField("oss","android");
        secureform.AddField("platformPasss",ANDROID_PASSWORD);
    #endif
    }
 
}
