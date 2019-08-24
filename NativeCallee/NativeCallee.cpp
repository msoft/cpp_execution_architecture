#include "NativeCallee.h"

#include <wchar.h> 
#include <iostream>
#include <Windows.h>
#include <io.h>
#include <fcntl.h>

void DisplayTextWithCallee(const wchar_t *textToDisplay)
{
	NativeCallee *callee = new NativeCallee(const_cast<wchar_t*>(textToDisplay));
	callee->DisplayText();
	delete callee;
}

NativeCallee::NativeCallee(wchar_t *textToDisplay)
{
	this->textToDisplay = textToDisplay;
}

void NativeCallee::DisplayText()
{
	_setmode(_fileno(stdout), _O_U16TEXT);
	wprintf(L"Displaying from unmanaged code: %s\n", this->textToDisplay);
}