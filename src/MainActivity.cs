using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;

namespace VKR
{
    public partial class MainActivity : Form
    {
        
       SerialPort serialPort1= new SerialPort();
        String nameAdress =  "Локомотив 1";
        String nameAdress2 = "Локомотив 2";
        String nameCabin = "А";
        String nameCabin2 = "Б";
        static int i = 0;
        static int pos = 0;
        bool flag = true;

        public void FindPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                //Закинули строковый массив портов в Комбобокс
                comboBoxCOM.Items.Add(port);
            }
        }

        public MainActivity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            FindPorts();
            comboBoxAdress.Items.Add(nameAdress);
            comboBoxAdress.Items.Add(nameAdress2);
            comboBoxCabin.Items.Add(nameCabin);
            comboBoxCabin.Items.Add(nameCabin2);
            timer1.Start();

        }
        
        /*
        private void comboBoxCabin_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort.Serial
        }
        */

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCOM.Text == String.Empty) this.labelStatus1.Text = "Порт не выбран";
              else
              {
                try
                {
                    if (!this.serialPort1.IsOpen)
                    {
                        this.serialPort1.PortName = this.comboBoxCOM.Text;
                        this.serialPort1.BaudRate = 9600;
                        this.serialPort1.Open();
                        this.buttonConnect.Enabled = false;
                        this.comboBoxCOM.Enabled = false;
                        this.labelStatus1.Text = "Connected";
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    this.labelStatus1.Text = "Error";
                }


              }
        }
        //
        //  ********************КОННЕКТ*************************
        //
        //Выбираем адресс
        private void comboBoxAdress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdress.SelectedItem == nameAdress) serialPort1.Write("11");
            else serialPort1.Write("12");
            this.labelStatus1.Text = "Выберите кабину управления";
        }
        //Выбираем кабину
        private void comboBoxCabin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelStatus1.Text = "Направления движения не выбрано";
        }
        // 
        // ********************************РЕВЕРСОР**********************
        // 
        //Кнопка ВПЕРЕД реверсора
        private void buttonGo_Click(object sender, EventArgs e)
        {
            
        }
        
        //Кнопка НАЗАД реверсора 
        private void buttonBack_Click(object sender, EventArgs e)
        {
           
        }
        //Кнопка нейтрали реверсора
        private void buttonNeutral_Click(object sender, EventArgs e)
        {
            this.labelReversorNum.Text = "Neutral";
            this.labelStatus1.Text = "Choose side of moving";

        }


        // 
        //************************************КОНТРОЛЛЕР****************************
        //
        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            if (i <= 14)
            {
                this.labelModeNum.Text = "ТЯГА";
                i++;
                pos = i + 20;
                this.labelStatus1.Text = "Режим тяга включен";
                this.labelPositionNum.Text = i.ToString();
                serialPort1.Write(pos.ToString());

            }
        }

        private void buttonMinus_Click_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                pos = i + 20;
                this.labelPositionNum.Text = i.ToString();
                this.labelStatus1.Text = "Режим тяги включен";
                serialPort1.Write(pos.ToString());
                if (i == 0) { this.labelModeNum.Text = "Хол.ход"; this.labelStatus1.Text = "Готов к началу движения"; }
                   
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = VKR.Properties.Resources.buttonPressedLast;
            pictureBox2.Image = VKR.Properties.Resources.button1;
            this.labelReversorNum.Text = "Вперёд";
            this.labelStatus1.Text = "Готов к началу движения";
            if (this.comboBoxCabin.SelectedItem == "A") serialPort1.Write("40");
            else serialPort1.Write("41");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = VKR.Properties.Resources.buttonPressedLast;
            pictureBox1.Image = VKR.Properties.Resources.button1;
            this.labelReversorNum.Text = "Nazad";
            this.labelStatus1.Text = "Ready to start moving";
            if (this.comboBoxCabin.SelectedItem == "A") serialPort1.Write("41");
            else serialPort1.Write("40");

        }

        private void buttonMinus_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonPlus_MouseDown(object sender, MouseEventArgs e)
        {
           
               
            
        }

        private void  buttonPlus_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = VKR.Properties.Resources.buttonPressedLast;
            pictureBox4.Image = VKR.Properties.Resources.button1;
            serialPort1.Write("45");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = VKR.Properties.Resources.buttonPressedLast;
            pictureBox3.Image = VKR.Properties.Resources.button1;
            serialPort1.Write("46");
        }

        private void buttonNull_Click(object sender, EventArgs e)
        {
            i = 0;
            pos = i + 20;
            this.labelPositionNum.Text = i.ToString();
            serialPort1.Write(pos.ToString());
            this.labelModeNum.Text = "Хол.ход";
            this.labelStatus1.Text = "Готов к началу движения";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == true) { pictureBox5.Image = VKR.Properties.Resources.LIGHTS2; flag = false; }
            else { pictureBox5.Image = VKR.Properties.Resources.LIGHTS; flag = true; }
        }

       
    }
}
