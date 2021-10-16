using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerIT : MonoBehaviour
{
    public bool floor;
    public Vector2 jumpHeight;
    private RaycastHit2D hit;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( floor == true)
        {

            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            floor = false;
        }

        float x = Input.GetAxisRaw("Horizontal");
        Vector3 moveDelta = new Vector3(x, 0, 0);
        if (hit.collider == null)
        {
            transform.Translate(4 * moveDelta.x * Time.deltaTime, 0, 0);
        }

        if (moveDelta.y != 0 || moveDelta.x != 0)
        {
            if (moveDelta.y > 0)
            {
                anim.SetInteger("direction", 7);
            }
            else if (moveDelta.y < 0)
            {
                anim.SetInteger("direction", 5);
            }
            else if (moveDelta.x > 0)
            {
                anim.SetInteger("direction", 6);
            }
            else if (moveDelta.x < 0)
            {
                anim.SetInteger("direction", 8);
            }
        } else
        {
            anim.SetInteger("direction", 0);
        }
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("floor") && floor == false)
        {
            floor = true;
        }
        if (collision.gameObject.tag.Equals("Enemy") )
        {
            SceneManager.LoadScene(17);

        }

    }

   
}

/*if (moveDelta.y != 0 || moveDelta.x != 0)
        {
            if (moveDelta.y > 0)
            {
                anim.SetInteger("direction", 1);
            }
            else if (moveDelta.y < 0)
            {
                anim.SetInteger("direction", 3);
            }
            else if (moveDelta.x > 0)
            {
                anim.SetInteger("direction", 2);
            }
            else if (moveDelta.x < 0)
            {
                anim.SetInteger("direction", 4);
            }
        } else
        {
            anim.SetInteger("direction", 0);
        }
 */
