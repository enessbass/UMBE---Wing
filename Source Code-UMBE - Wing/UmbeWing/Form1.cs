using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


namespace dd;

public partial class Form1 : Form
{
    public TextBox yoğunluk_giriş;
    public TextBox kanat_alani_giriş;
    public TextBox hiz_giriş;
    public TextBox ar_giriş;
    public TextBox açi_başlangiç_deger;
    public TextBox açi_bitiş_deger;
    public TextBox sifir_taşima_giriş;
    public TextBox taşima_eğrisi_eğimi_giriş;
    public TextBox zop_deger;
    public Label deneme;
    public Panel grafik_panel;

    public TextBox giriş_1;
    public TextBox giriş_2;

    public TextBox giriş_4;
    public TextBox giriş_3;

    public int diziboyutu;

    private DataGridView dataGridView;
    
    public Form1()
    {
        InitializeComponent();

        Panel ana_panel = new Panel();
        ana_panel.Size = new Size(960, 220);
        ana_panel.Location = new Point(20, 20);
        this.Controls.Add(ana_panel);
        ana_panel.BorderStyle = BorderStyle.FixedSingle;

        Button hesapla_butonu = new Button();
        hesapla_butonu.Text = "Hesapla";
        hesapla_butonu.Size = new Size(120, 40);
        hesapla_butonu.Location = new Point(440, 250);
        hesapla_butonu.Click += hesapla_butonu_tikla;
        this.Controls.Add(hesapla_butonu);

                       
                Label yoğunluk = new Label();
                yoğunluk.Text = "Yoğunluk (kg/m3)";
                yoğunluk.Size = new Size(150, 25);
                yoğunluk.Location = new Point(20, 40);
                yoğunluk.BorderStyle = BorderStyle.Fixed3D;
                yoğunluk.BackColor = Color.Beige;
                ana_panel.Controls.Add(yoğunluk);

                yoğunluk_giriş = new TextBox();
                yoğunluk_giriş.Size = new Size(150, 25);
                yoğunluk_giriş.Location = new Point(20, 80);
                ana_panel.Controls.Add(yoğunluk_giriş);

                Label kanat_alani = new Label();
                kanat_alani.Text = "Kanat Alanı (m2)";
                kanat_alani.Size = new Size(150, 25); 
                kanat_alani.Location = new Point(20, 120); 
                kanat_alani.BorderStyle = BorderStyle.Fixed3D;
                kanat_alani.BackColor = Color.Beige;
                ana_panel.Controls.Add(kanat_alani);

                kanat_alani_giriş = new TextBox();
                kanat_alani_giriş.Size = new Size(150, 25);
                kanat_alani_giriş.Location= new Point(20,160);
                ana_panel.Controls.Add(kanat_alani_giriş);

                Label hiz = new Label();
                hiz.Text = "Hız m/s"; 
                hiz.Size = new Size(150, 25); 
                hiz.Location = new Point(200, 40); 
                hiz.BorderStyle = BorderStyle.Fixed3D;
                hiz.BackColor = Color.Beige;
                ana_panel.Controls.Add(hiz);

                hiz_giriş = new TextBox();
                hiz_giriş.Size = new Size(150, 25);
                hiz_giriş.Location= new Point(200,80);
                ana_panel.Controls.Add(hiz_giriş);

                Label ar = new Label();
                ar.Text = "AR"; 
                ar.Size = new Size(150, 25); 
                ar.Location = new Point(200, 120); 
                ar.BorderStyle = BorderStyle.Fixed3D;
                ar.BackColor = Color.Beige;
                ana_panel.Controls.Add(ar);

                ar_giriş = new TextBox();
                ar_giriş.Size = new Size(150, 25);
                ar_giriş.Location= new Point(200,160);
                ana_panel.Controls.Add(ar_giriş);

                Label taşima_eğrisi_eğimi = new Label();
                taşima_eğrisi_eğimi.Text = "Taşıma Eğrisi Eğimi"; 
                taşima_eğrisi_eğimi.Size = new Size(150, 25); 
                taşima_eğrisi_eğimi.Location = new Point(380, 40); 
                taşima_eğrisi_eğimi.BorderStyle = BorderStyle.Fixed3D;
                taşima_eğrisi_eğimi.BackColor = Color.Beige;
                ana_panel.Controls.Add(taşima_eğrisi_eğimi);

                taşima_eğrisi_eğimi_giriş = new TextBox();
                taşima_eğrisi_eğimi_giriş.Size = new Size(150, 25);
                taşima_eğrisi_eğimi_giriş.Location= new Point(380,80);
                ana_panel.Controls.Add(taşima_eğrisi_eğimi_giriş);

                Label sifir_taşima = new Label();
                sifir_taşima.Text = "Sıfır Taşıma Hücüm Açısı"; 
                sifir_taşima.Size = new Size(150, 25); 
                sifir_taşima.Location = new Point(380, 120); 
                sifir_taşima.BorderStyle = BorderStyle.Fixed3D;
                sifir_taşima.BackColor = Color.Beige;
                ana_panel.Controls.Add(sifir_taşima);
                

                sifir_taşima_giriş = new TextBox();
                sifir_taşima_giriş.Size = new Size(150, 25);
                sifir_taşima_giriş.Location= new Point(380,160);
                ana_panel.Controls.Add(sifir_taşima_giriş);

                

                Panel alfa = new Panel();
                alfa.Size = new Size(400,180);
                alfa.Location = new Point(540,20);
                alfa.BorderStyle = BorderStyle.FixedSingle;
                ana_panel.Controls.Add(alfa);

                                   Label açi_başlangiç = new Label();
                                   açi_başlangiç.Text = "Başlangiç"; 
                                   açi_başlangiç.Size = new Size(150, 25); 
                                   açi_başlangiç.Location = new Point(20, 20); 
                                   açi_başlangiç.BorderStyle = BorderStyle.Fixed3D;
                                   açi_başlangiç.BackColor = Color.Beige;
                                   alfa.Controls.Add(açi_başlangiç);

                                   giriş_1 = new TextBox();
                                   giriş_1.Size = new Size(150, 25);
                                   giriş_1.Location= new Point(20,60);
                                   alfa.Controls.Add(giriş_1);

                                   Label açi_bitiş = new Label();
                                   açi_bitiş.Text = "bitiş"; 
                                   açi_bitiş.Size = new Size(150, 25); 
                                   açi_bitiş.Location = new Point(20, 100); 
                                   açi_bitiş.BorderStyle = BorderStyle.Fixed3D;
                                   açi_bitiş.BackColor = Color.Beige;
                                   alfa.Controls.Add(açi_bitiş);

                                   giriş_2 = new TextBox();
                                   giriş_2.Size = new Size(150, 25);
                                   giriş_2.Location= new Point(20,140);
                                   alfa.Controls.Add(giriş_2);
                                   
                                   Label zop = new Label();
                                   zop.Text = "Artiş"; 
                                   zop.Size = new Size(150, 25); 
                                   zop.Location = new Point(210, 20); 
                                   zop.BorderStyle = BorderStyle.Fixed3D;
                                   zop.BackColor = Color.Beige;
                                   alfa.Controls.Add(zop);

                                   giriş_3 = new TextBox();
                                   giriş_3.Size = new Size(150, 25);
                                   giriş_3.Location= new Point(210,60);
                                   alfa.Controls.Add(giriş_3);

                                   Label cd0 = new Label();
                                   cd0.Text = "cd0"; 
                                   cd0.Size = new Size(150, 25); 
                                   cd0.Location = new Point(210, 100); 
                                   cd0.BorderStyle = BorderStyle.Fixed3D;
                                   cd0.BackColor = Color.Beige;
                                   alfa.Controls.Add(cd0);

                                   giriş_4 = new TextBox();
                                   giriş_4.Size = new Size(150, 25);
                                   giriş_4.Location= new Point(210,140);
                                   alfa.Controls.Add(giriş_4);
                                   
                                   

                                   

                          
                
            




                 


        grafik_panel = new Panel();
        grafik_panel.Size = new Size(470,500);
        grafik_panel.Location = new Point(20,300);
        this.Controls.Add(grafik_panel);
        grafik_panel.BorderStyle = BorderStyle.FixedSingle;

        grafik_panel.Paint += new PaintEventHandler(grafik_Paint);

                            


        Panel sekil_panel = new Panel();
        sekil_panel.Size = new Size(470,500);
        sekil_panel.Location = new Point(510,300);
        this.Controls.Add(sekil_panel);
        sekil_panel.BorderStyle = BorderStyle.FixedSingle;
                           
                              Panel kanat = new Panel();
                              kanat.Size = new Size(380,200);
                              kanat.Location = new Point(50,150);
                              kanat.BackColor = Color.FromArgb(0, 255, 255, 255);           //TAMAMEN TRANSPARAN YAPTI PANELİ //
                              sekil_panel.Controls.Add(kanat);

                              sekil_panel.Paint += new PaintEventHandler(panel_Paint);

                                              PictureBox resim = new PictureBox();
                                              resim.Image = Image.FromFile(@"C:\Users\enes1\Desktop\UCK2243\kanat.png");
                                              resim.SizeMode = PictureBoxSizeMode.AutoSize;
                                              resim.Location = new Point(50,150);
                                              resim.Dock = DockStyle.Fill; 
                                              kanat.Controls.Add(resim);

                                              
       
         

        Panel sonuc_panel = new Panel();
        sonuc_panel.Size = new Size(960, 360);
        sonuc_panel.Location = new Point(20, 820);
        this.Controls.Add(sonuc_panel);
        sonuc_panel.BorderStyle = BorderStyle.FixedSingle;

                   MenuStrip menubar = new MenuStrip();
                   ToolStripMenuItem bos = new ToolStripMenuItem("      ");
                   ToolStripMenuItem cl = new ToolStripMenuItem("           Cl            ");
                   ToolStripMenuItem cd = new ToolStripMenuItem("          Cd            ");
                   ToolStripMenuItem cdi = new ToolStripMenuItem("           Cdi          ");
                   ToolStripMenuItem Lift = new ToolStripMenuItem("          Lift           ");
                   ToolStripMenuItem Drag = new ToolStripMenuItem("         Drag         ");
                   ToolStripMenuItem clcd = new ToolStripMenuItem("        Cl/Cd          ");
                   ToolStripMenuItem LD = new ToolStripMenuItem("         L/D           ");

                   menubar.Items.Add(bos);
                   menubar.Items.Add(cl);
                   menubar.Items.Add(cd);
                   menubar.Items.Add(cdi);
                   menubar.Items.Add(Lift);
                   menubar.Items.Add(Drag);
                   menubar.Items.Add(clcd);
                   menubar.Items.Add(LD);

                   sonuc_panel.Controls.Add(menubar);

                   
                   menubar.Dock = DockStyle.Top;
                   menubar.Height = 136;
                   menubar.BackColor = Color.Gray;

                   dataGridView = new DataGridView();
                   dataGridView.Dock = DockStyle.Fill;
      

                    // DataGridView ayarları
                    dataGridView.ColumnCount = 7; // Sütun sayısı
                    dataGridView.Columns[0].Name = "cl";
                    dataGridView.Columns[1].Name = "cdi";
                    dataGridView.Columns[2].Name = "cd";
                    dataGridView.Columns[3].Name = "liftt";
                    dataGridView.Columns[4].Name = "dragg";
                    dataGridView.Columns[5].Name = "clcd";
                    dataGridView.Columns[6].Name = "ld";

                    dataGridView.Columns[0].Width = 129; 
                    dataGridView.Columns[1].Width = 129;
                    dataGridView.Columns[2].Width = 129; 
                    dataGridView.Columns[3].Width = 129; 
                    dataGridView.Columns[4].Width = 129; 
                    dataGridView.Columns[5].Width = 130;
                    dataGridView.Columns[6].Width = 130; 

                          
                   
                    
                

                    // Form'a DataGridView ekle
                    sonuc_panel.Controls.Add(dataGridView);

                    
      
                     


        
    }

