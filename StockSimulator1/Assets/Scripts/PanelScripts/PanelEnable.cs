using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PanelScripts
{
    public class PanelEnable : MonoBehaviour
    {
        [SerializeField] GameObject panel;
        [SerializeField] Button button;
        private void Awake()
        {
            button.onClick.AddListener(() => panel.SetActive(true));
            var audio = button.GetComponent<AudioSource>();
            button.onClick.AddListener(() => audio.Play());
        }
        private void OnDestroy()
        {
            button.onClick.RemoveAllListeners();
        }
    }
}