using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField]
    //private GameObject r_weaponPrefab;
    [SerializeField]
    private Transform handPlace;

    [SerializeField]
    private PlayerWeapon myWeapon;


    private float distansWeapon;
    private bool withMe;

    private void Awake()
    {
        
        withMe = true;
        //r_myWeapon = Instantiate(r_weaponPrefab, r_handPlace.transform.position, Quaternion.identity).GetComponent<PlayerWeapon>();
        myWeapon.transform.SetParent(handPlace);
        myWeapon.transform.localRotation = Quaternion.Euler(Vector3.zero);
        myWeapon.transform.localPosition = Vector3.zero;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Throw();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
    }

    public void Throw()
    {
        myWeapon.transform.SetParent(null);
        myWeapon.Throw();
        withMe = false;
    }

    public void PickUp()
    {
        myWeapon.PickUp();
        myWeapon.transform.SetParent(handPlace);
        myWeapon.transform.localRotation = Quaternion.Euler(Vector3.zero);
        myWeapon.transform.localPosition = Vector3.zero;
        withMe = true;
    }

}
