using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    private bool movingRight = true;

    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * (movingRight ? 1 : -1));

        if (transform.position.x > 8f || transform.position.x < -8f)
        {
            movingRight = !movingRight;
            transform.position += Vector3.down;
        }
    }
}
