using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TitanicSurvivalML.Model;

namespace TitanicSurvivalFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ModelInput inputData = new ModelInput();
            inputData.Pclass = 1;
            inputData.Gender_Normalized = 2;
            inputData.Age_Notmalized = 5;
            inputData.Fare_Notmalized = 5;

            // Make a single prediction on the sample data and print results
            // ModelOutput predictionResult = ConsumeModel.Predict(inputData);
            //ModelOutput predictionResult = ConsumeModelWrapper.Predict(inputData);

            textBox1.Text = "bla";
        }
    }
}
