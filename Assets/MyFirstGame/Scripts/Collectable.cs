using UnityEngine;

class Collectable : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] Bounds teleportArea;

    public int GetValue()
    {
        return value;
    }

    public void OnCollect()
    {
        float x = Random.Range(teleportArea.min.x, teleportArea.max.x);
        float y = Random.Range(teleportArea.min.y, teleportArea.max.y);
        float z = Random.Range(teleportArea.min.z, teleportArea.max.z);
        Vector3 newPosition = new(x, y, z);
        transform.position = newPosition;

    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(teleportArea.center, teleportArea.size);
    }
}

