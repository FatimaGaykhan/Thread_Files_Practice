using System;
namespace Thread_File.Extensions
{
	public static  class FileExtesion
	{
		public static string GenerateFullPath(this string path, string fileName )
		{
			return $"{path}/{fileName}";
		}
	}
}

