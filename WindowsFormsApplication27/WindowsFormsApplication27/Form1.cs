using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication27
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int dx, dy;
        Image img, imgPion,imgCal,imgNebun,imgTura,imgRege, imgRegina,imgPionN, imgCalN, imgNebunN, imgTuraN, imgRegeN, imgReginaN;
  
        Graphics g;
        List<Piesa> lista;//lista de piese
        int piesa_curenta;//ca sa stiu care este piesa curenta

       

        bool apasat;//daca sa apasat piesa
        void adauga_piese()
        {
            
           

            //pun piesele albe
            for (int i = 1; i < 9; i++)
            {
                lista.Add(new Pion(50 * i,100, 50, 50,imgPion));
            }

            for (int i = 1; i < 9; i++)
            {
                switch (i)
                {
                    case 1:
                        {

                            lista.Add(new Tura(50 * i, 50, 50, 50, imgTura));
                            break;
                        }
                    case 2:
                        {

                            lista.Add(new Cal(50 * i, 50, 50, 50, imgCal));
                            break;
                        }
                    case 3:
                        {

                            lista.Add(new Nebun(50 * i, 50, 50, 50, imgNebun));
                            break;
                        }
                    case 4:
                        {

                            lista.Add(new Rege(50 * i, 50, 50, 50, imgRege));
                            break;
                        }
                    case 5:
                        {

                            lista.Add(new Regina(50 * i, 50, 50, 50, imgRegina));
                            break;
                        }
                    case 6:
                        {

                            lista.Add(new Nebun(50 * i, 50, 50, 50, imgNebun));
                            break;
                        }
                    case 7:
                        {

                            lista.Add(new Cal(50 * i, 50, 50, 50, imgCal));
                            break;
                        }
                    case 8:
                        {

                            lista.Add(new Tura(50 * i, 50, 50, 50, imgTura));
                            break;
                        }


                }
            }
            //pun piesele negre
                for (int i = 1; i < 9; i++)
                {
                    lista.Add(new Pion(50 * i, 350, 50, 50, imgPionN));
                }

            for (int i = 1; i < 9; i++)
            {
                switch (i)
                {
                    case 1:
                        {

                            lista.Add(new Tura(50 * i, 400, 50, 50, imgTuraN));
                            break;
                        }
                    case 2:
                        {

                            lista.Add(new Cal(50 * i, 400, 50, 50, imgCalN));
                            break;
                        }
                    case 3:
                        {

                            lista.Add(new Nebun(50 * i, 400, 50, 50, imgNebunN));
                            break;
                        }
                    case 4:
                        {

                            lista.Add(new Rege(50 * i, 400, 50, 50, imgRegeN));
                            break;
                        }
                    case 5:
                        {

                            lista.Add(new Regina(50 * i, 400, 50, 50, imgReginaN));
                            break;
                        }
                    case 6:
                        {

                            lista.Add(new Nebun(50 * i, 400, 50, 50, imgNebunN));
                            break;
                        }
                    case 7:
                        {

                            lista.Add(new Cal(50 * i, 400, 50, 50, imgCalN));
                            break;
                        }
                    case 8:
                        {

                            lista.Add(new Tura(50 * i, 400, 50, 50, imgTuraN));
                            break;
                        }


                }
            }




        }

       

     

        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            imgPion = Image.FromFile("Resurse\\pion3.png");
            imgTura = Image.FromFile("Resurse\\tura.gif");
            imgCal = Image.FromFile("Resurse\\Cal.png");
            imgNebun = Image.FromFile("Resurse\\nebun3.png");
            imgRege = Image.FromFile("Resurse\\rege.png");
            imgRegina = Image.FromFile("Resurse\\regina.png");
            imgPionN = Image.FromFile("Resurse\\pionN.png");
            imgTuraN = Image.FromFile("Resurse\\turaN.png");
            imgCalN = Image.FromFile("Resurse\\calN.png");
            imgNebunN = Image.FromFile("Resurse\\nebunN2.png");
            imgRegeN = Image.FromFile("Resurse\\regeN.png");
            imgReginaN = Image.FromFile("Resurse\\reginaN.png");
            apasat = false;
            lista = new List<Piesa>();//lista cu piese
            DeseneazaTablaSah();
          
           // adauga_piese();
          
            p.Refresh();
        }

        

        void DeseneazaPiese()
        {  for(int i = 0; i < lista.Count; i++)
            {
                lista[i].deseneaza(g);
            }
            
        }

     
        void DeseneazaTablaSah() {
            Brush c1 = Brushes.Bisque;
            Brush c2 = Brushes.Brown;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            System.Drawing.Font f = new Font("Times New Roman", 13);
            int dx = img.Width / 10;
            int dy = img.Height / 10;
            g.Clear(Color.White);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    g.FillRectangle((i+j)%2==0?c1:c2,(i+1)*dx,(j+1)*dy,dx,dy);
            }

            for(int i = 0; i <= 8; i++) 
            {
                g.DrawLine(new Pen(Color.Black,2),dx, (i + 1 )* dy, 9*dx,( i + 1) * dy);
            }
            for (int i = 0; i < 8; i++)
            {
                g.DrawString(""+(char)(i+'a'), f,Brushes.Black, new Rectangle((i + 1) * dx, 9 * dy, dx, dy/2),sf);
                g.DrawString("" + (char)(i + '1'), f, Brushes.Black, new Rectangle(dx/2,(i+1)*dy,dx/2,dy), sf);
            }
            



        }
        public void Deseneaza()
        {
            DeseneazaTablaSah();
            DeseneazaPiese();
            Refresh();
        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

      

     
        

        private void p_MouseMove(object sender, MouseEventArgs e)
        {
            if (apasat)
            {
                //il misca
                lista[piesa_curenta].muta(e.X-25 , e.Y -25);
              Deseneaza();
                p.Cursor = Cursors.SizeAll;
              

            }

        }

     

        private void p_MouseDown(object sender, MouseEventArgs e)
        {  for (int i = lista.Count - 1; i >= 0; i--)
                if (lista[i].esteDeasupra(e.X, e.Y))
                {
                    //il prinde
                    apasat = true;
                    dx = e.X - lista[i].X;
                    dy = e.Y - lista[i].Y;
                    p.Cursor = Cursors.Hand;
                    piesa_curenta = i;
                    break;
                }
   


        }

        private void p_MouseUp(object sender, MouseEventArgs e)
        {
             //lasa in jos
           
            p.Cursor = Cursors.Default;
            apasat = false;
            //p.Cursor = Cursors.Help;
            if (lista.Count != 0)
            {
                lista[piesa_curenta].muta(e.X / 50 * 50, e.Y / 50 * 50);
                for (int i = lista.Count - 1; i >= 0; i--)
                {
                    if ((lista[i].esteDeasupra(e.X, e.Y)) && (i != piesa_curenta))
                    {
                        lista.RemoveAt(i);
                     
                    }
                }
                Deseneaza();

            }

          
        }

        //evenimentul Click la butonul joc nou
        private void joc_nou(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            DeseneazaTablaSah();
            lista.Clear();
            adauga_piese();
            Deseneaza();

        }
        //evenimentul click la butonul goleste tabla
        private void goleste_tabla(object sender, EventArgs e)
        {
            lista.Clear();
            DeseneazaTablaSah();
            p.Refresh();
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();//iese din aplicatie
        }

        private void Click_genereaza(object sender, EventArgs e)//genereaza piese din lista
        {

            if (comboBox1.Text == "PION ALB")
            {

                lista.Add(new Pion(450, 100, 50, 50, imgPion));
                Deseneaza();
                p.Refresh();


            }
            if (comboBox1.Text == "PION NEGRU")
            {

                lista.Add(new Pion(450, 110, 50, 50, imgPionN));
                Deseneaza();
                p.Refresh();

            }
            if (comboBox1.Text == "CAL ALB")
            {

                lista.Add(new Cal(450, 120, 50, 50, imgCal));
                Deseneaza();
                p.Refresh();


            }
            if (comboBox1.Text == "CAL NEGRU")
            {

                lista.Add(new Cal(450, 130, 50, 50, imgCalN));
                Deseneaza();
                p.Refresh();

            }
            if (comboBox1.Text == "NEBUN ALB")
            {

                lista.Add(new Pion(450, 140, 50, 50, imgNebun));
                Deseneaza();
                p.Refresh();


            }
            if (comboBox1.Text == "NEBUN NEGRU")
            {

                lista.Add(new Nebun(450, 150, 50, 50, imgNebunN));
                Deseneaza();
                p.Refresh();

            }
            if (comboBox1.Text == "TURA ALBA")
            {

                lista.Add(new Nebun(450, 160, 50, 50, imgTura));
                Deseneaza();
                p.Refresh();


            }
            if (comboBox1.Text == "TURA NEAGRA")
            {

                lista.Add(new Tura(450, 170, 50, 50, imgTuraN));
                Deseneaza();
                p.Refresh();

            }
            if (comboBox1.Text == "REGE ALB")
            {

                lista.Add(new Rege(450, 180, 50, 50, imgRege));
                Deseneaza();
                p.Refresh();


            }
            if (comboBox1.Text == "REGE NEGRU")
            {

                lista.Add(new Rege(450, 190, 50, 50, imgRegeN));
                Deseneaza();
                p.Refresh();

            }
            if (comboBox1.Text == "REGINA ALBA")
            {

                lista.Add(new Regina(450, 190, 50, 50, imgRegina));
                Deseneaza();
                p.Refresh();


            }
            if (comboBox1.Text == "REGINA NEAGRA")
            {

                lista.Add(new Regina(450, 200, 50, 50, imgReginaN));
                Deseneaza();
                p.Refresh();

            }



        }

    }
}
