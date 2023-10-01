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

    SpriteRenderer sp;
    Rigidbody2D rb;
    GameObject Player;
    Transform TF;
    bool isJumping;
    float veloX;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();                          // rigidbody2Dを取得
        isJumping = false;

        sp = this.GetComponent<SpriteRenderer>();

        Player = GameObject.Find("Player");
        TF = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {      //velocityから移動速度を取得して移動速度がMaxSpeed以下の場合だけ移動キーが効くようにしました。
        
            if (Input.GetKey(KeyCode.A))
            {
                if (veloX >= -MaxSpeed)
                {
                    TF.position += new Vector3(-movingSpeed, 0 , 0);

                    sp.flipX = true;
                }
                
                
                //rb.AddForce(Vector2.left * movingSpeed, ForceMode2D.Force); // 力を加える
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (veloX <= MaxSpeed)
                {

                sp.flipX = false;

                TF.position += new Vector3(movingSpeed, 0, 0);

                //rb.AddForce(Vector2.right * movingSpeed, ForceMode2D.Force); // 力を加える
                }
            }

        //Debug.Log(veloX); //←これでConsoleにスピードを表示してデバッグしました（また詰まったら使うかもしれない）


        veloX = rb.velocity.x;      //velocityのX座標を取得。これをすることにより、スピードを取得できる

        //↑なんでveloXの宣言をUpdateの中で行うのかというと、常時この変数を更新したいから


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(rb, jumpLvl);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grounds") || collision.gameObject.CompareTag("Object"))
        {
            isJumping = false;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            Death();
            Debug.Log("死にました");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Goal"))
        {
            Debug.Log("ゴールしました");
            MoveScene.instance.CleardGame();
        }

        if(col.gameObject.CompareTag("DamageGround"))
        {
            Debug.Log("ダメージ床に触れました");
            Death();
        }
    }

    void Jump(Rigidbody2D rb, float lvl)
    {
        if (!isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);                   // Init Y velocity
            rb.AddForce(Vector2.up * lvl, ForceMode2D.Impulse);             // Add Up force
            isJumping = true;
        }
    }

    public void Death()
    {
        // 現在のSceneを取得
        Scene loadScene = SceneManager.GetActiveScene();
        // 現在のシーンを再読み込みする
        SceneManager.LoadScene(loadScene.name);
    }
}