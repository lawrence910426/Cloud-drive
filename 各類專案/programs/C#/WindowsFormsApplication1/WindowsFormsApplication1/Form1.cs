using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'databaseDataSet.資料表1' 資料表。您可以視需要進行移動或移除。
            this.資料表1TableAdapter.Fill(this.databaseDataSet.資料表1);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream s1 ;
            s1 = new FileStream("D:\aaa.txt", FileMode.OpenOrCreate);


            StreamWriter w1;
            w1 = new StreamWriter (s1) ;
            w1.Write("吳邦寧");
            w1.Flush();
            w1.Dispose ();



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

  
    

    
     

   }
}
