using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System;

public abstract class UI : MonoBehaviour
{
    public Dictionary<string, GameObject> Vars { get; set; }

    private void Awake()
    {
        AssignUIObjects();

        foreach (Transform child in transform)
        {
            if (UIManager.CloseButtonNames.Contains(child.gameObject.name))
            {
                child.gameObject.GetComponent<Button>().onClick.AddListener(() => Close());
            }
        }
    }

    public void Close()
    {
        OnClose();
        UIManager.CloseUI(this);
    }

    protected virtual void OnClose()
    {
    }

    private void AssignUIObjects()
    {
        Vars = new Dictionary<string, GameObject>();

        Transform[] transforms = transform.GetComponentsInChildren<Transform>(true);
        foreach (Transform transform in transforms)
        {
            GameObject obj = transform.gameObject;
            if (obj == gameObject)
                continue;

            if (transform.name.ToLower().StartsWith("ui:") == false)
                continue;

            string name = obj.name.Substring(3);
            if (Vars.ContainsKey(name))
            {
                throw new Exception("ui 중복 이름 존재 name: " + name);
            }

            Vars.Add(name, obj);
        }
    }
}