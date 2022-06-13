using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrainingButton : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] Button button;
    // Start is called before the first frame update
    void Awake()
    {
        button.onClick.AddListener(() => text.SetText("900$"));
    }

    void OnDestroy()
    {
        button.onClick.RemoveAllListeners();
    }
}
