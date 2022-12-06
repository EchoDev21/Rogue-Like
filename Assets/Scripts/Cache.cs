using UnityEngine;

public static class Cache
{
    private static Camera _mainCamera;

    public static Camera MainCamera
    {
        get
        {
            if (_mainCamera == null)
                _mainCamera = Camera.main;

            return _mainCamera;
        }
    }
}
