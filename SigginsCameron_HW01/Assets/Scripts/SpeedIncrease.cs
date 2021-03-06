﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease : CollectibleBase
{
    [SerializeField] float _speedAmount = 5;

    protected override void Collect(Player player)
    {
        //pull motor from the player
        BallMotor _motor = player.GetComponent<BallMotor>();
        if (_motor != null)
        {
            _motor.MaxSpeed += _speedAmount;
        }
    }
}
