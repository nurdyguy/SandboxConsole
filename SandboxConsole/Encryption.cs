using System;
using System.Threading.Tasks;
using Unify.Security;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace SandboxConsole
{
    public class Encryption
    {
        #region Singleton
        private static readonly byte[] KEY = Convert.FromBase64String(@"Dx3lSlCrnguvCgUB+RvDsaaH/SPNAI+Tvp4dagz9GIE=");
        private static readonly byte[] IV = Convert.FromBase64String(@"u5vJ8WVNuC1yR90enVaLkg==");

        /// <summary>
        /// Security Features specific to UNIFY
        /// </summary>
        public static Encryption Instance =>
            _instance ?? (_instance = new Encryption());
        private static Encryption _instance;

        /// <summary>
        /// Default Constructor
        /// </summary>
        protected Encryption() { }
        #endregion

        #region Encryption / Decryption Public Methods
        /// <summary>
        /// Encrypts the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns>The encrypted base64 string representation</returns>
        public async Task<string> EncryptAsync(string content) =>
            Convert.ToBase64String(await EncryptStringToBytesAsync(content, KEY, IV));

        /// <summary>
        /// Attempts to encrypt the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<string> TryEncryptAsync(string content)
        {
            try
            {
                return await EncryptAsync(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Decrypts the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<string> DecryptAsync(string content) =>
            await DecryptStringFromBytesAsync(Convert.FromBase64String(content), KEY, IV);

        /// <summary>
        /// Attempts to decrypt the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<string> TryDecryptAsync(string content)
        {
            try
            {
                return await DecryptAsync(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Encrypts the given data
        /// </summary>
        /// <param name="content"></param>
        /// <param name="result"></param>
        public void Encrypt(string content, out string result) =>
            result = Encrypt(content);

        /// <summary>
        /// Attempts to Encrypt the given data
        /// </summary>
        /// <param name="content"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryEncrypt(string content, out string result)
        {
            try
            {
                result = Encrypt(content);
                return true;
            }
            catch (Exception e)
            {
                result = null;
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Decrypts the given data
        /// </summary>
        /// <param name="content"></param>
        /// <param name="result"></param>
        public void Decrypt(string content, out string result) =>
            result = Decrypt(content);

        /// <summary>
        /// Attempts to Decrypt the given data
        /// </summary>
        /// <param name="content"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryDecrypt(string content, out string result)
        {
            try
            {
                result = Decrypt(content);
                return true;
            }
            catch (Exception e)
            {
                result = null;
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Encrypts the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Encrypt(string content) =>
            Convert.ToBase64String(EncryptStringToBytes(content, KEY, IV));

        /// <summary>
        /// Attempts to encrypt the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string TryEncrypt(string content)
        {
            try
            {
                return Encrypt(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Decrypts the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Decrypt(string content) =>
            DecryptStringFromBytes(Convert.FromBase64String(content), KEY, IV);

        /// <summary>
        /// Attempts to decrypt the given data
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string TryDecrypt(string content)
        {
            try
            {
                return Decrypt(content);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion

        #region Actual Encryption
        /// <summary>
        /// Non-Async Attempts to convert the string to an encrypted byte array
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        private byte[] EncryptStringToBytes(string text, byte[] key, byte[] iv)
        {
            // check arguments
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException(nameof(text));
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException(nameof(key));
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException(nameof(iv));
            byte[] encrypted;
            // Create a RijndaelManaged object with the specified key and iv
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a encryptor to perform the stream transform
                var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
                // create the stream used for encryption
                using (var stream = new MemoryStream())
                using (var encrypt = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
                {
                    using (var writer = new StreamWriter(encrypt))
                        writer.Write(text);
                    encrypted = stream.ToArray();
                }
            }

            // return the encrypted bytes from the memory stream
            return encrypted;
        }

        /// <summary>
        /// Non-Async Attempts to decrypt the given byte array to a valid string
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        private string DecryptStringFromBytes(byte[] bytes, byte[] key, byte[] iv)
        {
            // check arguments
            if (bytes == null || bytes.Length <= 0)
                throw new ArgumentNullException(nameof(bytes));
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException(nameof(key));
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException(nameof(iv));

            // Declare the string used to hold the decrypted text
            string text;
            // create a rijndaelmanaged object with the specified key and iv
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = key;
                rijAlg.IV = iv;

                // create a decryptor to perform the stream transform
                var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
                // create the stream used for decryption
                using (var stream = new MemoryStream(bytes))
                using (var decrypt = new CryptoStream(stream, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(decrypt))
                    text = reader.ReadToEnd();
            }
            return text;
        }

        /// <summary>
        /// Attempts to convert the string to an encrypted byte array
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        private async Task<byte[]> EncryptStringToBytesAsync(string text, byte[] key, byte[] iv)
        {
            // check arguments
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException(nameof(text));
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException(nameof(key));
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException(nameof(iv));
            byte[] encrypted;
            // Create a RijndaelManaged object with the specified key and iv
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = key;
                rijAlg.IV = iv;

                // Create a encryptor to perform the stream transform
                var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
                // create the stream used for encryption
                using (var stream = new MemoryStream())
                using (var encrypt = new CryptoStream(stream, encryptor, CryptoStreamMode.Write))
                {
                    using (var writer = new StreamWriter(encrypt))
                        await writer.WriteAsync(text);
                    encrypted = stream.ToArray();
                }
            }

            // return the encrypted bytes from the memory stream
            return encrypted;
        }

        /// <summary>
        /// Attempts to decrypt the given byte array to a valid string
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        private async Task<string> DecryptStringFromBytesAsync(byte[] bytes, byte[] key, byte[] iv)
        {
            // check arguments
            if (bytes == null || bytes.Length <= 0)
                throw new ArgumentNullException(nameof(bytes));
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException(nameof(key));
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException(nameof(iv));

            // Declare the string used to hold the decrypted text
            string text;
            // create a rijndaelmanaged object with the specified key and iv
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = key;
                rijAlg.IV = iv;

                // create a decryptor to perform the stream transform
                var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
                // create the stream used for decryption
                using (var stream = new MemoryStream(bytes))
                using (var decrypt = new CryptoStream(stream, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(decrypt))
                    text = await reader.ReadToEndAsync();
            }
            return text;
        }

        #endregion
    }
}
