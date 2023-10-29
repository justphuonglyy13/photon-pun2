using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoomCanvas : MonoBehaviour
{
    private RoomCanvases _roomCanvases;

    public void FirstInitialize(RoomCanvases canvases) {
        _roomCanvases = canvases;
    } 

    public void Show() {
        gameObject.SetActive(true);
    }

    public void Hide() {
        gameObject.SetActive(false);
    }
}