using Assets.Scripts.GameplayComponents.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MobileSwitch : MonoBehaviour
{
    [SerializeField] string scene;
    private void OnMouseDown()
    {
        if (GameplayManager.gameplayModel.Ocassion != default)
        {
            SceneManager.LoadScene(scene);
        }
    }

}
