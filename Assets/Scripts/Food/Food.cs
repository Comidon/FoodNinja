using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Food : InteractionBehaviour
{
    public Assets.Scripts.Utilities.FoodType type;
    public Nutrition nutrition { get; protected set; }
}
