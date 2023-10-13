using System;
using UnityEngine;

public class MonoTickProvider : MonoBehaviour,ITickProvider
{
    public event Action OnTick;

    private void Update()
    {
        OnTick?.Invoke();
    }
}
