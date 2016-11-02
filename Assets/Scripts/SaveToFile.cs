using System.IO;
using UnityEngine;

public class SaveToFile
{
	public static int level;
	public static bool completed;
	public static float completionTime;
	public static float accuracy;

	private string scores;

	private string fileName;


	//This class stores information for each of the levels.
	public SaveToFile()
	{

		string path = Directory.GetCurrentDirectory();
		string keylogger = path + "keylogger.txt";
		Debug.Log (path);
		//FileUtil.CopyFileOrDirectory( keylogger, Application.persistentDataPath + "Keylogger.txt" );
		fileName = Application.persistentDataPath + "KeySpeedster.txt";

		Debug.Log(Application.persistentDataPath);

		try
		{

			if (!File.Exists(fileName))
			{
				Debug.Log("creating file");
				string[] header = new string[1];
				header[0] = "level completed completionTime accuracy\r\n";
				File.WriteAllLines(fileName, header);
			}

			Debug.Log("Opened file!");

			scores = level + " " + completed + " " + completionTime + " " + accuracy;

			Debug.Log("About to write into file!");
			File.AppendAllText( fileName, scores + "\r\n");
		}

		catch (System.Exception e)
		{
			Debug.Log(e);
		}
	}
}