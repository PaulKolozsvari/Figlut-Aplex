namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using OpenNETCF.Security.Cryptography;
    using System.Reflection;
    using System.IO;
    using System.Security.Cryptography;

    #endregion //Using Directives

    internal class Encryptor
    {
        #region Constants

        public Encryptor(string keyGeneratorPassword)
        {
            if (string.IsNullOrEmpty(keyGeneratorPassword))
            {
                throw new NullReferenceException("keyGeneratorPassword");
            }
            _keyGeneratorPassword = keyGeneratorPassword;
            _initializationVector = "ColdPlay";
        }

        #endregion //Constants

        #region Fields

        private string _keyGeneratorPassword;
        private string _initializationVector;

        #endregion //Fields

        #region Properties

        private byte[] StringToByteArray(string value)
        {
            byte[] result = new byte[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                result[i] = (byte)value[i];
            }
            return result;
        }

        private string ByteArrayToString(byte[] value)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte b in value)
            {
                result.Append(Convert.ToChar(b));
            }
            return result.ToString();
        }

        #endregion //Properties

        #region Methods

        internal string Encrypt(string decryptedString)
        {
            PasswordDeriveBytes keyGenerator = new PasswordDeriveBytes(_keyGeneratorPassword, null);
            byte[] cryptoKey = keyGenerator.CryptDeriveKey("RC2", "SHA1", 128, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            using (RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider())
            {
                using (ICryptoTransform encryptor = rc2.CreateEncryptor(cryptoKey, StringToByteArray(_initializationVector)))
                {
                    byte[] decryptedBytes = StringToByteArray(decryptedString);
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(StringToByteArray(decryptedString), 0, decryptedBytes.Length);
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        internal string Decrypt(string encryptedString)
        {
            PasswordDeriveBytes keyGenerator = new PasswordDeriveBytes(_keyGeneratorPassword, null);
            byte[] cryptoKey = keyGenerator.CryptDeriveKey("RC2", "SHA1", 128, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            using (RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider())
            {
                using (ICryptoTransform decryptor = rc2.CreateDecryptor(cryptoKey, StringToByteArray(_initializationVector)))
                {
                    byte[] encryptedBytes = Convert.FromBase64String(encryptedString);
                    byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    return ByteArrayToString(decryptedBytes);
                }
            }
        }

        #endregion //Methods
    }
}