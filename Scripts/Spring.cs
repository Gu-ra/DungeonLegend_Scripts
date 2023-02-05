using System;
using UnityEngine;

public class Spring : MonoBehaviour
{
	//プレイヤーが乗ると大きく跳ねるバネ
	private void Start()
	{
		this.anim = base.GetComponent<Animator>();
		this.audioSource = base.GetComponent<AudioSource>();
	}

	private void Update()
	{
		this.onSpring = Physics2D.Linecast(base.transform.position, base.transform.position + base.transform.up * 1f, this.Layer);
		this.SpringJump();
	}

	private void SpringJump()
	{
		if (this.onSpring)
		{
			this.audioSource.Play();
			this.anim.SetTrigger("Spring");
			this.player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, this.JumpPower);
		}
	}

	private bool onSpring;

	public LayerMask Layer;

	[SerializeField]
	private GameObject player;

	private Animator anim;

	[SerializeField]
	private float JumpPower = 100f;

	private AudioSource audioSource;
}
