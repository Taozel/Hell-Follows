using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateController : MonoBehaviour
{
    private float UltimateTime = 3;
    private float ReloadTime = 25;
    private bool _canHit = true;
    private bool _x = false;
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

        if (_x == true)
        {
            coll.enabled = false;
        }
        if (Input.GetKey(KeyCode.G) && _canHit == true)
        {
            StartCoroutine(UltCast());            
        }

        IEnumerator UltCast()
        {
            _canHit = false;
            yield return new WaitForSeconds(UltimateTime);
            _x = true;
            StartCoroutine(UltCastt());
        }

        IEnumerator UltCastt()
        {
            yield return new WaitForSeconds(ReloadTime);
            _canHit = true;
            _x = false;
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
