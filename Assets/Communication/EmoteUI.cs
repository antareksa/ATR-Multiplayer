using System;
using System.Collections;
using System.Collections.Generic;
using ATR.Communication;
using ATR.Communication.Emote;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

namespace ATR
{
    public class EmoteUI : MonoBehaviour
    {
        private CommunicationController communicationController;
        [SerializeField] private Transform emotePanel;
        [SerializeField] private List<EmoteObject> _emotes;
        [SerializeField] private GameObject emoteButtonPrefab;
        
        private void Start()
        {
            communicationController = CommunicationController.Instance;

            foreach (EmoteObject emote in _emotes)
            {
                GameObject temp = Instantiate(emoteButtonPrefab, emotePanel);
                temp.GetComponent<EmoteButton>().emoteObject = emote;
                temp.GetComponent<EmoteButton>().SetEmote(emote.emoteSprite);
                temp.GetComponent<Button>().onClick.AddListener(delegate { communicationController.SentEmote(emote); });
            }
        }
    }
}
