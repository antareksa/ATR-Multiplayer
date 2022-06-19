using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Photon.Voice;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ATR.Communication.Emote;

namespace ATR.Communication
{
    public class ChatboxController : MonoBehaviour
    {
        public string ChatString
        {
            set => _chatTextBox.text = value;
        }
        public Sprite Emote
        {
            set => _emoteSprite.sprite = value;
        }

        [SerializeField] private TMP_Text _chatTextBox;
        [SerializeField] private Image _emoteSprite;

        [SerializeField] private int _delayTime;

        private void OnEnable()
        {
            PopUp();
        }

        private async void PopUp()
        {
            await Task.Delay(TimeSpan.FromSeconds(_delayTime));
            Destroy(this.gameObject);
        }
    }
}
