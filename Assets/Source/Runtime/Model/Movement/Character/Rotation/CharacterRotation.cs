using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement.Character.Rotation;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Character.Rotation
{
	public class CharacterRotation : ICharacterRotation
	{
		public float Value { get; private set; }

		private readonly CharacterRotationData _data;
		private readonly ICharacterRotationView _view;

		public CharacterRotation(ICharacterRotationView view, CharacterRotationData data)
		{
			_data = data;
			Value = data.MaxValue;
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Rotate()
		{
			Value = _data.MaxValue;
		}

		public void Update()
		{
			Value = Mathf.Lerp(Value, _data.MinValue, _data.Speed * Time.deltaTime);
			_view.Visualize(Value);
		}
	}
}
