using System;

public class RedBrock : SwitchableObject
{
	//出現を切り替えられる赤いブロック
	public override void SwitchOn()
	{
		base.gameObject.SetActive(true);
	}

	public override void SwitchOff()
	{
		base.gameObject.SetActive(false);
	}
}
