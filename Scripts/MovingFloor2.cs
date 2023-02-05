using System;
using UnityEngine;

public class MovingFloor2 : SwitchableObject
{
	private void Start()
	{
		this.rb = base.gameObject.GetComponent<Rigidbody2D>();
		if (this.movePoint != null && this.movePoint.Length != 0 && this.rb != null)
		{
			this.rb.position = this.movePoint[0].transform.position;
		}
	}

	private void FixedUpdate()
	{
		if (this.Switchflg)
		{
			this.MoveFloor();
		}
	}

	protected void MoveFloor()
	{
		if (this.movePoint != null && this.movePoint.Length > 1 && this.rb != null)
		{
			if (!this.returnPoint)
			{
				int num = this.nowPoint + 1;
				if (Vector2.Distance(base.transform.position, this.movePoint[num].transform.position) > 0.1f)
				{
					Vector2 position = Vector2.MoveTowards(base.transform.position, this.movePoint[num].transform.position, this.speed * Time.deltaTime);
					this.rb.MovePosition(position);
					return;
				}
				this.rb.MovePosition(this.movePoint[num].transform.position);
				this.nowPoint++;
				if (this.nowPoint + 1 >= this.movePoint.Length)
				{
					this.returnPoint = true;
					return;
				}
			}
			else
			{
				int num2 = this.nowPoint - 1;
				if (Vector2.Distance(base.transform.position, this.movePoint[num2].transform.position) > 0.1f)
				{
					Vector2 position2 = Vector2.MoveTowards(base.transform.position, this.movePoint[num2].transform.position, this.speed * Time.deltaTime);
					this.rb.MovePosition(position2);
					return;
				}
				this.rb.MovePosition(this.movePoint[num2].transform.position);
				this.nowPoint--;
				if (this.nowPoint <= 0)
				{
					this.returnPoint = false;
				}
			}
		}
	}

	protected void StopFloor()
	{
		this.rb.velocity = new Vector2(0f, 0f);
	}

	private Rigidbody2D rb;

	[SerializeField]
	private GameObject[] movePoint;

	[SerializeField]
	private float speed;

	private int nowPoint;

	private bool returnPoint;
}
