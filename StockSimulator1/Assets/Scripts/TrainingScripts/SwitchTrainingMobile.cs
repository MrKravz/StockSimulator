using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchTrainingMobile : MonoBehaviour
{
    [SerializeField] string scene;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
    }
}
