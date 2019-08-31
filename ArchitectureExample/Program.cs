using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DependencyLoader;

namespace ArchitectureExample
{
	class Program
	{		
		static void Main(string[] args)
		{
			string textToDisplay = "text to display";

			Console.WriteLine($"Displaying from managed code: {textToDisplay}");

			var proxy = new NativeCallerProxy();
			proxy.CallNativeCaller(textToDisplay);

			Console.ReadLine();
		}
	}
}
