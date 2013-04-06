using LicenseManager.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LicenseManager
{
	public class LicenseInfo
	{
		public static List<LicenseInfo> Licenses = new List<LicenseInfo>();

		private String _Name;
		public System.String Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private String _Email;
		public System.String Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		private DateTime _EndDate;
		public System.DateTime EndDate
		{
			get { return _EndDate; }
			set { _EndDate = value; }
		}

		private int _NumUsers;
		public int NumUsers
		{
			get { return _NumUsers; }
			set { _NumUsers = value; }
		}

		public String GetLicenseText()
		{
			String userString = " user";
			if (NumUsers > 1)
			{
				userString += "s";
			}

			String licenseText = "Licensed to: " + Name + " (" + Email + ") " +
				"Supports expires: " + EndDate.ToString("d") + " " +
				"Licensed for " + NumUsers + userString;

			String licenseKey = GetLicenseKey(licenseText);

			String finalLicenseText = "Licensed to: " + Name + " (" + Email + ")" + Environment.NewLine +
				"Supports expires: " + EndDate.ToString("d") + Environment.NewLine +
				"Licensed for " + NumUsers + userString + Environment.NewLine;

			foreach (String line in SplitByLength(licenseKey, 64))
			{
				finalLicenseText += line + Environment.NewLine;
			}

			return finalLicenseText;
		}

		public static IEnumerable<String> SplitByLength(String str, int maxLength)
		{
			for (int index = 0; index < str.Length; index += maxLength)
			{
				yield return str.Substring(index, Math.Min(maxLength, str.Length - index));
			}
		}

		private String GetLicenseKey(String licenseText)
		{

			String salt = "pgbnqn547oiymsvlad243";
			String finalString = salt + licenseText;
			Byte[] bytes = Encoding.ASCII.GetBytes(finalString);

			SHA256Managed hashAlgorithm = new SHA256Managed();
			byte[] hash = hashAlgorithm.ComputeHash(bytes);

			RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
			rsa.FromXmlString(Resources.privatekey);
			
			byte[] encryptedHash = RSAEncrypt(hash, rsa.ExportParameters(true), false);

			return Convert.ToBase64String(encryptedHash);
		}

		static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
		{
			try
			{
				byte[] encryptedData;
				// Create a new instance of RSACryptoServiceProvider. 
				using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
				{
					// Import the RSA Key information. This only needs 
					// toinclude the public key information.
					RSA.ImportParameters(RSAKeyInfo);

					// Encrypt the passed byte array and specify OAEP padding.   
					// OAEP padding is only available on Microsoft Windows XP or 
					// later.
					encryptedData = RSA.SignHash(DataToEncrypt, CryptoConfig.MapNameToOID("SHA256"));
				}

				return encryptedData;
			}
			// Catch and display a CryptographicException   
			// to the console. 
			catch (CryptographicException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}
	}
}
