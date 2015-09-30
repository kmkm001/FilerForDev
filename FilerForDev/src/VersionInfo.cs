
namespace VersionInformation
{
	class VersionInfo
	{
		/// <summary>
		/// 
		/// </summary>
		public enum VerInfo
		{
			COMMENTS,			// Key: Comments
			COMPANYNAME,		// Key: CompanyName
			FILEDESCRIPSTION,	// Key: FileDescripstion
			FILEVERSION,		// Key: FileVersion
			INTERNALNAME,		// Key: InternalName
			LEAGALCOPYRIGHT,	// Key: LegalCopyright
			LEAGALTRADEMARKS,	// Key: LegalTrademarks
			ORIGINALFILENAME,	// Key: OriginalFilename
			PRIVATEBUILD,		// Key: PrivateBuild
			PRODUCTNAME,		// Key: ProductName
			PRODUCTVERSION,		// Key: ProductVersion
			SPECIALBUILD		// Key: SpecialBuild
		}

		/// <summary>
		/// Get file version information.
		/// </summary>
		/// <param name="infoNum"></param>
		/// <returns></returns>
		public static string GetVersionInfo(VerInfo infoNum)
		{
			string ret = "";

			// Get my assembly.
			System.Reflection.Assembly asm =
				System.Reflection.Assembly.GetExecutingAssembly();
			// Get file version information.
			System.Diagnostics.FileVersionInfo fileVerInfo =
				System.Diagnostics.FileVersionInfo.GetVersionInfo(asm.Location);
			// Get requested information.
			ret = getDetailedInfo(infoNum, fileVerInfo);

			return ret;
		}

		private static string getDetailedInfo(VerInfo infoNum, System.Diagnostics.FileVersionInfo fileVerInfo)
		{
			string ret = "";

			switch (infoNum)
			{
				case VerInfo.COMMENTS:
					ret = fileVerInfo.Comments;
					break;
				case VerInfo.COMPANYNAME:
					ret = fileVerInfo.CompanyName;
					break;
				case VerInfo.FILEDESCRIPSTION:
					ret = fileVerInfo.FileDescription;
					break;
				case VerInfo.FILEVERSION:
					ret = fileVerInfo.FileVersion;
					break;
				case VerInfo.INTERNALNAME:
					ret = fileVerInfo.InternalName;
					break;
				case VerInfo.LEAGALCOPYRIGHT:
					ret = fileVerInfo.LegalCopyright;
					break;
				case VerInfo.LEAGALTRADEMARKS:
					ret = fileVerInfo.LegalTrademarks;
					break;
				case VerInfo.ORIGINALFILENAME:
					ret = fileVerInfo.OriginalFilename;
					break;
				case VerInfo.PRIVATEBUILD:
					ret = fileVerInfo.PrivateBuild;
					break;
				case VerInfo.PRODUCTNAME:
					ret = fileVerInfo.ProductName;
					break;
				case VerInfo.PRODUCTVERSION:
					ret = fileVerInfo.ProductVersion;
					break;
				case VerInfo.SPECIALBUILD:
					ret = fileVerInfo.SpecialBuild;
					break;
				default:
					ret = null;
					break;
			}

			// If information does not exit.
			if (ret == null)
			{
				throw new System.IO.FileNotFoundException();
			}

			return ret;
		}

	}
}
