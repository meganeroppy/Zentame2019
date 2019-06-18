// (c) 2019-2019 Kid"sPlates Inc.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Woojer;

[RequireComponent( typeof( WoojerBehaviour ) )]
public class VestTest : MonoBehaviour
{
    public enum vestPos
    {
        LeftFront,
        RightFront,
        LeftSide,
        RightSide,
        LeftBack,
        RightBack,
        LeftEar,
        RightEar,
    }

    float[] currentValues = new float[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

    KeyCode[] increateKeyCodes = new KeyCode[8]
    {
        KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R, KeyCode.T, KeyCode.Y, KeyCode.U, KeyCode.I,
    };

    KeyCode[] decreateKeyCodes = new KeyCode[8]
    {
        KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.J, KeyCode.K,
    };

    const int partsCount = 8; 

    WoojerBehaviour woojer = null;

    [SerializeField]
    float maxValue = 200f;

    [SerializeField]
    float minValue = 0f;

    [SerializeField]
    float changeSpeed = 1f;

    [SerializeField]
    bool logValues = false;

    // Start is called before the first frame update
    void Awake()
    {
        woojer = GetComponent<WoojerBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInput();
        UpdateVibrate();
        UpdateLog();
    }

    void UpdateInput()
    {
        float add = 0;

        for( int i = 0; i < partsCount; ++i )
        {
            add = (Input.GetKey(increateKeyCodes[i]) ? changeSpeed : Input.GetKey(decreateKeyCodes[i]) ? -changeSpeed : 0) * Time.deltaTime;

            currentValues[i] = Mathf.Clamp(currentValues[i] + add, minValue, maxValue);
        }
    }

    void UpdateVibrate()
    {
        if( woojer.Impact != WoojerBehaviour.ImpactType.NonSpatial_Specific)
        {
            woojer.Impact = WoojerBehaviour.ImpactType.NonSpatial_Specific;
        }

        woojer.Channel3 = currentValues[0];
        woojer.Channel4 = currentValues[1];
        woojer.Channel5 = currentValues[2];
        woojer.Channel6 = currentValues[3];
        woojer.Channel7 = currentValues[4];
        woojer.Channel8 = currentValues[5];
        woojer.LeftEar  = currentValues[6];
        woojer.RightEar = currentValues[7];
    }

    /// <summary>
    /// 高負荷なので普段は無効に
    /// </summary>
    void UpdateLog()
    {
        if (!logValues) return;

        var c = currentValues;

        var str = "";

        for( int i=0; i< partsCount; ++i  )
        {
            str += c[i].ToString() + ", ";
        }

        Debug.Log(str);
    }
}
