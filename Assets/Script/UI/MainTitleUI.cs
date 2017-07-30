using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainTitleUI : UI
{
    void Start()
    {
        UIHelper.AddButtonListener(Vars["startButton"], () =>
        {
            UIManager.OpenUI<PopupSample>("Prefab/PopupSample", UIManager.UIType.ClosingModal);
        });

        UIHelper.AddButtonListener(Vars["changeSceneButton"], () =>
        {
            string nextScene = SceneManager.GetActiveScene().name == "scene1" ? "scene2" : "scene1";
            SceneManager.LoadScene(nextScene);
        });

        UIHelper.SetText(Vars["titleText"], "scene name: " + SceneManager.GetActiveScene().name);
    }
}