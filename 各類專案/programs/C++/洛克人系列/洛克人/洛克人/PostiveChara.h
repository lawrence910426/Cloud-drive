#include "TestScene.h"






namespace 洛克人
{
    using namespace System;
	using namespace System::Windows::Forms;
	using namespace System::Drawing;
	using namespace System::IO;
	public ref class pchara
	{
		
	public:
		Graphics^* g;
		int x;
		int y ;
		
		Timer^ t;
		
		
		//TestScene
		chkStandTestScene^ chkStand;


		//all Scenes needs
		bool redraw;
		pchara(testScene^ ts) /*face right/left
															 , stand/sliding/jumping/falling/running 
															 , bltAtkingLv1/bltLv2/bltLv3/bltLv4/集氣
															 2*5*5
															 */
		{
			//g = gPtr;
			//ts = tss;
			chkStand = gcnew chkStandTestScene();
			t = gcnew Timer();
			t->Interval = 20;
			t->Tick += gcnew EventHandler(this , &pchara::tick);
			t->Enabled = true; 
		    //	tick();
			//p = pl;




		}	
		pchara(pchara^ p)//copy things
		{
	


		}






		bool goRight;
		bool goLeft;
		bool faceRight; // -> this is right
		int goLefts;//
		
		
		int jumpLefts;
	    void tick(System::Object^ obj , EventArgs^ e)
		{
			
			//for(int i = 0;i != 49;) // 49 is the blocks(length) of array blks1
			//{
			//	i++;
			//   if(ts->blks1[i]->y > y)
			//   {
			//	   y = y + 10;

			//   }
			//}

			/*this kind of thing will use thouthand times of meoemery*/
		 

			this->y -= jumpLefts;

			if(!testSceneStanding())//the time floating will drop down
			{
				jumpLefts = jumpLefts - 2;
			}
			else
			{

				jumpLefts = 0;
			}
			if(goLeft)
			{
			    x = x - 5;
				
				if(++goLefts == 10)
				{
					goLefts = 0;
					goLeft = false;
				}
			}
			if(goRight)
			{
				x = x + 5;
				if(++goLefts == 10)
				{
					goLefts = 0;
					goRight = false;
				}
			}
			return;

		}

		int i;
		bool testSceneStanding()
		{
			int X = x;
			int Y = y;
			bool preSend = chkStand->standing(&X ,&Y ,100 , 40);
			//if(i == 20)
			{
				//out put back
				//platForm1
				int preX = chkStand->outPutBackPF1(&X ,&Y ,(short)40 , (short)100);//100 IS IT'S HEIGHT
				if(preX >= 2000)
				{
					redraw = true;
					this->x = preX - 2000;
					this->y = this->y - 10;
				}//i++;
			}
			{
				int preX = chkStand->outPutBackPF2(&X ,&Y ,(short)40 , (short)100);
				if(preX >= 2000)
				{
					redraw = true;
					this->x = preX - 2000;
					this->y = this->y - 10;
				}//i++;
			}
			{
				int preX = chkStand->outPutBackPF3(&X ,&Y ,(short)40 , (short)100);
				if(preX >= 2000)
				{
					redraw = true;
					this->x = preX - 2000;
					this->y = this->y - 10;
				}//i++;
			}
 			return preSend;
		}








		void draw()
		{






		}
		void goingLeft()
		{
		   /*x--;
		   x--;*/
           goLeft = true;
		   
		}
		void goingRight()
		{
            /*x++;
			x++;*/
			goRight = true;

		}
		void jump()
		{
			jumpLefts = 30;

		}
		void keyDown(char e) 
	    {
				 switch(e)
				 {
				 case 'a':
					 goingLeft();
                     //break;
				 case 'w':
					 jump();
                     break;
				 case 's':
					 
                     break;
				 case 'd':
					 goingRight();
					 break;
				 case 'A':
					 goingLeft();
					 break;
				 case 'W':
					 jump();
					 break;
				 case 'S':
					 
					 break;
				 case 'D':
                     goingRight();

					 break;

				 }







	     }


	};

}
