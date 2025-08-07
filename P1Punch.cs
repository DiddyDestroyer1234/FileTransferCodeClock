using UnityEngine;

public class P1Punch : MonoBehaviour
{
    public float punchRadius = 1.5f;
    public int punchDamage = 10;
    public KeyCode punchKey = KeyCode.F;
    public LayerMask enemyLayer;
    public Transform punchOrigin; 

    void Update()
    {
        if (Input.GetKeyDown(punchKey))
        {
            Punch();
        }
    }

    void Punch()
    {
        Vector3 origin = punchOrigin != null ? punchOrigin.position : transform.position;

        Collider[] hitEnemies = Physics.OverlapSphere(origin, punchRadius, enemyLayer);

        if (hitEnemies.Length > 0)
        {
            foreach (Collider enemy in hitEnemies)
            {
                Debug.Log("Punched: " + enemy.name);

                P2Health health = enemy.GetComponent<P2Health>();
                if (health != null)
                {
                    health.TakeDamage(punchDamage);
                }
            }
        }
        else
        {
            Debug.Log("Punch missed.");
        }
    }

    void OnDrawGizmosSelected()
    {
        // Visualize punch radius in Scene view
        if (punchOrigin != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(punchOrigin.position, punchRadius);
        }
    }
}
