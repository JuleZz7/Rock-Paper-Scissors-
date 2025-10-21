using UnityEngine;

public class Cable_Trap : Trap
{
   
    public override void Interact()
    {
        gameObject.SetActive(false);
    }

}