using System;
using UnityEngine;

public class Button : Switch
{
    //赤いボタン、スイッチの役割
	private void Update()
	{
		this.pushed = Physics2D.Linecast(base.transform.position, base.transform.position + base.transform.up * 0.1f, this.Layer);
		this.SwitchChange();
	}

	public override void AddDamage(float damage)
	{
	}
    //スイッチと連動してオブジェクトの出現を切り替えられる
	protected override void SwitchChange()
	{
		GameObject[] switchableObject;
		if (this.pushed)
		{
			this.spriteRenderer.sprite = this.sprite_on;
			switchableObject = this.SwitchableObject;
			for (int i = 0; i < switchableObject.Length; i++)
			{
				ISwitching component = switchableObject[i].gameObject.GetComponent<ISwitching>();
				if (component != null)
				{
					component.SwitchOn();
				}
			}
			return;
		}
		this.spriteRenderer.sprite = this.sprite_off;
		switchableObject = this.SwitchableObject;
		for (int i = 0; i < switchableObject.Length; i++)
		{
			ISwitching component2 = switchableObject[i].gameObject.GetComponent<ISwitching>();
			if (component2 != null)
			{
				component2.SwitchOff();
			}
		}
	}

	[SerializeField]
	private LayerMask Layer;

	private bool pushed;
}
