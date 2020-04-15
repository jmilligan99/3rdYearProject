using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RoboticsProjectGUI
{
    public partial class Form1 : Form
    {

        Boolean isConnected;
        String[] ports;

        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            foreach (string port in ports)
            {
                portSelect.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    portSelect.SelectedItem = ports[0];
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            greenButtonBack.Visible = false;
            redButtonBack.Visible = false;
            orangeButtonBack.Visible = false;
            blueButtonBack.Visible = false;
            yellowButtonBack.Visible = false;
            whiteButtonBack.Visible = false;
            readyDispense.Text = "Ready to dispense: ";
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void clearButtonClick()
        {
            greenButtonBack.Visible = false;
            redButtonBack.Visible = false;
            orangeButtonBack.Visible = false;
            blueButtonBack.Visible = false;
            yellowButtonBack.Visible = false;
            whiteButtonBack.Visible = false;
        }

        private void dispenseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected)
                {
                    dispense();
                }
                
            }
            catch
            {

            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clearButtonClick();
            greenButtonBack.Visible = true;
            readyDispense.Text = "Ready to dispense: Green";
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clearButtonClick();
            redButtonBack.Visible = true;
            readyDispense.Text = "Ready to dispense: Red";
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clearButtonClick();
            blueButtonBack.Visible = true;
            readyDispense.Text = "Ready to dispense: Blue";
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clearButtonClick();
            orangeButtonBack.Visible = true;
            readyDispense.Text = "Ready to dispense: Orange";
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            clearButtonClick();
            whiteButtonBack.Visible = true;
            readyDispense.Text = "Ready to dispense: White";
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clearButtonClick();
            yellowButtonBack.Visible = true;
            readyDispense.Text = "Ready to dispense: Yellow";
        }

        private void maintenanceButton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialDataIn(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }

        private void connectArduino()
        {
            try
            {
                isConnected = true;
                string selectedPort = portSelect.GetItemText(portSelect.SelectedItem);
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                port.Write("#STAR\n");
            }
            catch
            {

            }
        }

        private void disconnectArduino()
        {
            isConnected = false;
            //port.Write("#LEDOFF\n");
            port.Write("#STOP\n");
            port.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            connectArduino();
        }

        private void portSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colourSelect()
        {
            if (isConnected)
            {

            }
            else
            {

            }
        }

        private void dispense()
        {
            if (greenButtonBack.Visible == true)
            {
                port.WriteLine("DISPENSE_GREEN");
            }
            else if(redButtonBack.Visible == true)
            {
                port.WriteLine("DISPENSE_RED");
            }
            else if(orangeButtonBack.Visible == true)
            {
                port.WriteLine("DISPENSE_ORANGE");
            }
            else if(blueButtonBack.Visible == true)
            {
                port.WriteLine("DISPENSE_BLUE");
            }
            else if(yellowButtonBack.Visible == true)
            {
                port.WriteLine("DISPENSE_YELLOW");
            }
            else if(whiteButtonBack.Visible == true)
            {
                port.WriteLine("DISPENSE_WHITE");
            }
        }

        private void closeArduino_Click(object sender, EventArgs e)
        {
            disconnectArduino();
        }
    }

    public partial class Form2 : Form
    {
        
    }
}
