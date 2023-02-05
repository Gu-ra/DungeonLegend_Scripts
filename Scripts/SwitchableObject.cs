using System;
using UnityEngine;

public class SwitchableObject : MonoBehaviour, ISwitching
{
	//スイッチの役割をもつオブジェクト
	private void Start()
	{
		this.Switchflg = false;
	}

	public virtual void SwitchOn()
	{
		if (!this.Switchflg)
		{
			this.Switchflg = true;
		}
	}

	public virtual void SwitchOff()
	{
		if (this.Switchflg)
		{
			this.Switchflg = false;
		}
	}

	[SerializeField]
	protected bool Switchflg;
}
