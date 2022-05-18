using UnityEngine;
using UnityEngine.UI;
public class PanelEnable : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Button button;
    private void Awake()
    {
        button.onClick.AddListener(() => panel.SetActive(true));
    }
    private void OnDestroy()
    {
        button.onClick.AddListener(() => panel.SetActive(true));
    }
}
