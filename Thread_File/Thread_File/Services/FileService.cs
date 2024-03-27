using System;
using System.Text;
using Thread_File.Services.Interfaces;

namespace Thread_File.Services
{
	public class FileService:IFileService
	{
        public async Task DeleteAsync(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task<string> ReaadFromFileAsync(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader st = new StreamReader(fs))
                {
                    return await st.ReadToEndAsync();
                }
            }
        }

        public async Task WriteToExistFileAsync(string path, string text)
        {
        
            using (FileStream fs = new(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    await wr.WriteAsync(text);
                }
            }
            
        }

        public async Task WriteToNewFileAsync(string path, string text)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] datas = Encoding.UTF8.GetBytes(text);
                        await fs.WriteAsync(datas, 0, datas.Length);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

