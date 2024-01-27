using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    private Rigidbody myRB;

    private void Awake()
    {
        myRB = GetComponent<Rigidbody>();
        myRB.useGravity = false;
        myRB.isKinematic = true;
    }

    public void Throw()
    {
        myRB.useGravity = true;
        myRB.isKinematic = false;
    }

    public void PickUp()
    {
        myRB.useGravity = false;
        myRB.isKinematic = true;


    }
}
