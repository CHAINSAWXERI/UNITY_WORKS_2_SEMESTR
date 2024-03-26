using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : IService
{
    private IFadeService fadeService;
    private ISoundPlayer soundPlayer;

    public ServiceLocator(IFadeService fadeService, ISoundPlayer soundPlayer)
    {
        this.fadeService = fadeService;
        this.soundPlayer = soundPlayer;
    }

    public T GetService<T>()
    {
        if (typeof(T) == typeof(IFadeService))
            return (T)fadeService;
        if (typeof(T) == typeof(ISoundPlayer))
            return (T)soundPlayer;

        return default(T);
    }
}