    /** GRAFİK VE ÇİZGİLER BÖLÜMÜ  **/
    private void grafik_Paint(object sender, PaintEventArgs e)
        {
            Graphics çizel = e.Graphics;
            Pen kalem = new Pen(Color.Gray, 2);

            çizel.DrawLine(kalem, 0, 360, 500, 360); // X
            çizel.DrawLine(kalem, 180, 0, 180, 500); // Y 

            Pen eğriKalem = new Pen(Color.Blue, 2);
            Point[] eğriNoktalari = new Point[40];

            for (int i = 0; i < 40; i++)
            {
             
            }

            çizel.DrawCurve(eğriKalem, eğriNoktalari);  

        }
    private void panel_Paint(object sender, PaintEventArgs e)
        {
            // Grafik nesnesi oluştur
            Graphics g = e.Graphics;

            // Grafik çizimi için kalem oluştur
            Pen pen = new Pen(Color.Gray, 2);

            g.DrawLine(pen, 0, 240, 500, 240); // X eksenini çiz
            g.DrawLine(pen, 180, 0, 180, 500); // Y eksenini çiz

            

        }    
        

    /** BUTON OLAYLARI  **/    
    private void hesapla_butonu_tikla(object sender, EventArgs e)
        {
            try
            {
                var abd = Convert.ToDouble(giriş_1.Text, CultureInfo.InvariantCulture);
                var abid = Convert.ToDouble(giriş_2.Text, CultureInfo.InvariantCulture);
                var art = Convert.ToDouble(giriş_3.Text, CultureInfo.InvariantCulture);

                var tee = Convert.ToDouble(taşima_eğrisi_eğimi_giriş.Text, CultureInfo.InvariantCulture);
                var stha = Convert.ToDouble(sifir_taşima_giriş.Text, CultureInfo.InvariantCulture);

                var v = Convert.ToDouble(hiz_giriş.Text, CultureInfo.InvariantCulture);
                var ro = Convert.ToDouble(yoğunluk_giriş.Text, CultureInfo.InvariantCulture);
                var s = Convert.ToDouble(kanat_alani_giriş.Text, CultureInfo.InvariantCulture);
                var AR = Convert.ToDouble(ar_giriş.Text, CultureInfo.InvariantCulture);
                var cd0 = Convert.ToDouble(giriş_4.Text, CultureInfo.InvariantCulture);

                int diziboyutu = (int)((abid - abd) / art) + 1; 

                // Dizileri tanımlayın
                 

                    int index = 0; // İndeks sayacı

                for (double i = abd; i < abid; i += art)
                {   
                    var cl = tee * (i + stha);
                    var cdi = Math.Pow(cl, 2)/ ( Math.PI * AR * 0.96);
                    var cd = cd0 + cdi;
                    var liftt = 0.5 * ro *v * v *s *cl;
                    var dragg = 0.5 * ro *v * v *s *cd;
                    var cdcd = cl/cd;
                    var ld = liftt/dragg;

                    
                    string[] satir = new string[]
                    {
                    cl.ToString(),
                    cdi.ToString(),
                    cd.ToString(),
                    liftt.ToString(),
                    dragg.ToString(),
                    cdcd.ToString(),
                    ld.ToString()
                    };

                    dataGridView.Rows.Add(satir);
    
                    index++; // Bir sonraki indekse geçin
                 
                    
                    /*Label yeniLabel = new Label();
                    yeniLabel.Text = cd.ToString("F4"); 
                    yeniLabel.Size = new Size(150, 25);
                    yeniLabel.Location = new Point(20, 50 + (int)(i * 30));
                    
                    yeniLabel.BorderStyle = BorderStyle.Fixed3D;
                    yeniLabel.BackColor = Color.Beige;
                    grafik_panel.Controls.Add(yeniLabel); 
                    */

                }      
                
   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            
        }
        
        
}

