using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
	private float value;
	[SerializeField] private float initialValue;

	public float Value { get => value; }

	public void ChangeAmountBy(float changeBy)
	{
		value += changeBy;
	}

	public void SetAmount(float newAmount)
	{
		value = newAmount;
	}

	public void ResetAmount()
	{
		value = initialValue;
	}
}
