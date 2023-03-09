using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Animator logoAnim;

    private void Start()
    {
        StartCoroutine(LogoAnimation());
    }

    private IEnumerator LogoAnimation()
    {
        yield return new WaitForSeconds(3f);
        logoAnim.SetBool("HasStarted", true);
    }
}
