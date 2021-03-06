using UnityEngine;
using System.Collections;

public class FlashingController : HighlightingController
{
	public Color flashingStartColor = Color.red;
	public Color flashingEndColor = new Color(0.9f, 0.475f, 0.475f, 1f);
	public float flashingDelay = 2.5f;
	public float flashingFrequency = 2f;
	
	void Start()
	{
		StartCoroutine(DelayFlashing());
	}
	
	protected IEnumerator DelayFlashing()
	{
		yield return new WaitForSeconds(flashingDelay);

		// Start object flashing after delay
		ho.FlashingOn(flashingStartColor, flashingEndColor, flashingFrequency);
	}
}
