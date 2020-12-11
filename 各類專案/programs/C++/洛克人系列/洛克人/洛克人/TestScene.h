#include "basicClass.h"



namespace 洛克人
{
	//every single scene's base
	public ref class testScene 
	{
	public:
		//this is the way i name all this
		//please follow this ... rule
		int PF1X;
		int PF1Y;
		int PF2X;
		int PF2Y;
		int PF3X;
		int PF3Y;
		 ;//dimention 1 is for X ,dimention 2 is for Y ,dimention 3 is for blocks
//= gcnew platForm(800 ,400 ,50 ,g);
	    //array<block^>^ blks1;
		//platForm pfMid;
		//platForm pfUp;

		//a lot of thing i don' know( or exceptions
		//Graphics^* g;
		//static platForm pfDown;
	
		
	    testScene(Graphics^* gPtr)
		{
			
			
			/*
			g = gPtr;	
			platForm pf1 = gcnew platForm(0 ,600 ,50 ,g);
		    platForm pf2 = gcnew platForm(400 ,500 ,50 ,g);
		    platForm pf3 = gcnew platForm(800 ,400 ,50 ,g);
			for(int i = 0; i != int.MaxValue;)
			{
                i++;


			}
			//gcnew platForm(800 ,400 ,50 ,g)
			//pfMid = pf2;
			//pfUp 

			*/
			platForm pf1 = gcnew platForm(0 ,600 ,50 ,gPtr , true); // you cannot set it as zero or it will have a null refrence exception(刻意給他跳過去的話
			platForm pf2 = gcnew platForm(400 ,500 ,50 ,gPtr , true);
		    platForm pf3 = gcnew platForm(800 ,400 ,50 ,gPtr , true);
			//pfs[0,0] = pf1.x;//the zeros is for pf1
			//pfs[0,1] = pf1.y;
			//pfs[0,2] = pf1.blks;
			//pfs[1,0] = pf2.x;
			//pfs[1,1] = pf2.y;
			//pfs[1,2] = pf2.blks;
			//pfs[2,0] = pf3.x;
			//pfs[2,1] = pf3.y;
			//pfs[2,2] = pf3.blks;
			PF1X = pf1.x;
			PF1Y = pf1.y;
			PF2X = pf2.x;
            PF2Y = pf2.y;
			PF3X = pf3.x;
			PF3Y = pf3.y;
			/*for(int i = 0 ; i != 49;)
			{
				i++;
				blks1[i] = gcnew block();
				blks1[i]->copyTo(pf1.blk[i]->x , pf1.blk[i]->y);
			}*/
			
			
		}	
		testScene()
		{
			
			/*
			g = gPtr;	
			platForm pf1 = gcnew platForm(0 ,600 ,50 ,g);
		    platForm pf2 = gcnew platForm(400 ,500 ,50 ,g);
		    platForm pf3 = gcnew platForm(800 ,400 ,50 ,g);
			for(int i = 0; i != int.MaxValue;)
			{
                i++;


			}
			//gcnew platForm(800 ,400 ,50 ,g)
			//pfMid = pf2;
			//pfUp 

			*/
			
			
			platForm pf1 = gcnew platForm(0 ,600 ,50 ,nullptr , false);//just don't draw anything
		    platForm pf2 = gcnew platForm(400 ,500 ,50 ,nullptr , false);
		    platForm pf3 = gcnew platForm(800 ,400 ,50 ,nullptr , false);
			PF1X = pf1.x;
			PF1Y = pf1.y;
			PF2X = pf2.x;
            PF2Y = pf2.y;
			PF3X = pf3.x;
			PF3Y = pf3.y;
			//pfs[0,0] = pf1.x;//the zeros is for pf1
			//pfs[0,1] = pf1.y;
			//pfs[0,2] = pf1.blks;
			//pfs[1,0] = pf2.x;
			//pfs[1,1] = pf2.y;
			//pfs[1,2] = pf2.blks;
			//pfs[2,0] = pf3.x;
			//pfs[2,1] = pf3.y;
			//pfs[2,2] = pf3.blks;
			/*for(int i = 0 ; i != 49;)
			{
				i++;
				blks1[i] = gcnew block();
				blks1[i]->copyTo(pf1.blk[i]->x , pf1.blk[i]->y);
			}*/
			
			
		}
		testScene(testScene^ ts)
		{
			/*ts->PF1X = this->PF1X;
			ts->PF1Y = this->PF1Y;
			ts->PF2X = this->PF2X;
            ts->PF2Y = this->PF2Y;
			ts->PF3X = this->PF3X;
			ts->PF3Y = this->PF3Y;*/
			/*for(int i = ts->pfs->Length; i != 100;)
				i = i + 1;*/
		}
		/*testScene(testScene^ ts)
		{  
		
		
		}*/

		//void s()
		//{

		//	array<platForm^>^ b = gcnew array<platForm^>(100);


		//}
		   ~testScene()
		   {




		   }








	};
	/*
	ref class pf1Sub
	{
	public:
		testScene^* sample;
	
		pf1Sub()
		{
			//sample = ts;testScene^* ts
		}
        pf1Sub(pf1Sub^ pf)
		{
			this->sample = pf->sample;
		}
	







			

		}
	ref class pf2Sub
	{
	public:
		testScene^* sample;
	
		pf2Sub()//sample = ts;testScene^* ts
		{
			
		}
		pf2Sub(pf1Sub^ pf)
		{
			this->sample = pf->sample;
		}


	};
	ref class pf3Sub
	{
	public:
		testScene^* sample;
	
		pf3Sub()
		{
			//sample = ts;testScene^* ts

		}
		pf3Sub(pf1Sub^ pf)
		{
			this->sample = pf->sample;
		}

	};
	*/
    public ref class chkStandTestScene
	{
	public:
        testScene^ sample;
		/*pf1Sub^ pf1S;
		pf2Sub^ pf2S;
		pf3Sub^ pf3S;*/
		chkStandTestScene()
		{
			sample = gcnew testScene();
			//pf1S = gcnew pf1Sub();//&((testScene^)sample)
			//pf1S->sample = &(this->sample);
			//pf2S = gcnew pf2Sub();//&((testScene^)sample)
			//pf2S->sample = &(this->sample);
			//pf3S = gcnew pf3Sub();//&((testScene^)sample)
			//pf3S->sample = &(this->sample);
		}
		/*chkStandTestScene(chkStandTestScene^ chks)
		{
			this->sample = chks->sample;
			this->pf1S = chks->pf1S;
			this->pf2S = chks->pf2S;
			this->pf3S = chks->pf3S;
		}*/
		bool standing(int *x, int *y, short height, short width)
		{
			//if(y + height < sample->PF1Y)
			//{
			//	return false;
			//}
			//if(!InPF1X(x ,width))
			//{
			//	return false;
			//}
			//return true;
			if(PF1Xstand(x ,y ,&height ,&width) | PF2Xstand(x ,y ,&height ,&width) | PF3Xstand(x ,y ,&height ,&width))
			{
			   return true;
			}
			else
			{
				return false;
			}
		
		}
		int outPutBackPF1(int *x,int *y,short width,short height)
		{
		    if(InPF1X(x ,&width))
			{
				if(*y + height > sample->PF1Y)
				{
					if(*y <= sample->PF1Y)
					{
 						return sample->PF1X + 2000;
					}
				}
			}
			return *x ;

		}
		int outPutBackPF2(int *x,int *y,short width,short height)
		{
		    if(InPF2X(x ,&width))
			{
				if(*y + height > sample->PF2Y)
				{
					if(*y <= sample->PF2Y)
					{
 						return sample->PF2X + 2000;
					}
				}
			}
			return *x ;

		}
		int outPutBackPF3(int *x,int *y,short width,short height)
		{
		    if(InPF3X(x ,&width))
			{
				if(*y + height > sample->PF3Y)
				{
					if(*y <= sample->PF3Y)
					{
 						return sample->PF3X + 2000;
					}
				}
			}
			return *x ;

		}
		bool PF1Xstand(int* x, int* y, short* height, short* width)
		{
			if(*y + *height < sample->PF1Y)
			{
				return false;
			}
			if(!InPF1X(x ,width))
			{
				return false;
			}
			if((*y > sample->PF1Y))//if you are down the platForm then you cannot keep standing
		    {
				 return false;
			}
			//to avoid charactor going from side
		

			return true;
		}
		bool InPF1X(int* x, short* width)
		{
            if(((*x) + *width) < (sample->PF1X))//means is it over the left part of platForm1
			{
				return false;
			}
			else
			{
				int PF1Xleft = sample->PF1X + 10 * 50;//ten is block's width fifty is teh blocks which pf1 got 
				if((*x) > PF1Xleft)
				{
					return false;
				}
				//else
				{
					return true;
				}

			}
	};
		bool PF2Xstand(int* x, int* y, short* height, short* width)
		{
			if(*y + *height < sample->PF2Y)
			{
				return false;
			}
			if(!InPF2X(x ,width))
			{
				return false;
			}
			if((*y > sample->PF2Y))//if you are down the platForm then you cannot keep standing
		    {
				 return false;
			}
			//to avoid charactor going from side
		

			return true;
		}
		bool InPF2X(int* x, short* width)
		{
            if(((*x) + *width) < (sample->PF2X))//means is it over the left part of platForm1
			{
				return false;
			}
			else
			{
				int PF2Xleft = sample->PF2X + 10 * 50;//ten is block's width fifty is teh blocks which PF2 got
				if((*x) > PF2Xleft)
				{
					return false;
				}
				//else
				{
					return true;
				}

			}

		}
	    bool PF3Xstand(int* x, int* y, short* height, short* width)
		{
			if(*y + *height < sample->PF3Y)
			{
				return false;
			}
			if(!InPF3X(x ,width))
			{
				return false;
			}
			if((*y > sample->PF3Y))//if you are down the platForm then you cannot keep standing
		    {
				 return false;
			}
			//to avoid charactor going from side
		

			return true;
		}
		bool InPF3X(int* x, short* width)
		{
            if(((*x) + *width) < (sample->PF3X))//means is it over the left part of platForm1
			{
				return false;
			}
			else
			{
				int PF3Xleft = sample->PF3X + 10 * 50;//ten is block's width fifty is teh blocks which PF3 got
				if((*x) > PF3Xleft)
				{
					return false;
				}
				//else
				{
					return true;
				}

			}

		}

	};
	
}
