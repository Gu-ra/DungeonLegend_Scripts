using System;
using UnityEngine;

public class PixelObjectBase : MonoBehaviour
{
    //ドット絵オブジェクト
	private void LateUpdate()
	{
		this.cashPosition = base.transform.localPosition;
		base.transform.localPosition = new Vector3((float)Mathf.RoundToInt(this.cashPosition.x), (float)Mathf.RoundToInt(this.cashPosition.y), (float)Mathf.RoundToInt(this.cashPosition.z));
	}

	private void OnRenderObject()
	{
		base.transform.localPosition = this.cashPosition;
	}

	private Vector3 cashPosition;
}
