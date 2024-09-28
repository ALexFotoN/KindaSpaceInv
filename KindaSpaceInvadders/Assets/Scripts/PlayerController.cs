using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveHorizontal, 0, 0) * moveSpeed * Time.deltaTime;

        float clampedX = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
