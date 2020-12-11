// learnCpp.cpp : 定義主控台應用程式的進入點。
//
#include "headI.h"
#include "stdafx.h"
#include <iostream>;
#include <sys\types.h>


using std::cout;
using std::cin;
using std::endl;
using std::string;
string s = "abc";
class CIQ
{




public:
	int score;
	int age;
	//
	//
	//
	//
	//
	~CIQ()
	{
		cout << "dead" << endl;

	}
	CIQ()
	{
	this ->	score = 10;
	this ->	age = 10;
		cout << "builded" << endl;

	
      }	
	int getIQ(int score,int age)
	{
		return (int)(score/age);
	}
private:
	int hahahhha;


};

namespace n
{
	/*
     void v() 
     {
	    cout << "void finished regullarly";
	

      }
	 void sendPointer()
	 {
		 int j = 10;
		 int* i = nullptr;		
		 i = &j;
		 int* i2 = i;
		 cout << *i2 << endl;
	
	 }
//call
	// void show(const char msg[] = "hahahaha");
	 void show(char msg[] )
	 {

		 cout << msg;



	 }
	 */


	void dig()
    {
	
	

    CIQ* c(new CIQ());
	
	cout << (*c).age << endl;
	delete c;
     }

	
}
int _tmain(int argc, _TCHAR* argv[])
{
	
	do
	{
		//cout << c::score;
		
		char c ;
		cin >> c ;
     //  std::basic_string s = "hahahahah";
	cout << (int)"sss" << endl;
		n::dig();
		
		cout << c << endl;
	}while(true);


	return 0;

}




void v ()
{


}





