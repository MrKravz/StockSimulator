using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Threading;
using UnityEngine.SceneManagement;

public class RoomTrainigScenrio
{
    List<GameObject> _text;
    List<GameObject> _sprites;
    public Action<int> OnTextPressed;
    
    public RoomTrainigScenrio(List<GameObject> text, List<GameObject> sprites)
    {
        _text = text;
        _sprites = sprites;
        OnTextPressed += FirstPart;
        OnTextPressed += SecondPart;
        OnTextPressed += ThirdPart;
        OnTextPressed += FourthPart;
        OnTextPressed += FifthPart;
        OnTextPressed += SixPart;
    }
    public void FirstPart(int index)
    {
        if (index == 1)
        {
            _text[index-1].SetActive(false);
            _text[index].SetActive(false);
            _text[index + 1].SetActive(true);
            _text[index + 2].SetActive(true);
            _sprites[index - 1].SetActive(true);
        }
    }
    public void SecondPart(int index)
    {
        if (index == 2)
        {
            _text[index].SetActive(false);
            _text[index + 1].SetActive(false);
            _sprites[index - 2].SetActive(false);
        }
    }
    public void ThirdPart(int index)
    {
        if (index == 3)
        {
            _text[index + 1].SetActive(false);
            _text[index + 2].SetActive(false);
            _sprites[index - 2].SetActive(false);
            _text[index + 3].SetActive(true);
            _text[index + 4].SetActive(true);
            _sprites[index - 1].SetActive(true);
        }
    }
    public void FourthPart(int index)
    {
        if (index == 4)
        {
            _text[index - 4].SetActive(false);
            _text[index - 3].SetActive(false);
            _sprites[index - 4].SetActive(false);
            _text[index - 2].SetActive(true);
            _text[index - 1].SetActive(true);
            _sprites[index - 3].SetActive(true);
        }
    }
    public void FifthPart(int index)
    {
        if (index == 5)
        {
            _text[index + 3].SetActive(false);
            _text[index + 4].SetActive(false);
            _sprites[index - 2].SetActive(false);
            _text[index + 5].SetActive(true);
            _text[index + 6].SetActive(true);
            _sprites[index - 1].SetActive(true);
        }
    }
    public void SixPart(int index)
    {
        if (index == 6)
        {
            _text[index + 4].SetActive(false);
            _text[index + 5].SetActive(false);
            _sprites[index - 2].SetActive(false);
        }
    }
}
