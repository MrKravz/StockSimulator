using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnTextClickRoom : MonoBehaviour
{
    [SerializeField] ElementsHeld elements;
    [SerializeField] int counter;
    private void OnMouseDown()
    {

        RoomTrainigScenrio scenrio = new RoomTrainigScenrio(elements._text, elements.sprites);
        scenrio.OnTextPressed.Invoke(counter);
        counter++;
    }
}
