using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ShootArrow : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private TextMeshProUGUI firePowerText;
    private double maxFirePower = 5;
    private double firePowerSpeed = 5f;
    private double firePower = 0;
    private bool chargingBow = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            chargingBow = true;
        }

        if (chargingBow && firePower < maxFirePower)
        {
            firePower += Time.deltaTime * firePowerSpeed;
        }

        if (chargingBow && Input.GetMouseButtonUp(1))
        {
            Shoot();
            firePower = 0;
            chargingBow = false;
        }

        firePowerText.text = "Fire Power = " + String.Format("{0:.##}", firePower);
    }

    void Shoot()
    {
        print("Shot an arrow!");
    }
}
