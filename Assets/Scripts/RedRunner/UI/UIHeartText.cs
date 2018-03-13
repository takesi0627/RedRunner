using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RedRunner.Collectables;

namespace RedRunner.UI
{

    public class UIHeartText : UIText
    {

        [SerializeField]
        protected string m_HeartTextFormat = "x {0}";

        protected override void Awake()
        {
            GameManager.OnHeartChanged += GameManager_OnHeartChanged;
            Heart.OnHeartCollected += Heart_OnHeartCollected;
            base.Awake();
        }

        void Heart_OnHeartCollected(Heart coin)
        {
            GetComponent<Animator>().SetTrigger("Collect");
        }

        void GameManager_OnHeartChanged(int coin)
        {
            text = string.Format(m_HeartTextFormat, coin);
        }

    }

}