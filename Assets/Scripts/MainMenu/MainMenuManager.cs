using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] private Button startBtn;

    private void Awake()
    {
        startBtn.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.Demo);
        });
    }

}
