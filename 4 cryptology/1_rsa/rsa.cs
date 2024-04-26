using System;
using System.Security.Cryptography;
using System.Text;

class RSAExample
{
    static void Main(string[] args)
    {
        // Generate RSA key pair
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
        {
            try
            {
                // Export public key
                string publicKey = rsa.ToXmlString(false);
                // Export private key
                string privateKey = rsa.ToXmlString(true);

                string message = "Hello, this is a secret message!";
                Console.WriteLine("Original Message: " + message);

                // Encrypt message using public key
                byte[] encryptedBytes = Encrypt(Encoding.UTF8.GetBytes(message), publicKey);
                string encryptedMessage = Convert.ToBase64String(encryptedBytes);
                Console.WriteLine("Encrypted Message: " + encryptedMessage);

                // Decrypt message using private key
                byte[] decryptedBytes = Decrypt(Convert.FromBase64String(encryptedMessage), privateKey);
                string decryptedMessage = Encoding.UTF8.GetString(decryptedBytes);
                Console.WriteLine("Decrypted Message: " + decryptedMessage);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // Encrypt message using RSA public key
    static byte[] Encrypt(byte[] data, string publicKey)
    {
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.FromXmlString(publicKey);
            return rsa.Encrypt(data, false);
        }
    }

    // Decrypt message using RSA private key
    static byte[] Decrypt(byte[] data, string privateKey)
    {
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.FromXmlString(privateKey);
            return rsa.Decrypt(data, false);
        }
    }
}
