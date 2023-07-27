using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public MenuManager menu;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnim()
    {
        anim.SetBool("Play",true);
    }
    public void Play()
    {
        menu.Play();
    }
    private void OnMouseEnter()
    {
        
    }
}
