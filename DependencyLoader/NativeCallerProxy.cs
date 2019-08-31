using MixedAssembly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLoader
{
    public class NativeCallerProxy
    {
		private const string dependencySubFolder = "Dependencies";

		public NativeCallerProxy()
		{
			CopyDependencies();
		}

		public void CallNativeCaller(string textToDisplay)
		{
			NativeCaller nativeCaller = new NativeCaller(textToDisplay);
			nativeCaller.CallNativeCode();
		}

		private static void CopyDependencies()
		{
			string executableFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			string dependencyArchitecture = Environment.Is64BitProcess ? "x64" : "Win32";
			string dependencyFolder = Path.Combine(executableFolder, dependencySubFolder, dependencyArchitecture);

			foreach (var sourceFile in Directory.GetFiles(dependencyFolder, "*", SearchOption.TopDirectoryOnly))
			{
				string fileName = Path.GetFileName(sourceFile);
				string destinationFilePath = Path.Combine(executableFolder, fileName);
				File.Copy(sourceFile, destinationFilePath, true);
			}
		}
	}
}
