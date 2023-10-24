using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour
{
    [SerializeField]
    float movingSpeed;   // ????????
    [SerializeField]
    float jumpLvl;      // Set Jump level

    public float MaxSpeed = 3f;
    Vector3 speed;//addforcec????????????Vector3???X?s?[?h??????????????

    SpriteRenderer sp;
    Rigidbody2D rb;
    GameObject Player;
    Transform TF;
    public bool nowjump;
    float veloX, veloY;

    GameObject Lefter, Righter;

    public CoinCon coinCon;

    private Animator anim = null;

    Vector2 velo;

    public string globalcol;

    Up Eupcon;

    public EnemyCon econ;

    public GoalCon gcon;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();                          // rigidbody2D??????

        sp = this.GetComponent<SpriteRenderer>();

        Player = GameObject.Find("Player");
        TF = Player.transform;

        speed = new Vector3(movingSpeed, 0, 0);

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.A))
            {
                if(veloX >= -MaxSpeed)
                {
                    //Debug.Log("A?L?[??????????????");
                    sp.flipX = false;
                    rb.AddForce(-speed);
                    //Debug.Log("??????????????????????");
                    anim.SetBool("run", true);
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (veloX <= MaxSpeed)
                {
                    //Debug.Log("Pushed D key");
                    sp.flipX = true;
                    rb.AddForce(speed);
                    anim.SetBool("run", true);
                }
            }

        if (Mathf.Abs(veloX) < 2)
        {
            anim.SetBool("run", false);
            //Debug.Log("??????????????????????????");
        }

        if (veloY < -1)      //just falling now
        {
            anim.SetBool("isFall", true);
            nowjump = true;
            //Debug.Log("isFall??true??????????");
        }

        if (veloY > 0.1) // just jumping now
        {
            nowjump = true;
        }

        //Debug.Log(veloX); //????????Console???X?s?[?h???\???????f?o?b?O?????????i?????l?????????g???????????????j


        velo = rb.velocity;
        veloX = velo.x;      //velocity??X???W???????B?????????????????????A?X?s?[?h????????????
        veloY = velo.y;

        //????????veloX????????Update???????s???????????????A???????????????X?V??????????


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(rb, jumpLvl);//?W?????v??????
            anim.SetBool("isJump", true);
        }

        if (TF.position.y <= -13)
        {
            Debug.Log("player fall into the hell ");
            Death();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grounds") || collision.gameObject.CompareTag("Object"))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isFall", false);
            //Debug.Log("player is on ground");
            veloY = 0;
            velo.y = veloY;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DamageGround"))
        {
            Debug.Log("player stamp the damageGround ");
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        int goal = 0;

        if (goal == 0)
        {
            if (col.gameObject.CompareTag("Goal"))
            {
                Debug.Log("Player Goal!!!");
                gcon.Goal();
            }
            goal = 1;
        }
    }

    void Jump(Rigidbody2D rb, float lvl)
    {
        if (nowjump == false)
        {
            nowjump = true;

            rb.velocity = new Vector2(rb.velocity.x, 0f);                   // Init Y velocity
            rb.AddForce(Vector2.up * lvl, ForceMode2D.Impulse);             // Add Up force
        }
    }

    public void Death()
    {
        SceneManager.LoadScene(GlobalVariables.NowScene);
    }

    public void OnGround(Collider2D col)
    {
        //Debug.Log(globalcol);
        globalcol = col.gameObject.name;

        nowjump = false;
        anim.SetBool("isJump", false);
        anim.SetBool("isFall", false);
        //Debug.Log("foot on somehting");

        if (col.gameObject.CompareTag("Grounds") || col.gameObject.CompareTag("Object"))
        {
            //Debug.Log("Ground");
            //want to do above code
        }
        else if (col.gameObject.CompareTag("EUp"))
        {
            GameObject parenter = col.transform.parent.gameObject;//get parent of up

            EnemyCon econ = parenter.GetComponent(typeof(EnemyCon)) as EnemyCon; // get component of enemycon 

            econ.Death();//do KANSUU(death()) 

            //Debug.Log(parenter + "  " + col.gameObject);

            nowjump = true;

            rb.velocity = new Vector2(rb.velocity.x, 0f);                   // Init Y velocity
            rb.AddForce(Vector2.up * jumpLvl, ForceMode2D.Impulse);             // Add Up force
        }
        else if (col.gameObject.CompareTag("JumpingEUp"))
        {
            GameObject parenter = col.transform.parent.gameObject;//get parent of up
            JumpingEnemyCon econ = parenter.GetComponent(typeof(JumpingEnemyCon)) as JumpingEnemyCon; // get component of enemycon 

            econ.Death();//do KANSUU(death()) 

            nowjump = true;

            rb.velocity = new Vector2(rb.velocity.x, 0f);                   // Init Y velocity
            rb.AddForce(Vector2.up * jumpLvl, ForceMode2D.Impulse);             // Add Up force
        }
    }
}