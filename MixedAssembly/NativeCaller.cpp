#include "NativeCaller.h"
#include "NativeCallee.h"

#include <stdio.h>
#include <stdlib.h>
#include <vcclr.h>

using namespace System::Runtime::InteropServices;

namespace MixedAssembly
{
	NativeCaller::NativeCaller(String ^textToDisplay)
	{
		this->textToDisplay = textToDisplay;
	}

	void NativeCaller::NativeCaller::CallNativeCode()
	{
		pin_ptr<const wchar_t> convertedString = PtrToStringChars(this->textToDisplay);

		DisplayTextWithCallee(convertedString);
	}
}