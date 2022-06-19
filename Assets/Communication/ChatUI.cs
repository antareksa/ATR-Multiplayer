using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ATR
{
    public class ChatUI : MonoBehaviour
    {
        public string ChatString => _chatInput.text;
        [SerializeField] private TMP_InputField _chatInput;

        public void Reset()
        {
            _chatInput.text = "";
        }
    }
}
