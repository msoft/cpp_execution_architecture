using MixedAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureExample
{
	class Program
	{
		static void Main(string[] args)
		{
			string textToDisplay = "text to display";

			Console.WriteLine($"Displaying from managed code: {textToDisplay}");

			NativeCaller nativeCaller = new NativeCaller(textToDisplay);
			nativeCaller.CallNativeCode();

			Console.ReadLine();
		}
	}
}
