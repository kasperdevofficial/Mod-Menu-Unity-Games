using UnityEngine;

public class ModMenu : MonoBehaviour
{
	private static bool ShowHide = false;

	public static bool toggle1, toggle2, toggle3;

	private static string str1, str2, str3;

	public static void MyGUI()
	{
		if (GUI.Button(new Rect(50, 50, 130f, 50f), "ModMenu"))
		{
			ShowHide = !ShowHide;
		}
		if (ShowHide)
		{
			GUI.Box(new Rect(50, 100, 200, 245), "Modded By KasperDEV");
			if (GUI.Button(new Rect(55, 125, 190f, 50f), "Test " + str1))
			{
				toggle1 = !toggle1;
			}
			if (GUI.Button(new Rect(55, 180, 190f, 50f), "Test2 " + str2))
			{
				toggle2 = !toggle2;
			}
			if (GUI.Button(new Rect(55, 235, 190f, 50f), "Test3 " + str3))
			{
				toggle3 = !toggle3;
			}
			if (GUI.Button(new Rect(55, 290, 190f, 50f), "<color=red>Google</color>"))
			{
				Application.OpenURL("https://google.com/"); // Url сайта
			}
			if (toggle1)
			{
				toggle1 = true;
				str1 = "<color=green>ON</color>";
			}
			else
			{
				toggle1 = false;
				str1 = "<color=red>OFF</color>";
			}
			if (toggle2)
			{
				toggle2 = true;
				str2 = "<color=green>ON</color>";
			}
			else
			{
				toggle2 = false;
				str2 = "<color=red>OFF</color>";
			}
			if (toggle3)
			{
				toggle3 = true;
				str3 = "<color=green>ON</color>";
			}
			else
			{
				toggle3 = false;
				str3 = "<color=red>OFF</color>";
			}
		}
	}
}