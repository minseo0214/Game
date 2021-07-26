using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float m_fSpeed;
    public float m_fJumpForce;
    public bool m_bJump = false;

    public GameObject PlayerBullet;
    public GameObject BulletPosition;

    public void OnCollisionEnter2D(Collision2D collision)
    {//캐릭터가 땅에 닿았을 때 false
        m_bJump = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fMoveDist = Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            transform.position += Vector3.right * fMoveDist;
            Debug.Log("GetKey(rightarrow");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * fMoveDist;
            Debug.Log("GetKey(uparrow");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * fMoveDist;
            Debug.Log("GetKey(uparrow");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            transform.position += Vector3.left * fMoveDist;
            Debug.Log("GetKey(leftarrow");
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (m_bJump != true)
            {
                Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
                rigidbody2D.AddForce(Vector3.up * m_fJumpForce);

                m_bJump = true;
            }
        }

        //발사
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = (GameObject)Instantiate(PlayerBullet);
            bullet.transform.position = BulletPosition.transform.position;
        }
        
        

    }

    //Eat cherry
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "cherry")
        {
            blockstatus cherry = other.gameObject.GetComponent<blockstatus>();
            ScoreManagement.SetScore((int)cherry.value); //50점을 추가하기
            Destroy(other.gameObject);
        }

    }
}
