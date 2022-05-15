using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplaySceneSwitch : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] string sceneName;
    void Awake()
    {
        button.onClick.AddListener(() => SceneManager.LoadScene(sceneName));
    }
    private void OnDestroy()
    {
        button.onClick.RemoveListener(() => SceneManager.LoadScene(sceneName));
    }
}