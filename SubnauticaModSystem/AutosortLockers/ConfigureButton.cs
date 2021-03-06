﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AutosortLockers
{
	public class ConfigureButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
	{
		public bool pointerOver;
		public AutosortTarget target;
		
		public void OnPointerClick(PointerEventData eventData)
		{
			if (target != null && enabled)
			{
				target.ShowConfigureMenu();
			}
		}

		public void Update()
		{
			var hover = enabled && pointerOver;
			transform.localScale = new Vector3(hover ? 1.3f : 1, hover ? 1.3f : 1, 1);
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			pointerOver = true;
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			pointerOver = false;
		}
	}
}
