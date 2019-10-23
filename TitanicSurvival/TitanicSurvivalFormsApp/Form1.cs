using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.ML;
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

            ModelOutput result;

            string modelFile = @"C:\MyFolder\Labs\MLnet\MLNetLearningRepo\TitanicSurvival\TitanicSurvivalML.Model\bin\Debug\netstandard2.0\MLModel.zip";
            MLContext mlContext = new MLContext();


            using (var file = File.OpenRead(modelFile))
            {
                ITransformer model = mlContext.Model.Load(file, out DataViewSchema schema);
                var engine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
                result = engine.Predict(inputData);
            }

            // Make a single prediction on the sample data and print results
            // ModelOutput predictionResult = ConsumeModel.Predict(inputData);
            //ModelOutput predictionResult = ConsumeModel.Predict(inputData);
            //textBox1.Text = predictionResult.Prediction.ToString();

            textBox1.Text = result.Prediction.ToString();
        }
    }
}
