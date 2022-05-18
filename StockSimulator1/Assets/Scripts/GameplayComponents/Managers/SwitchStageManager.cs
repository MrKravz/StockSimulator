using Assets.Scripts.Manager;
using UnityEngine;

namespace Assets.Scripts
{
   
    public class SwitchStageManager : MonoBehaviour
    {
        private void OnMouseDown()
        {
            new StageManager().SwitchStage();
        }
    }
}
