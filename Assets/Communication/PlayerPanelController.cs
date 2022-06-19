using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ATR
{
    public class PlayerPanelController : MonoBehaviour
    {
        public Transform targetTransform;
        
        Quaternion originalRotation;
        
        void Start()
        {
            originalRotation = transform.rotation;
        }
        void Update()
        {
            transform.rotation = targetTransform.rotation * transform.rotation;

        }
    }
}
