using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    private void Start()
    {
        UIManager.OpenUI<MainTitleUI>("Prefab/MainTitleUI");
    }
}