﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RunTime.Signal
{
    public class CoreGameSignals : MonoBehaviour
    {
        #region Signelton

        public  static CoreGameSignals Instance;
        

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
        
        public UnityAction<byte> onLevelInitialize = delegate  {  };
        public UnityAction onClearActiveLevel = delegate {  };
        public UnityAction onLevelSuccessful = delegate {  };
        public UnityAction onLevelFail = delegate {  };
        public UnityAction onNextLevel = delegate {  };
        public UnityAction onRestartLevel = delegate {  };
        public UnityAction onReset = delegate {  };
        public Func<byte> onGetLevelValue = delegate { return 0;};
        
        public UnityAction onStageAreaEntered = delegate {  };
        public UnityAction<byte> onStageAreaSuccessful = delegate {  };
        public UnityAction onFinishAreaEntered = delegate {  } ;
        public UnityAction<short> onMiniGameAreaEntered = delegate {  };
        
        public Func<short> onGetCollectedObjectValue = delegate { return 0; };
        
        public UnityAction<Dictionary<Transform,float>> onSetMultiplier = delegate {  };
        
        public Func<float> onGetMultiplyValue = delegate { return 0; };
        
        public Func<byte> onWhichMiniGameAreaEntered = delegate { return 0; };
       
        
        
        
        
     
        
      
    
    
}
}
