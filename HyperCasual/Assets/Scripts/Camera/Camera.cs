
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    private Vector3 inirialRotation;
    private void Awake()
    {
        inirialRotation = transform.eulerAngles;
    }

    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);

        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x+inirialRotation.x, playerTransform.eulerAngles.y+inirialRotation.y, 0);
    }
}
