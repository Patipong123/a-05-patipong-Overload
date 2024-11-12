using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    private float speedMultiplier = 2.0f;
    private float duration = 5.0f;
    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(speedMultiplier, duration);
    }
}
