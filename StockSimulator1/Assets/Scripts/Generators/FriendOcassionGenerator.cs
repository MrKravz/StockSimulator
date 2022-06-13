using Assets.Scripts.GameplayComponents;
using System.Collections.Generic;

namespace Assets.Scripts.Generators
{
    public class FriendOcassionGenerator
    {
        public FriendOcassion GetOcassion(List<FriendOcassion> ocassions)
        {

            if (UnityEngine.Random.Range(1, 10) % 2 == 0)
            {
                return ocassions[UnityEngine.Random.Range(0, ocassions.Count - 1)];
            }
            return default;
        }
    }
}
