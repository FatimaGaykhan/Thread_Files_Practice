using System;
using Thread_File.Extensions;
using Thread_File.Services;
using Thread_File.Services.Interfaces;

namespace Thread_File.Controllers
{
	public class FileController
	{
		private readonly IFileService _fileService;
		public FileController()
		{
			_fileService = new FileService();
		}

		public async Task ReadDataAsync()
		{
			string result = await _fileService.ReaadFromFileAsync("/Users/fatimagaykhanova/Desktop/c#-filethreadtest/file2.txt");
			Console.WriteLine(result);
        }
		///Users/fatimagaykhanova/Desktop/c#-filethreadtest
		public async Task CreateFileWithContentAsync()
		{
            string data = AppDomain.CurrentDomain.BaseDirectory;
            var datas = data.Split("/");
            var path = string.Empty;
            foreach (var item in datas)
            {
                if (item != "/c#-filethreadtest")
                {
                    path += item + "/";
                }
                else
                {
                    break;
                }

            }
            path += "c#-filethreadtest";

            await Console.Out.WriteLineAsync("Add file name:");
            string fileName = Console.ReadLine();

            await Console.Out.WriteLineAsync("Add text:");
			string text = Console.ReadLine();

            string resultPath = path.GenerateFullPath(fileName);
            await _fileService.WriteToNewFileAsync(resultPath, text);
		}

		public async Task DeleteAsync()
		{
			await _fileService.DeleteAsync("/Users/fatimagaykhanova/Desktop/c#-filethreadtest/file7.txt"); 
		}
	}
}

