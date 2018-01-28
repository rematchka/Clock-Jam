using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    private Animator playerAnimation;
    private Rigidbody2D rb;
    public Transform groundCheckPoint;
    private float groundCheckWidth = 0.5f;
    public LayerMask groundLayer;
    private bool isRunning = false, isGrounded = false, toRight = true;
    public bool isShooting = false;
     float force = 60;
    public GameObject movingScene;
	public GameObject m_shotPrefab;
	public Transform m_muzzle;
	public GameObject gameobject;
	public int health=100;
	float shootingCounter = 0.0f;
	bool once = true;
	public Transform MosterAttackCheck;
	public float mostercheckwid=0.5f;
	bool isdead,isattacking;
	public LayerMask monsterlayer;



    // Use this for initialization
    void Start () {
        playerAnimation = gameobject.GetComponent<Animator>();
		rb = gameobject.GetComponent<Rigidbody2D>();
    }

    bool IsGrounded() {
        return Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckWidth, groundLayer);
    }


    bool IsAttacked() {
		return Physics2D.OverlapCircle(MosterAttackCheck.position, mostercheckwid, monsterlayer);
    }

    void callscene ()
	{
		SceneManager.LoadScene (2);

	}

// Update is called once per frame
void Update ()
	{

		isGrounded = IsGrounded ();
		isattacking = IsAttacked ();
		if (isattacking) {
			health -= 1;
			Debug.Log(health);
			if (health <= 0 && !isdead) {
				isdead = true;
				playerAnimation.SetBool ("isDead", isdead);
				Invoke ("callscene", 2f);
			}
		}
		if (isdead) {
		return ;
		}
		if (shootingCounter > 0.0f) {
			shootingCounter += Time.deltaTime;
			if (shootingCounter >= 0.5f && once) {
				once = false;
			}
		}
		if (shootingCounter >= 2.0f) {
			isShooting = false;
			shootingCounter = 0;
			once = true;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			isRunning = true;
			rb.AddForce (new Vector2 (100, 0));
			if (!toRight) {
				transform.rotation = new Quaternion (0, 0, 0, 1);
				toRight = true;
			}
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			isRunning = true;
			rb.AddForce (new Vector2 (-100, 0));
			if (toRight) {
				transform.rotation = new Quaternion (0, 180, 0, 1);
				toRight = false;
			}
		} else {
			isRunning = false;
		}
		if (Input.GetKey (KeyCode.Space) && isGrounded) {
			//transform.position += new Vector3 (0, force, 0) * Time.deltaTime;
			rb.AddForce(transform.up*force);
		}  
		 
		if (Input.GetKeyDown (KeyCode.L)) {
			isShooting = true;
			shootingCounter = 1.0f;
			GameObject go = GameObject.Instantiate (m_shotPrefab, m_muzzle.position, m_muzzle.rotation) as GameObject;
			GameObject.Destroy (go, 3f);
		}
		playerAnimation.SetBool ("isRunning", isRunning);
		playerAnimation.SetBool ("isJumping", !isGrounded);
		playerAnimation.SetBool ("isShooting", isShooting);

		if (health <= 0) {
			Destroy (gameObject);
			SceneManager.LoadScene (2);
		}
		
    }


	

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Zombie") {
			health -= 5;

		} 
	}
}
