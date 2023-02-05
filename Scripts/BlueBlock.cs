using System;

public class BlueBlock : SwitchableObject
{
    //出現の切り替えが出来る
	public override void SwitchOn()
	{
		base.gameObject.SetActive(false);
	}

	public override void SwitchOff()
	{
		base.gameObject.SetActive(true);
	}
}