using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float moveSpeed = 10f;
    public float jumpSpeed = 20f;
    public bool isFly = false;
   // public Camera camera;


    Rigidbody2D rb2;
    Animator anim;
    SpriteRenderer srd;
    

	// Use this for initialization
	void Start () {
        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        srd = GetComponent<SpriteRenderer>();
        Debug.Log(anim.name);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isFly)
        {
            rb2.AddForce(new Vector2(0f, jumpSpeed));
            isFly = true;
            anim.Play("Jump");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2.AddForce(new Vector2(moveSpeed, 0f));
            srd.flipX = true;
            setAnim("Move");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2.AddForce(new Vector2(-moveSpeed, 0f));
            srd.flipX = false;
            setAnim("Move");
        }
        else
        {
            setAnim("Stand");
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Land"))
        {
            isFly = false;
        }
    }

    private void setAnim(string animName)
    {
        if (!isFly)
        {
            anim.Play(animName);
        }
    }
}
