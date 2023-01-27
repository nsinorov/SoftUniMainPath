namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream reader = new(inputFilePath, FileMode.Open);
            using FileStream writer = new(outputFilePath, FileMode.OpenOrCreate);

            byte[] buffer = new byte[512];

            int size = 0;

            while ((size = reader.Read(buffer, 0, buffer.Length)) != 0)
            {

                writer.Write(buffer, 0, size);

            }

          //  File.Copy(outputFilePath, inputFilePath); - works
        }
    }
}
