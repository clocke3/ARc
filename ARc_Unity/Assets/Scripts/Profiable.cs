using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Profiable : MonoBehaviour
{
    private int typeID, qrID;

    private int getTypeID(){
        return typeID;
    }
    private int getQRID(){
        return qrID;
    }
}
