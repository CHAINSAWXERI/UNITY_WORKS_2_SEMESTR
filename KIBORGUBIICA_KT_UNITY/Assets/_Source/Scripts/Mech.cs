using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mech : MonoBehaviour
{
    [SerializeField]
    private LegData[] legs;

    [SerializeField]
    private float stepLength;

    private void Update()
    {
        foreach (var legData in legs)
        {
            if (!legData.Leg.IsMoving && !(Vector3.Distance(legData.Leg.Position, legData.Raycast.Position) > stepLength)) continue;
            legData.Leg.MoveTo(legData.Leg.Position);
        }
    }

    [Serializable]
    private struct LegData
    {
        public LegTarget Leg;
        public LegRaycast Raycast;
    }
}