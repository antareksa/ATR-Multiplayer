using UnityEngine;

namespace ATR.Communication.Emote
{
    [CreateAssetMenu(fileName = "EmoteData", menuName = "ATR/Emote", order = 1)] 
    public class EmoteObject : ScriptableObject
    {
        public string emoteName;
        public Sprite emoteSprite;
    }
}
