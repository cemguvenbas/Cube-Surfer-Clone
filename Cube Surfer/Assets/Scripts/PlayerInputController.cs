using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private float horizontalValue;
    public float HorizontalValue
    {
        get { return horizontalValue; }
    }

    void Update()
    {
        HandleHorizontalInput();
    }

    private void HandleHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
