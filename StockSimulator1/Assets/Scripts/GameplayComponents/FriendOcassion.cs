using System;

namespace Assets.Scripts.GameplayComponents
{
    [Serializable]
    public class FriendOcassion
    {
        public string NameOfFriend { get; private set; } = default;
        public string Text { get; private set; } = default;
        public int Amount { get; private set; } = default;
        public FriendOcassion(string nameOfFriend, string text, int amount)
        {
            NameOfFriend = nameOfFriend;
            Text = text;
            Amount = amount;
        }

    }
}
