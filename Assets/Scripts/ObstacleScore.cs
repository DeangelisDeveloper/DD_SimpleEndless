using UnityEngine;

public class ObstacleScore : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D collision)
    {
        Manager.instance.score++;
    }
}
