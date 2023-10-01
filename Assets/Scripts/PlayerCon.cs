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

    SpriteRenderer sp;
    Rigidbody2D rb;
    GameObject Player;
    Transform TF;
    bool isJumping;
    float veloX;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();                          // rigidbody2D���擾
        isJumping = false;

        sp = this.GetComponent<SpriteRenderer>();

        Player = GameObject.Find("Player");
        TF = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {      //velocity����ړ����x���擾���Ĉړ����x��MaxSpeed�ȉ��̏ꍇ�����ړ��L�[�������悤�ɂ��܂����B
        
            if (Input.GetKey(KeyCode.A))
            {
                if (veloX >= -MaxSpeed)
                {
                    TF.position += new Vector3(-movingSpeed, 0 , 0);

                    sp.flipX = true;
                }
                
                
                //rb.AddForce(Vector2.left * movingSpeed, ForceMode2D.Force); // �͂�������
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (veloX <= MaxSpeed)
                {

                sp.flipX = false;

                TF.position += new Vector3(movingSpeed, 0, 0);

                //rb.AddForce(Vector2.right * movingSpeed, ForceMode2D.Force); // �͂�������
                }
            }

        //Debug.Log(veloX); //�������Console�ɃX�s�[�h��\�����ăf�o�b�O���܂����i�܂��l�܂�����g����������Ȃ��j


        veloX = rb.velocity.x;      //velocity��X���W���擾�B��������邱�Ƃɂ��A�X�s�[�h���擾�ł���

        //���Ȃ��veloX�̐錾��Update�̒��ōs���̂��Ƃ����ƁA�펞���̕ϐ����X�V����������


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
            Debug.Log("���ɂ܂���");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Goal"))
        {
            Debug.Log("�S�[�����܂���");
            MoveScene.instance.CleardGame();
        }

        if(col.gameObject.CompareTag("DamageGround"))
        {
            Debug.Log("�_���[�W���ɐG��܂���");
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
        // ���݂�Scene���擾
        Scene loadScene = SceneManager.GetActiveScene();
        // ���݂̃V�[�����ēǂݍ��݂���
        SceneManager.LoadScene(loadScene.name);
    }
}