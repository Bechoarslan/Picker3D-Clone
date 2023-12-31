using System;
using UnityEngine;
using UnityEngine.Events;

namespace RunTime.Signal
{
    public class CameraSignals : MonoBehaviour
    {
        #region Singleton

        public static CameraSignals Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        #endregion

       public Action onSetCameraTarget = delegate {  };
    }
}