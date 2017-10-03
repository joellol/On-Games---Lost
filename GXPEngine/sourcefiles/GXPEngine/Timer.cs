﻿using System;
using GXPEngine;

public class Timer : GameObject
{
	private int _time;
	private Action _onTimeout;

	public Timer(int time, Action onTimout)
	{
		_time = time;
		_onTimeout = onTimout;
	}
	public void Update()
	{
		_time -= Time.deltaTime;
		if (_time <= 0)
		{
			_onTimeout();
			Destroy();
		}
	}
}
