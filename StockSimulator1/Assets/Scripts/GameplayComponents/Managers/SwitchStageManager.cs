using UnityEngine;

namespace Assets.Scripts.GameplayComponents.Managers
{
   
    public class SwitchStageManager : MonoBehaviour
    {
        private void OnMouseDown()
        {
            new StageManager().SwitchStage();
        }
    }
}
