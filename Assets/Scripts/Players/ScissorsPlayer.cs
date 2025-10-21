using UnityEngine;

public class ScissorsPlayer : PlayableCharacter
{

    private Trap hitTrap;
    public override void SpecialAbility()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(rayCastTransform.position, transform.forward, out hitInfo, specialAbilityDistance, specialAbilityLayerMask))
        {
            hitTrap = hitInfo.transform.GetComponentInParent<Trap>();
            // hitTrap.Interact();
            Debug.Log(hitTrap.gameObject.name);

        }


        Debug.Log("Scissors Interact");
    }

    public void Cut()
    {
        if (hitTrap != null)
        {
            hitTrap.Interact();
            hitTrap = null;
        }
    }

}


