using System;
using Assets;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{

    [SerializeField] private LevelData _levelData = null;
    [SerializeField] private Button _levelButtom = null;
    [SerializeField] private Button _themeButtom = null;
    
    public void SetDifficult(int value)
    {
        _levelData.MaxPlayCards = value;
    }

    public void SetTheme(string name)
    {
        _levelData.ThemeName = name;
    }

    private void OnEnable()
    {
        _levelButtom.onClick.Invoke();
        _themeButtom.onClick.Invoke();
    }
}

