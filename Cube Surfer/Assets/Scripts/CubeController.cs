using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private PlayerStackController playerStackController;

    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;


    void Start()
    {
        playerStackController = GameObject.FindObjectOfType<PlayerStackController>();
    }

    private void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if(Physics.Raycast(transform.position,direction,out hit, 1f)) //Boxcast would be better.
        {
            if (!isStack)
            {
                isStack = true;
                playerStackController.IncreaseBlockStack(gameObject);
                SetDirection();
            }
            if (hit.transform.name == "Obstacle")
            {
                playerStackController.DecreaseBlockStack(gameObject);
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
