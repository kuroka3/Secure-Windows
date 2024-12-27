namespace Secure.API;

public static class FileManager
{
    private const string EncryptCompleteText = "Secure_encrypted";
    
    public static string DecryptFile(EncryptedFile file, string password)
    {
        if (!BCrypt.Net.BCrypt.Verify(password, file.Password)) throw new WrongPasswordException();
        return EncryptManager.DecryptAES256(file.Content, password);
    }
    
    public static EncryptedFile OpenFile(string path)
    {
        var data = File.ReadAllLines(path);
        return new EncryptedFile(data[0], data[1]);
    }

    public static void SaveFile(string path, string content, string password)
    {
        var encryptCompleteText = BCrypt.Net.BCrypt.HashPassword(EncryptCompleteText);
        var encryptedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        var encryptedFile = new EncryptedFile(encryptedPassword, EncryptManager.EncryptAES256(content, password));
        File.WriteAllLines(path, [encryptedFile.Password, encryptedFile.Content, encryptCompleteText]);
    }

    public static void SaveOriginalFile(string path, string content)
    {
        File.WriteAllText(path, content);
    }

    public static bool IsEncrypted(string path)
    {
        try
        {
            return BCrypt.Net.BCrypt.Verify(EncryptCompleteText, File.ReadAllLines(path)[2]);
        }
        catch
        {
            return false;
        }
    }
}

public class EncryptedFile(string password, string content)
{
    public readonly string Password = password;
    public readonly string Content = content;
}

public class WrongPasswordException() : Exception();