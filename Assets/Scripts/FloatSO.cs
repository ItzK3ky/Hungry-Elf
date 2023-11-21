using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
	private float value;

	public float Value { get => value; }

	public void ChangeAmountBy(float changeBy)
	{
		value += changeBy;
	}

	public void SetAmount(float newAmount)
	{
		value = newAmount;
	}
}
