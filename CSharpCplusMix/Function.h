#pragma once
#include<string>
using namespace System;
public ref class  Function
{
public:
	Function();
	virtual ~Function();
	int member;
	int add(int a, int b);
	System::String^ say(System::String^ str);
};

