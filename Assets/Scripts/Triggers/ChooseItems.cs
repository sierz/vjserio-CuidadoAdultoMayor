﻿using UnityEngine;
using System.Collections;

public class ChooseItems : MonoBehaviour
{

    public GameObject ChooseItemsPanel;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            displayChoosePanel();
        }
    }

    public void displayChoosePanel()
    {
        if (DiaryAnimation.Instance.open) DiaryAnimation.Instance.displayDiary(DiaryAnimation.Instance.open);
        ChooseItemsPanel.SetActive(true);
        LeanTween.alphaCanvas(ChooseItemsPanel.GetComponent<CanvasGroup>(), 1, 0.7f);
        CameraHandler.Instance.FirstPersonMode = false;
        DestroyObject(gameObject);
        GameStatus.Instance.playerActions.Actions = "El jugador va a elegir los items para bañar a Winston";

    }
}
