using Unity.VisualScripting;
using UnityEngine;

public class FrostBolt : Ability
{
    [SerializeField] private float slowSpeed;

    protected override void ApplyEffect(GameObject target)
    {
        base.ApplyEffect(target);
    }
}
