using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Animator logoAnim;
    [SerializeField] private Button[] buttons;
    [SerializeField] private GameObject[] imageObjects;

    private void Start()
    {
        StartCoroutine(LogoAnimation());
    }

    private IEnumerator LogoAnimation()
    {
        yield return new WaitForSeconds(3f);
        logoAnim.SetBool("HasStarted", true);
        yield return new WaitUntil(() => logoAnim.GetCurrentAnimatorStateInfo(0).IsName("End") == true);
        yield return new WaitForSeconds(1f);
        StartCoroutine(ButtonsAppear());
    }

    private IEnumerator ButtonsAppear()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = true;
            yield return new WaitForSeconds(1f);
        }
        imageObjects[0].gameObject.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        imageObjects[1].gameObject.SetActive(true);
    }
}
