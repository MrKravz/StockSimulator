using System;

namespace Assets.Scripts
{
    [Serializable]
    public class Headline
    {
        public string Text { get; set; } = default;
        public int Percent { get; set; } = default;
        public Headline(string text, int percent)
        {
            Text = text;
            Percent = percent;
        }
    }
}
