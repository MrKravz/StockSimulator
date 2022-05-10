using UnityEngine;

namespace Assets.Scripts
{
   
    class SwitchStageManager : MonoBehaviour
    {
        [SerializeField] GameplayManager gameplayManager;
        private void OnMouseDown()
        {
            gameplayManager.SwitchStage();
        }
    }
}
