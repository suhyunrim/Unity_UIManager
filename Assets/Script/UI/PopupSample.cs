using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupSample : UI
{
    private void Start()
    {
        UIHelper.AddButtonListener(Vars["acceptButton"], OnAccept);
        UIHelper.AddButtonListener(Vars["rejectButton"], OnReject);
    }

    private void OnAccept()
    {
        Debug.Log("OnAccpet");
    }

    private void OnReject()
    {
        Debug.Log("OnReject");
    }
}