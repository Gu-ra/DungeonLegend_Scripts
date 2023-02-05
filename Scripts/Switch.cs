using System;
using UnityEngine;

public class Switch : MonoBehaviour, IDamagable, ISwitching
{
	//切り替え出来るクリスタルスイッチ
	protected void Start()
	{
		this.spriteRenderer = base.gameObject.GetComponent<SpriteRenderer>();
		this.audioSource = base.GetComponent<AudioSource>();
		this.spriteRenderer.sprite = this.sprite_off;
		GameObject[] switchableObject = this.SwitchableObject;
		for (int i = 0; i < switchableObject.Length; i++)
		{
			ISwitching component = switchableObject[i].gameObject.GetComponent<ISwitching>();
			if (component != null)
			{
				component.SwitchOff();
			}
		}
	}

	public virtual void AddDamage(float damage)
	{
		this.SwitchChange();
	}

	protected virtual void SwitchChange()
	{
		if (this.spriteRenderer.sprite == this.sprite_off)
		{
			this.audioSource.PlayOneShot(this.audioClips[0]);
			this.spriteRenderer.sprite = this.sprite_on;
			GameObject[] switchableObject = this.SwitchableObject;
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
		if (this.spriteRenderer.sprite == this.sprite_on)
		{
			this.audioSource.PlayOneShot(this.audioClips[1]);
			this.spriteRenderer.sprite = this.sprite_off;
			GameObject[] switchableObject = this.SwitchableObject;
			for (int i = 0; i < switchableObject.Length; i++)
			{
				ISwitching component2 = switchableObject[i].gameObject.GetComponent<ISwitching>();
				if (component2 != null)
				{
					component2.SwitchOff();
				}
			}
		}
	}

	public void SwitchOn()
	{
		this.spriteRenderer.sprite = this.sprite_on;
	}

	public void SwitchOff()
	{
		this.spriteRenderer.sprite = this.sprite_off;
	}

	protected SpriteRenderer spriteRenderer;

	[SerializeField]
	protected Sprite sprite_off;

	[SerializeField]
	protected Sprite sprite_on;

	[SerializeField]
	protected GameObject[] SwitchableObject;

	private AudioSource audioSource;

	[SerializeField]
	private AudioClip[] audioClips;
}
