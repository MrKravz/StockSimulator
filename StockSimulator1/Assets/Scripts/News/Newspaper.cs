using System.Collections.Generic;

namespace Assets.Scripts.News
{
    public class Newspaper
    {
        public List<Subject> Subjects { get; private set; } = default;
        public Newspaper(List<Subject> subjects)
        {
            Subjects = subjects;
        }
    }
}
