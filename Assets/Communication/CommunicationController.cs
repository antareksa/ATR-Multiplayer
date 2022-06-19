using System;
using System.Collections;
using System.Collections.Generic;
using ATR.Communication;
using ATR.Communication.Emote;
using Packages.Rider.Editor.UnitTesting;
using UnityEngine;

namespace ATR.Communication
{
    public class CommunicationController : MonoBehaviour
    {
        [SerializeField] private GameObject _chatBoxPrefab;
        [SerializeField] private GameObject _playerPanel;

        [SerializeField] private ChatUI _chatUI;
        
        public static CommunicationController Instance { get; private set; }
        private void Awake() 
        {
            if (Instance != null && Instance != this) 
            {
                Debug.Log("tes");
                Destroy(this); 
            } 
            else 
            { 
                Instance = this; 
            } 
        }
        
        public void SentChat()
        {
            if (_chatUI.ChatString != String.Empty)
            {
                GameObject tempChatBox =  Instantiate(_chatBoxPrefab, _playerPanel.transform);
                tempChatBox.GetComponent<ChatboxController>().ChatString = _chatUI.ChatString;
                _chatUI.Reset();
            }
        }

        public void SentEmote(EmoteObject emote)
        {
            GameObject tempChatBox =  Instantiate(_chatBoxPrefab, _playerPanel.transform);
            tempChatBox.GetComponent<ChatboxController>().Emote = emote.emoteSprite;
        }
    }
}
