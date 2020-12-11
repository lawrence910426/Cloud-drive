









#include "PostiveChara.h";
#pragma once;









namespace 洛克人 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Media;
	using namespace System::Threading;
	/// <summary>
	/// Form1 的摘要
	/// </summary>












	public ref class Form1 : public System::Windows::Forms::Form
	{
		
#pragma region notMyThing
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: 在此加入建構函式程式碼
			//
		}

	protected:
		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Panel^  bkgnd;
	private: System::Windows::Forms::Panel^  pChara;
	private: System::Windows::Forms::Timer^  chks;


	private: System::ComponentModel::IContainer^  components;

	protected: 

	private:
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->chks = (gcnew System::Windows::Forms::Timer(this->components));
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->bkgnd = (gcnew System::Windows::Forms::Panel());
			this->pChara = (gcnew System::Windows::Forms::Panel());
			this->bkgnd->SuspendLayout();
			this->SuspendLayout();
			// 
			// chks
			// 
			this->chks->Interval = 1;
			this->chks->Tick += gcnew System::EventHandler(this, &Form1::syncer_Tick);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(12, 12);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"button1";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			this->button1->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &Form1::Form1_KeyPress);
			// 
			// bkgnd
			// 
			this->bkgnd->BackColor = System::Drawing::Color::White;
			this->bkgnd->Controls->Add(this->pChara);
			this->bkgnd->Location = System::Drawing::Point(100, 10);
			this->bkgnd->Name = L"bkgnd";
			this->bkgnd->Size = System::Drawing::Size(1180, 768);
			this->bkgnd->TabIndex = 1;
			// 
			// pChara
			// 
			this->pChara->BackColor = System::Drawing::Color::Blue;
			this->pChara->Location = System::Drawing::Point(3, 3);
			this->pChara->Name = L"pChara";
			this->pChara->Size = System::Drawing::Size(40, 100);
			this->pChara->TabIndex = 0;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::Black;
			this->ClientSize = System::Drawing::Size(1356, 741);
			this->Controls->Add(this->bkgnd);
			this->Controls->Add(this->button1);
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"Form1";
			this->ShowIcon = false;
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->TransparencyKey = System::Drawing::Color::DimGray;
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			this->Shown += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &Form1::getFocus);
			this->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &Form1::Form1_KeyPress);
			this->bkgnd->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
#pragma endregion	
	private:
		 Graphics^ formG;
		 Graphics^ gp;
		 Graphics^ bkgndG;
	     pchara^ chara ;
		 testScene^ ts;
	         System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) //this is shown instead load
			 {
				
				 //ThreadStart^ ts = ;
				this->BringToFront();

				 formG = this->CreateGraphics();  
		         bkgndG = this->bkgnd->CreateGraphics();



				 //not good things
				 Graphics^ sceneOne = bkgndG;
                 ts = gcnew testScene(&sceneOne);
				 //


				 chara = gcnew pchara(ts);
				 //graphicLoad();
				 for(int i = 0; i != 50000;i++)
				 {

				 }
				  chks->Enabled = true;
			 }
			 System::Void getFocus(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) //paint instead get focus
			 {
				 graphicLoad();
			 }
			 void graphicLoad()
			 {
				 /*this->BringToFront();*/

				 /*formG = this->CreateGraphics();  
		         bkgndG = this->bkgnd->CreateGraphics();*/
				 
				 Graphics^ sceneOne = bkgndG;
				 testScene^ ts = gcnew testScene(&sceneOne);
				 /*platForm pf = gcnew platForm(10 ,600 ,100 ,&sceneOne);
                 wall wl = gcnew wall(10 ,0 ,100 ,&sceneOne);*/
				 



			 }
	         System::Void button1_Click(System::Object^  sender, System::EventArgs^  e)
			 { 
				
 	             /*   Graphics^ g;
                Pen^ p = gcnew Pen(Color::Red);   //建立一支紅色的筆
                g = this->CreateGraphics();         //取得畫布
                g->Clear(Color::Black);                //清除畫布
                g->DrawLine (p,10,20,1000,1000);
			    DrawLine(Color::Red,10,20,250,1000);*/
         

		/*		Color c = Color::Blue;
				DrawLine(&c,10,10,1500,200);*/
				
				// ; //= gcnew block(this->bkgnd->CreateGraphics(),10 * i,10 * i,"",true);
				////block^ bb[100];

                //for(int i = 0 ; i != 100; )
				//{
				//	block^ blk;
			 //    	b[i] = blk;
				//}
				
		//		for(int i = 0 ; i != 100; )
		//		{
		//			//block blk = gcnew block(10,10 * i,"",false);
		//	     	b[i] = gcnew block(&bkgndG, 10 * ++i, 600, "", true);//&bkgndG,
		//			//b[i]->g = &bkgndG;
		///*			bool havePath = false;
		//			b[i++]->draw(&havePath);*/
		//		}







			 }








			 
			
			System::Void Form1_KeyPress(System::Object^  sender, System::Windows::Forms::KeyEventArgs^  e) 
			 {
				 //switch(e->KeyValue)
				 //{
				 //case 'a':
					// 
     //                break;
				 //case 'w':

     //                break;
				 //case 's':

     //                break;
				 //case 'd':

					// break;
				 //case 'A':

					// break;
				 //case 'W':

					// break;
				 //case 'S':

					// break;
				 //case 'D':


					// break;

				 //}
			  /* *///char c = ;

				
                //char c = e->KeyValue;



				chara->keyDown(e->KeyValue);
			 }
			
         private: System::Void syncer_Tick(System::Object^  sender, System::EventArgs^  e) 
		 {
			 

			   Point pt = (Point)gcnew Point(chara->x , chara->y);
			   pChara->Location = pt;//(Point)
			   if(chara->redraw == true)
			   {
				  graphicLoad();
				  chara->redraw = false;


			   }


		 }
}; 
	/*
			 void DrawLine(Color* color,Int32* p1,Int32* p2,Int32* p3, Int32* p4)
			 {
				 Pen^ p = gcnew Pen(*color);
				 g->DrawLine (p,*p1,*p2,*p3,*p4);
				 delete p;
			 }
			 void DrawLine(Color* color,Int32 p1,Int32 p2,Int32 p3, Int32 p4)
			 {
				 Pen^ p = gcnew Pen(*color);
				 g->DrawLine (p,p1,p2,p3,p4);
				 delete p;
			 }
			 */
}

