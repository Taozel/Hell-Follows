using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateController : MonoBehaviour
{
    private float relodeTime = 10;
    private bool _canHit = true;
    public MeshCollider coll;
    public float damage = 100;
    public bool isAttak;

    private void Start()
    {
        coll.enabled = false;
    }

    private void Update()
    {
        if (_canHit == false)
        {
            coll.enabled = true;
        }

        if (_canHit == true)
        {
            coll.enabled = false;

        }
        if (Input.GetKey(KeyCode.G) && _canHit == true)
        {
            StartCoroutine(Reload());
        }

        IEnumerator Reload()
        {
            _canHit = false;
            yield return new WaitForSeconds(relodeTime);
            _canHit = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
    }

    private void DamageEnemy(Collision collision)
    {
        if (_canHit == false)
        {
            var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.DealDamage(damage);
            }
        }
    }
}
