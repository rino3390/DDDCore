﻿using System.Diagnostics;

namespace GameFramework.Utility
{
	public class Logger
	{
		[Conditional("DEBUG")]
		public static void Debug(string message)
		{
			UnityEngine.Debug.Log(message);
		}
		
		[Conditional("DEBUG")]
		public static void Debug(string message,string filter)
		{
			UnityEngine.Debug.Log($"[{filter}] {message}");
		}
	}
}