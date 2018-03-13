using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using RedRunner.Collectables;

namespace RedRunner.UI
{

    public class UIHeartImage : Image
    {
        protected override void Awake()
        {
            Heart.OnHeartCollected += Heart_OnHeartCollected;
            base.Awake();
        }

        void Heart_OnHeartCollected (Heart Heart)
        {
            GetComponent<Animator>().SetTrigger("Collect");
        }
    }

}