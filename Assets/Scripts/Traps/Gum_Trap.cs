using UnityEngine;

public class Gum_Trap : Trap
{
    public override void Interact()
    {
        gameObject.SetActive(false);
    }
}