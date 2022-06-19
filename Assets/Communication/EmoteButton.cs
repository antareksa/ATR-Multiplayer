using System;
using System.Collections;
using System.Collections.Generic;
using ATR.Communication.Emote;
using UnityEngine;
using UnityEngine.UI;

namespace ATR
{
    public class EmoteButton : MonoBehaviour
    {
        public EmoteObject emoteObject;
        public Image emoteImage;
        private Button button;
        
        public void SetEmote(Sprite emoteSprite)
        {
            emoteImage.sprite = emoteSprite;
        }
        
    }
}
