using System;
using UnityEngine;

public class PlayerMove : PlayerController
{
	//プレイヤーの動き
	private void Start()
	{
		this.anim = base.GetComponent<Animator>();
		this.rb = base.GetComponent<Rigidbody2D>();
		this.audioSource = base.GetComponent<AudioSource>();
	}

	private void Update()
	{
		this.x_move = Input.GetAxisRaw("Horizontal");
		this.jump = Input.GetKeyDown("joystick button 1");
		this.Turn();
		this.shot = Input.GetKeyDown("joystick button 5");
		this.bomber = Input.GetKeyDown("joystick button 0");
		this.magic = Input.GetKey("joystick button 3");
		this.Anim();
		base.Grounded();
	}

	private void FixedUpdate()
	{
		if (!this.magic)
		{
			if (this.isGrounded && this.jump)
			{
				this.Jump();
			}
			if (this.shot)
			{
				this.Shot();
			}
			this.Walk();
			if (this.bomber)
			{
				this.BombInstantiate();
			}
		}
		this.DashAnim();
		this.Attacking();
	}

	//歩く
	private void Walk()
	{
		if (Mathf.Abs(this.rb.velocity.x) < this.runThdirectionhold)
		{
			this.rb.AddForce(base.transform.right * this.x_move * this.runForce);
			return;
		}
		base.transform.position += new Vector3(this.runSpeed * Time.deltaTime * this.x_move, 0f, 0f);
	}

	//向きを変える
	private void Turn()
	{
		this.scale = base.transform.localScale;
		if (this.x_move > 0f)
		{
			this.scale.x = -0.5f;
		}
		else if (this.x_move < 0f)
		{
			this.scale.x = 0.5f;
		}
		base.transform.localScale = this.scale;
	}

	//ジャンプ
	private void Jump()
	{
		this.anim.SetTrigger("Jump");
		this.rb.AddForce(Vector2.up * this.jumpforce);
	}

	//ダッシュアニメーション
	private void DashAnim()
	{
		if (this.x_move != 0f)
		{
			this.anim.SetFloat("Speed", 1f);
			return;
		}
		this.anim.SetFloat("Speed", 0f);
	}

	//アニメーション
	private void Anim()
	{
		float y = this.rb.velocity.y;
		this.anim.SetFloat("velY", y);
		this.anim.SetBool("isGrounded", this.isGrounded);
	}

	//ナイフ投げ
	private void Shot()
	{
		this.audioSource.PlayOneShot(this.SEs[0]);
		Vector2 v = new Vector2(base.transform.position.x + 10f, base.transform.position.y + 5f);
		if (base.transform.localScale.x < 0f)
		{
			Object.Instantiate<GameObject>(this.knifeR, v, base.transform.rotation);
			return;
		}
		if (base.transform.localScale.x > 0f)
		{
			v = new Vector2(base.transform.position.x - 10f, base.transform.position.y + 5f);
			Object.Instantiate<GameObject>(this.knifeL, v, base.transform.rotation);
		}
	}

	//ボム生成
	private void BombInstantiate()
	{
		if (GameObject.FindGameObjectsWithTag("Bomb").Length < 1)
		{
			Vector2 v = new Vector2(this.dall.transform.position.x, this.dall.transform.position.y - 7f);
			Object.Instantiate<GameObject>(this.Bomb, v, this.dall.transform.rotation);
		}
	}

	//風を出す
	private void Attacking()
	{
		this.anim.SetBool("Attack", this.magic);
		if (this.magic)
		{
			this.Wind.SetActive(true);
			if (base.transform.localScale.x < 0f)
			{
				this.dall.transform.position = new Vector2(base.transform.position.x + 5f, base.transform.position.y + 5f);
				return;
			}
			if (base.transform.localScale.x > 0f)
			{
				this.dall.transform.position = new Vector2(base.transform.position.x - 5f, base.transform.position.y + 5f);
				return;
			}
		}
		else
		{
			this.Wind.SetActive(false);
			if (base.transform.localScale.x < 0f)
			{
				this.dall.transform.position = new Vector2(base.transform.position.x - 5f, base.transform.position.y + 12f);
				return;
			}
			if (base.transform.localScale.x > 0f)
			{
				this.dall.transform.position = new Vector2(base.transform.position.x + 5f, base.transform.position.y + 12f);
			}
		}
	}

	// 加速度
	[SerializeField]
	private float runForce = 150f;

	//速度
	[SerializeField]
	private float runSpeed = 50f;

	[SerializeField]
	private float runThdirectionhold = 220f;

	//ジャンプ力
	[SerializeField]
	private float jumpforce;

	//ナイフ
	[SerializeField]
	private GameObject knifeR;

	[SerializeField]
	private GameObject knifeL;

	//ボム
	[SerializeField]
	private GameObject Bomb;

	//キャラの近くにある人形
	[SerializeField]
	public GameObject dall;

	//風
	[SerializeField]
	private GameObject Wind;

	//音
	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioClip[] SEs;
}
