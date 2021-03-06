using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2D : MonoBehaviour
{
    Animator jumpAnim;

    public bool jump;

    [SerializeField] private float m_JumpForce = 400f;							// Amount of force added when the player jumps.
	[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;	// How much to smooth out the movement
	[SerializeField] private bool m_AirControl = false;							// Whether or not a player can steer while jumping;
	[SerializeField] private LayerMask m_WhatIsGround;							// A mask determining what is ground to the character
	[SerializeField] private Transform m_GroundCheck;							// A position marking where to check if the player is grounded.

	const float k_GroundedRadius = .2f;        // Radius of the overlap circle to determine if grounded
	private bool m_Grounded;                   // Whether or not the player is grounded.
	private Rigidbody2D m_Rigidbody2D;
	private Vector3 m_Velocity = Vector3.zero;

    [Space]
    public float realVelocity;

	private void Awake()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
        jumpAnim = GetComponent<Animator>();

        jump = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            PlayerJump();
        }
        else
        {
            Move();
        }
    }

    private void FixedUpdate()
	{
		m_Grounded = false;

		Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				m_Grounded = true;
			}
		}
	}


	public void Move()
	{
        Debug.Log("Are you grounded:" + m_Grounded);
        //only control the player if grounded or airControl is turned on
        if (m_Grounded || m_AirControl)
		{

			// Move the character by finding the target velocity
			Vector3 targetVelocity = new Vector2(realVelocity, m_Rigidbody2D.velocity.y);
			// And then smoothing it out and applying it to the character
			m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

		}

		// If the player should jump...
		if (m_Grounded && jump)
		{
            jumpAnim.SetTrigger("Jump");
			// Add a vertical force to the player.
			m_Grounded = false;
			m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
            jump = false;

        }
	}

    public void PlayerJump ()
    {
        jump = true;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "End")
            SceneManager.LoadScene("Level_Selector");
    }
}
