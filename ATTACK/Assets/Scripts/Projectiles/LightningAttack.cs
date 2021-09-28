using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningAttack : ParticleSystemAttack
{
    protected override void UpdateCharge(ref ParticleSystem Charge)
    {
        float MaxScale = 0.1f;
        float scale = 1 - ((FireStartTime - SimulationTime) / FireStartTime);
        scale *= MaxScale;
        if (scale < 0)
            scale = 0;

        Charge.transform.localScale = new Vector3(scale, scale, scale);
    }
}