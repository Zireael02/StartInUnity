using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewComponent : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    public int speed = 5;
    public int speedRotation = 3;
    public Animator animator;
    private int _state;

    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)this.gameObject;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A))
            {
                _state = 2;
                player.transform.Rotate(Vector3.down * speedRotation);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _state = 3;
                player.transform.Rotate(Vector3.up * speedRotation);
            }
            else
            {
                _state = 1;
                player.transform.position += player.transform.forward * speed * Time.deltaTime;
            }
               
        }

        else if (Input.GetKey(KeyCode.S))
        {
            _state = 1;
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            _state = 2;
            player.transform.Rotate(Vector3.down * speedRotation);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            _state = 3;
            player.transform.Rotate(Vector3.up * speedRotation);
        }
        else
        {
            _state = 0;
        }
        animator.SetInteger("state", _state);
    }
}
