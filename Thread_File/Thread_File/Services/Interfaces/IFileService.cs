using System;
namespace Thread_File.Services.Interfaces
{
	public interface IFileService
	{
        Task WriteToExistFileAsync(string path, string text);
        Task<string> ReaadFromFileAsync(string path);
        Task WriteToNewFileAsync(string path, string text);
        Task DeleteAsync(string path);
    }
}

