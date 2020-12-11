// 洛克人.cpp: 主要專案檔。

#include "stdafx.h"
#include "Form1.h"

//this is a project lawrence(lawrence Wu ,born in year2002 month04 day 26)did at 2014 06 20
//i do it while i listen couple songs or i will explode
//hopefully this program can keep until i reopen it again and again
//洛克人是我小學3年級時很迷的一個遊戲
//使用microsoft visaul studio 2010 ultimate撰寫這一個程式時是在2014/06/20
//這一個工作環境是2年前的(頗新的  我12歲畢業後的第一個禮拜做ㄉ

using namespace 洛克人;

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	// 建立任何控制項之前，先啟用 Windows XP 視覺化效果
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// 建立主視窗並執行
	Application::Run(gcnew Form1());
	return 0;
}

