using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour

{
    public int speed = -15;
    public Transform down;
    public Transform up;
// Start is called before the first frame update
    void Start()
{

}

// Update is called once per frame
    void Update()
    {
    transform.Translate(0, speed * Time.deltaTime, 0);

    if (gameObject.transform.position.y > up.transform.position.y)
    {
            SceneManager.LoadScene("ViarWink");

    }
}
}