using Assets.Scripts.GameplayComponents.Managers;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FriendOcassionManager : MonoBehaviour
{
    [SerializeField] TMP_Text speaker;
    [SerializeField] TMP_Text subject;

    void Awake()
    {
        speaker.text = GameplayManager.gameplayModel.Ocassion.NameOfFriend;
        subject.text = GameplayManager.gameplayModel.Ocassion.Text;
    }

}
