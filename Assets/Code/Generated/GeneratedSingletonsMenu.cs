﻿// Dynamically generated by SingletonAttribute

using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 

public static class GeneratedSingletonsMenu
{
#if UNITY_EDITOR
	[UnityEditor.MenuItem("Window/Singletons/UnitySingleton")]
	public static void InspectUnitySingleton()
	{
		UnityEditor.Selection.activeObject = UnitySingleton.Instance;
	}
#endif
}
