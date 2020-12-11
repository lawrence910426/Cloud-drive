#pragma once
namespace ¬¥§J¤H
{

 

	using namespace System;
	using namespace System::Windows::Forms;
	using namespace System::Drawing;
	using namespace System::IO;



	/*namespace Drawing
	{
		public class Line
		{
		public:
			Int32 ptloc[3];
		
		    Line(Int32 pt[3])
			{
			   ptloc[0] = pt[0];
			   ptloc[1] = pt[1];
			   ptloc[2] = pt[2];
			   ptloc[3] = pt[3];
			  
				
			   
		
			   delete pt;

			}
			~Line()
			{
			   


			}

		};
		public ref class Pic
		{
			Color img[1024,788];
			Pic(Color background = Color::Black)
			{
				for(int i = -1 ; i != 1024;i++)
					for(int j = 0 ; j != 788;)
						img[i,j++] = background;


			}
			~Pic()
			{



			}


		};


	}*/
	public ref class block
	{

		//way to use 
		//give the constrouctor all the thing it needs ,when autodraw is true it will call void draw automaticly . if it is not then
		//you needs to call this void by yourself . the gF is for the graphics you want to be drawn .imgpath is the image's path
		//if you give this thing "" then it won't draw this image, it will draw the regular graphic 
	public:
		Graphics^* g;
		String^ path;
		int x ;
		int y ;
	    static	const int width  = 10;
	    static	const int height = 10;
	public:
		block(Graphics^* gsPtr,int X,int Y,String^ imgpath,bool autodraw)
		{	
         //Graphics^* gF,
			x = X;
			y = Y;
			g = gsPtr;
			//delete gsPtr;




			//drawing function
			
	             bool usePath = false;
			     if(imgpath != "")
			     {
		            path = imgpath;
				    usePath = true;
			     }
			     delete imgpath;
			      //g = gF;
			     //delete gF
			     if(autodraw)
				    draw(&usePath);
//			     delete gF;
			

		}
		block(block^ blk)
		{
		    /*throw gcnew Exception();*/
		}
		block()
		{
			x = 0;
			y = 0;
			path = "";
			g = nullptr;
		}
		~block()
		{
		}
		void copyTo(int X, int Y)
		{
			this->x = X;
			this->y = Y;
		}



		void draw(bool *usepath)
		{
	    /*   for(int i = 0 ; i != 100;)
		     	g->DrawLine(gcnew Pen(Color::Green),i , 10, i++, 110);*/
		   for(int i = x ; i != x + width;)
		   {

			   //the program in form.h didn't give it a thing yet(just en line        debugged
			  // Graphics^ gs = (*g);
		     	(*g)->DrawLine(gcnew Pen(Color::Green),i , y, i++, y + height);
		   }
		   PointF pt = PointF(20,50);
		   if(*usepath)
	           (*g)->DrawImage(Image::FromFile(path),pt);
	 /*      delete pt;
		   delete path;
		   delete usepath;
		   delete g;*/

		}
		

	};
	public ref class platForm
	{

		/* way to use */
		//send the X position you want to make a platForm and send the Y pos you wanna to make the platForm.
		//Blocks is the blocks program will make for you. gGptr is the pointer which give to the block to draw
	public:
		Graphics^* g;
		//array<block^>^ blk;
		int x;
		int y;
		int blks;
	/*	platForm operator==(const platForm pf)
		{



			return pf;
		}*/
		platForm(int X, int Y, int blocks,Graphics^* gptr,bool autodraw)//because the way of the array functioning , so i needs to add 1 at varible blocks
		{
			/*blocks++;
			blk = gcnew array<block^>(blocks);
			blks = blocks;*/
			g = gptr;

			
			blks = blocks;
			array<block^>^ blk = gcnew array<block^>(blks);
	        for(int i = 0; i != blks - 1;)
			{
				blk[i] = gcnew block(g ,X + (++i * 10) , Y, "", autodraw); 

			}
            x = X;
			y = Y;

		}

        platForm(platForm^ pf)
		{
			//do the things copies
		    this->y = pf->y;
			this->x = pf->x;
			this->g = pf->g;
			this->blks = pf->blks;
		}


	};
	public ref class wall
	{
		/*way to use*/
		//the way to use wall is very similar to platform
		//you send those thing in , and the program will do everything for you
		//the only thing diffrent is~~~~~~~ this is streat instead flat
 public:
		Graphics^* g;
		array<block^>^ blk;
		int blks;
		wall(int X, int Y, int blocks,Graphics^* gptr)//
		{
			blk = gcnew array<block^>(blocks);
			blks = blocks;
			g = gptr;
	        for(int i = 0; i != blks - 1;)
			{
				blk[i] = gcnew block(g ,X , Y + i++ * 10, "", true); 

			}








		}
		wall(wall^ wl)
		{



		}


	};


}
