using System.Collections.Generic;
using System;

namespace Assets.Scripts.News
{
    [Serializable]
    public class Newspaper
    {
        public List<Subject> Subjects { get; private set; } = default;
        public Newspaper(List<Subject> subjects)
        {
            Subjects = subjects;
        }
    }
}
