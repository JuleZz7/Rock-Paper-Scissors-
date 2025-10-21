using UnityEngine;

public abstract class Trap : MonoBehaviour
{
    public int Damage = 1;
    public abstract void Interact();

    public virtual void ApplyDamage(IDamagable damagable)
    {
        damagable.TakeDamage(Damage);
    }
}
