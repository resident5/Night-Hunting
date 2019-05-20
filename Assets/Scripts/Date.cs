using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Date : MonoBehaviour
{
    public Npc npc;


    public Image thisPlaceHolder;
    public Image thisDialogBox;

    public TMP_Text thisName;
    public TMP_Text thisDialog;

    public Image[] thisDateArt;

    void Start()
    {

        thisPlaceHolder.sprite = npc.art;
        thisDialogBox.sprite = npc.dialogBoxArt;

        thisName.text = npc.myName;
        thisDialog.text = npc.textPlace;

    }

    void Update()
    {

    }
}
