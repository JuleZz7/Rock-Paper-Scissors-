using UnityEngine;
using UnityEngine.Events;

public class AnimationEventHandler : MonoBehaviour
{
    public UnityEvent ExecuteEvent;

    public void Execute()
    {
        ExecuteEvent.Invoke();
    }

}
