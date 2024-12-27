namespace Secure.API;

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


public static class EncryptManager
{
    public static string EncryptAES256(string plainText, string keyString)
    {
        var key = HashKey(keyString);
        
        var iv = new byte[16];
        byte[] array;

        using (var aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new StreamWriter((Stream)cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }

                    array = memoryStream.ToArray();
                }
            }
        }

        return Convert.ToBase64String(array);
    }
    
    public static string DecryptAES256(string cipherText, string keyString)
    {
        var key = HashKey(keyString);
        var iv = new byte[16];
        var buffer = Convert.FromBase64String(cipherText);

        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

        using var memoryStream = new MemoryStream(buffer);
        using var cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read);
        using var streamReader = new StreamReader((Stream)cryptoStream);
        return streamReader.ReadToEnd();
    }

    private static byte[] HashKey(string key)
    {
        return SHA256.HashData(Encoding.UTF8.GetBytes(key));
    }
}