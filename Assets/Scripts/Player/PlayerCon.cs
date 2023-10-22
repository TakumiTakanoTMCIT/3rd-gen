using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour
{
    [SerializeField]
    float movingSpeed;   // 力を設定
    [SerializeField]
    float jumpLvl;      // Set Jump level

    public float MaxSpeed = 3f;
    Vector3 speed;//addforcecに直したためVector3でスピードを設定しました

    SpriteRenderer sp;
    Rigidbody2D rb;
    GameObject Player;
    Transform TF;
    public bool nowjump;
    float veloX , veloY;

    GameObject Lefter , Righter;

    public CoinCon coinCon;

    private Animator anim = null;

    Vector2 velo;

    public string globalcol;

    Up Eupcon;

    public EnemyCon econ;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();                          // rigidbody2Dを取得

        sp = this.GetComponent<SpriteRenderer>();

        Player = GameObject.Find("Player");
        TF = Player.transform;

        speed = new Vector3(movingSpeed, 0, 0);

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isJumping);
        
        //velocityから移動速度を取得して移動速度がMaxSpeed以下の場合だけ移動キーが効くようにしました。
        //Debug.Log("PlayerConのUpdateは機能しています");
            if (Input.GetKey(KeyCode.A))
            {
            //Debug.Log("Aキーが押されました");
                if (veloX >= -MaxSpeed)
                {
                    sp.flipX = false;
                    rb.AddForce(-speed);
                //Debug.Log("左に力が加わっています");
                anim.SetBool("run", true);
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (veloX <= MaxSpeed)
                {
                sp.flipX = true;
                rb.AddForce(speed);

                //Debug.Log("右に力が加わっています");
                anim.SetBool("run", true);
                }
            }

            if(veloX < 2 && veloX > -2)
            {
                anim.SetBool("run", false);
                //Debug.Log("力がほとんど加わっていない");
            }

            if(veloY < -1)      //just falling now
            {
                anim.SetBool("isFall", true);
                nowjump = true;
                //Debug.Log("isFallをtrueにしました");
            }

            if(veloY > 0.1) // just jumping now
            {
                nowjump = true;
            }

        //Debug.Log(veloX); //←これでConsoleにスピードを表示してデバッグしました（また詰まったら使うかもしれない）


        velo = rb.velocity;
        veloX = velo.x;      //velocityのX座標を取得。これをすることにより、スピードを取得できる
        veloY = velo.y;

        //↑なんでveloXの宣言をUpdateの中で行うのかというと、常時この変数を更新したいから


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(rb, jumpLvl);//ジャンプさせる
            anim.SetBool("isJump", true);
        }

        if(TF.position.y <= -13)
        {
            Debug.Log("奈落に落ちました");
            Death();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grounds") || collision.gameObject.CompareTag("Object"))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isFall", false);
            //Debug.Log("地面に付きました");
            veloY = 0;
            velo.y = veloY;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.CompareTag("Grounds") || collision.gameObject.CompareTag("Object"))
        {
            isJumping = false;

            anim.SetBool("isJump", false);
            anim.SetBool("isFall", false);
            //Debug.Log("地面に付きました");
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            /*Death();
            Debug.Log("死にました");
        }*/

        if (collision.gameObject.CompareTag("DamageGround"))
        {
            Debug.Log("ダメージ床に触れました");
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Goal"))
        {
            Debug.Log("ゴールしました");
            MoveScene.instance.CleardGame();
        }

        /*if(col.gameObject.CompareTag("ELeft"))//            敵に触れたら....
        {
            Lefter = GameObject.Find("Enemy");
            Lefter.GetComponent<EnemyCon>().OnLeft();
        }

        if(col.gameObject.CompareTag("ERight"))
        {
            Righter = GameObject.Find("Right");
            Righter.GetComponent<EnemyCon>().OnRight();
        }*/
    }

    void Jump(Rigidbody2D rb, float lvl)
    {
        if(nowjump == false)
        {
            nowjump = true;

            rb.velocity = new Vector2(rb.velocity.x, 0f);                   // Init Y velocity
            rb.AddForce(Vector2.up * lvl, ForceMode2D.Impulse);             // Add Up force
        }
    }

    public void Death()
    {
        // 現在のSceneを取得
        //Scene loadScene = SceneManager.GetActiveScene();
        // 現在のシーンを再読み込みする
        SceneManager.LoadScene(GlobalVariables.NowScene);
    }

    public void OnGround(Collider2D col)
    {
        Debug.Log(globalcol);
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
        else if(col.gameObject.CompareTag("EUp"))
        {
            GameObject parenter = col.transform.parent.gameObject;//get parent of up

            EnemyCon econ = parenter.GetComponent(typeof(EnemyCon)) as EnemyCon; // get component of enemycon 

            econ.Death();//do KANSUU(death()) 

            //Debug.Log(parenter + "  " + col.gameObject);

            nowjump = true;

            rb.velocity = new Vector2(rb.velocity.x, 0f);                   // Init Y velocity
            rb.AddForce(Vector2.up * jumpLvl, ForceMode2D.Impulse);             // Add Up force
        }
    }
}