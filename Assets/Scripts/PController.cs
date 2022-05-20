using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour
{
    private MouseMove mouseMove;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseMove = GetComponent<MouseMove>();
    }
    private void Update()
    {
        UpdateRotate();
    }
    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mouseMove.UpdateRotate(mouseX, mouseY);
    }
}
