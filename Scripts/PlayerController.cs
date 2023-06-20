using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//プレイヤーコントローラー
	protected void Grounded()
	{
		this.isGrounded = Physics2D.Linecast(base.transform.position, base.transform.position - base.transform.up * 1f, this.groundLayer);
	}

    	//以下キー入力を受け取るための変数
    	//歩いているか
	protected float x_move;

	//ジャンプしたか
	protected bool jump;

	//撃ったか
	protected bool shot;

	//爆弾を出したか
	protected bool bomber;

	//風を出しているか
	protected bool magic;

	//接地しているか
	protected bool isGrounded;

	public LayerMask groundLayer;

	protected Animator anim;

	protected Rigidbody2D rb;

	protected Vector3 scale;
}
