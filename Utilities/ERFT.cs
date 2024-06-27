using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Utilities
{
    public class ERFT
    {

        #region Private Members

        static string strSeckey = "Items Manager";

        #endregion

        #region Private Methods

        public static string Rtgy(string cipherText)
        {
            try
            {
                if (cipherText.Length == 0)
                    return string.Empty;
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(cipherText);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(strSeckey));

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (FormatException ex)
            {
                if (ex.Message == "Invalid length for a Base-64 char array.")
                {
                    Helper.ShowMessage("String is not encrypted.");
                    return cipherText;
                }
                else
                {
                    ErrorHandler.LogError(ex);
                    return string.Empty;
                }
            }
            catch (CryptographicException ex)
            {
                if (ex.Message == "Length of the data to decrypt is invalid.")
                {
                    Helper.ShowMessage("String is not encrypted.");
                    return cipherText;
                }
                else
                {
                    ErrorHandler.LogError(ex);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return string.Empty;
            }
        }
        public static string Yuio(string plainText)
        {
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(plainText);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(strSeckey));

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                return string.Empty;
            }
        }

        #endregion

    }
}