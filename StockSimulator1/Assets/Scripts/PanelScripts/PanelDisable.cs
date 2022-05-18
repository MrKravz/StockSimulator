using UnityEngine;
using UnityEngine.UI;
public class PanelDisable : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Button button;
    private void Awake()
    {
        button.onClick.AddListener(() => panel.SetActive(false));
    }
    private void OnDestroy()
    {
        button.onClick.AddListener(() => panel.SetActive(false));
    }
}
