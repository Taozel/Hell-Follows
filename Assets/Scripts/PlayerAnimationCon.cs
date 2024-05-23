using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationCon : MonoBehaviour
{
    private float relodeTime = 1;
    private float relodeTimeUlt = 25;
    private bool _canHit = true;
    private bool _canHitUlt = true;
    public Animator anim;
    float t;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0) && _canHit == true)
        {
            anim.SetTrigger("Attak");
            StartCoroutine(Reload());
        }

        if (Input.GetKey(KeyCode.G) && _canHitUlt == true)
        {
            anim.SetTrigger("Ultimate");
            StartCoroutine(ReloadUlt());
        }
    }

    IEnumerator Reload()
    {
        _canHit = false;
        yield return new WaitForSeconds(relodeTime);
        _canHit = true;
    }

    IEnumerator ReloadUlt()
    {
        _canHitUlt = false;
        yield return new WaitForSeconds(relodeTimeUlt);
        _canHitUlt = true;
    }

    public void Run(float speed,bool status)
   {
        anim.SetBool("Run", status);
        if (status == true)
        {
            if (speed>3)
            {
                t += Time.deltaTime;
                if (t >= 2) { t = 2; }
                anim.SetFloat("Speed", t);
            }
            else
            {
                t -= Time.deltaTime;
                if (t <= 0) { t = 0; }
                anim.SetFloat("Speed", t);
            }
        }
        else
        {
            t = 0;
        }
   }
}
