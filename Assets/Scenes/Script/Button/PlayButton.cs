using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MouseEvent {

    // Use this for initialization
    public GameObject gameObject;

    Animator anim;
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        anim = gameObject.GetComponent<Animator>();
    }

    protected override void OnMouseEnter()
    {
        base.OnMouseEnter();
        anim.Play("Ready");
    }

    protected override void OnMouseExit()
    {
        base.OnMouseExit();
        anim.Play("Wait");
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void action()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
