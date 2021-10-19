using System;

namespace BMS.Utils
{
	/// <summary>
	/// Summary description for MD5.
	/// </summary>
	public class MD5
	{
        public static string _code = "RTC%$#tEch~`'3keY";
        public MD5()
		{
		}

        /// <summary>
        /// To encrypt the input password
        /// </summary>
        /// <param name="txtPassword"></param>
        /// <returns>It returns encrypted code</returns>
        public static string EncryptPassword(string txtPassword)
        {
            byte[] passBytes = System.Text.Encoding.Unicode.GetBytes(txtPassword);
            string encryptPassword = Convert.ToBase64String(passBytes);
            return encryptPassword;
        }

        /// <summary>
        /// To Decrypt password
        /// </summary>
        /// <param name="encryptedPassword"></param>
        /// <returns>It returns plain password</returns>
        public static string DecryptPassword(string encryptedPassword)
        {
            byte[] passByteData = Convert.FromBase64String(encryptedPassword);
            string originalPassword = System.Text.Encoding.Unicode.GetString(passByteData);
            return originalPassword;
        }

		public static string Hash(string toEncrypt) 
		{ 
			System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create(); 
			string encrypted = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(toEncrypt))).Replace("-", String.Empty).ToLower();
			return encrypted;            
        }

        public static string EncodeChecksum(string toEncode)
        {
            try
            {
                string encrypted = Encrypt(toEncode, _code, true);
                Random r = new Random();
                encrypted = encrypted.Insert(encrypted.Length - 1, char.ConvertFromUtf32(r.Next(26) + 97));
                encrypted = encrypted.Insert(8, char.ConvertFromUtf32(r.Next(26) + 97));
                encrypted = encrypted.Insert(3, char.ConvertFromUtf32(r.Next(26) + 97));
                return encrypted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string DecodeChecksum(string toDecode)
        {
            try
            {
                string decrypted = toDecode.Remove(toDecode.Length - 2, 1);
                decrypted = decrypted.Remove(9, 1);
                decrypted = decrypted.Remove(3, 1);
                decrypted = Decrypt(decrypted, _code, true);
                return decrypted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Encrypts a string using a specified security key with
        /// the option to hash.
        /// </summary>
        /// <param name="toEncrypt">String to encrypt</param>
        /// <param name="securityKey">The key to apply to the encryption</param>
        /// <param name="useHashing">Weather hashing is used</param>
        /// <returns>The encrpyted string</returns>
        private static string Encrypt(string toEncrypt, string securityKey, bool useHashing)
        {
            string retVal = string.Empty;
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = System.Text.UTF8Encoding.UTF8.GetBytes(toEncrypt);
                // Validate inputs
                ValidateInput(toEncrypt);
                ValidateInput(securityKey);
                // If hashing use get hashcode regards to your key
                if (useHashing)
                {
                    System.Security.Cryptography.MD5CryptoServiceProvider hashmd5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(securityKey));
                    // Always release the resources and flush data
                    // of the Cryptographic service provide. Best Practice
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(securityKey);
                }
                System.Security.Cryptography.TripleDESCryptoServiceProvider tdes = new System.Security.Cryptography.TripleDESCryptoServiceProvider();
                // Set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                // Mode of operation. there are other 4 modes.
                // We choose ECB (Electronic code Book)
                tdes.Mode = System.Security.Cryptography.CipherMode.ECB;
                // Padding mode (if any extra byte added)
                tdes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                System.Security.Cryptography.ICryptoTransform cTransform = tdes.CreateEncryptor();
                // Transform the specified region of bytes array to resultArray
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                // Release resources held by TripleDes Encryptor
                tdes.Clear();
                // Return the encrypted data into unreadable string format
                retVal = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retVal;
        }

        /// <summary>
        /// Decrypts a specified key against the original security
        /// key, with the option to hash.
        /// </summary>
        /// <param name="cipherString">String to decrypt</param>
        /// <param name="securityKey">The original security key</param>
        /// <param name="useHashing">Weather hashing is enabled</param>
        /// <returns>The decrypted key</returns>
        private static string Decrypt(string cipherString, string securityKey, bool useHashing)
        {
            string retVal = string.Empty;
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                // Validate inputs
                ValidateInput(cipherString);
                ValidateInput(securityKey);
                if (useHashing)
                {
                    // If hashing was used get the hash code with regards to your key
                    System.Security.Cryptography.MD5CryptoServiceProvider hashmd5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(securityKey));
                    // Release any resource held by the MD5CryptoServiceProvider
                    hashmd5.Clear();
                }
                else
                {
                    // If hashing was not implemented get the byte code of the key
                    keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(securityKey);
                }
                System.Security.Cryptography.TripleDESCryptoServiceProvider tdes = new System.Security.Cryptography.TripleDESCryptoServiceProvider();
                // Set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                // Mode of operation. there are other 4 modes. 
                // We choose ECB(Electronic code Book)
                tdes.Mode = System.Security.Cryptography.CipherMode.ECB;
                // Padding mode(if any extra byte added)
                tdes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                System.Security.Cryptography.ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                // Release resources held by TripleDes Encryptor
                tdes.Clear();
                // Return the Clear decrypted TEXT
                retVal = System.Text.UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retVal;
        }

        /// <summary>
        /// Validates an input value
        /// </summary>
        /// <param name="inputValue">Specified input value</param>
        /// <returns>True | Falue - Value is valid</returns>
        private static bool ValidateInput(string inputValue)
        {
            bool valid = !string.IsNullOrEmpty(inputValue);
            if (!valid)
                throw new Exception("Input is null or empty.");
            return valid;
        }
	}
}
