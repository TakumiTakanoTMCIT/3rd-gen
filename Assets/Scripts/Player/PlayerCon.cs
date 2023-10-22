using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour
{
    [SerializeField]
    float movingSpeed;   // �͂�ݒ�
    [SerializeField]
    float jumpLvl;      // Set Jump level

    public float MaxSpeed = 3f;
    Vector3 speed;//addforcec�ɒ���������Vector3�ŃX�s�[�h��ݒ肵�܂���

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
        rb = this.GetComponent<Rigidbody2D>();                          // rigidbody2D���擾

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
        
        //velocity����ړ����x���擾���Ĉړ����x��MaxSpeed�ȉ��̏ꍇ�����ړ��L�[�������悤�ɂ��܂����B
        //Debug.Log("PlayerCon��Update�͋@�\���Ă��܂�");
            if (Input.GetKey(KeyCode.A))
            {
            //Debug.Log("A�L�[��������܂���");
                if (veloX >= -MaxSpeed)
                {
                    sp.flipX = false;
                    rb.AddForce(-speed);
                //Debug.Log("���ɗ͂�������Ă��܂�");
                anim.SetBool("run", true);
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (veloX <= MaxSpeed)
                {
                sp.flipX = true;
                rb.AddForce(speed);

                //Debug.Log("�E�ɗ͂�������Ă��܂�");
                anim.SetBool("run", true);
                }
            }

            if(veloX < 2 && veloX > -2)
            {
                anim.SetBool("run", false);
                //Debug.Log("�͂��قƂ�ǉ�����Ă��Ȃ�");
            }

            if(veloY < -1)      //just falling now
            {
                anim.SetBool("isFall", true);
                nowjump = true;
                //Debug.Log("isFall��true�ɂ��܂���");
            }

            if(veloY > 0.1) // just jumping now
            {
                nowjump = true;
            }

        //Debug.Log(veloX); //�������Console�ɃX�s�[�h��\�����ăf�o�b�O���܂����i�܂��l�܂�����g����������Ȃ��j


        velo = rb.velocity;
        veloX = velo.x;      //velocity��X���W���擾�B��������邱�Ƃɂ��A�X�s�[�h���擾�ł���
        veloY = velo.y;

        //���Ȃ��veloX�̐錾��Update�̒��ōs���̂��Ƃ����ƁA�펞���̕ϐ����X�V����������


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(rb, jumpLvl);//�W�����v������
            anim.SetBool("isJump", true);
        }

        if(TF.position.y <= -13)
        {
            Debug.Log("�ޗ��ɗ����܂���");
            Death();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grounds") || collision.gameObject.CompareTag("Object"))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isFall", false);
            //Debug.Log("�n�ʂɕt���܂���");
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
            //Debug.Log("�n�ʂɕt���܂���");
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            /*Death();
            Debug.Log("���ɂ܂���");
        }*/

        if (collision.gameObject.CompareTag("DamageGround"))
        {
            Debug.Log("�_���[�W���ɐG��܂���");
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Goal"))
        {
            Debug.Log("�S�[�����܂���");
            MoveScene.instance.CleardGame();
        }

        /*if(col.gameObject.CompareTag("ELeft"))//            �G�ɐG�ꂽ��....
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
        // ���݂�Scene���擾
        //Scene loadScene = SceneManager.GetActiveScene();
        // ���݂̃V�[�����ēǂݍ��݂���
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