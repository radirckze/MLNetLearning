using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML;
using TitanicSurvivalML.Model;

namespace TitanicSurvivalML.ConsoleApp
{
    public class ConsumeModelWrapper
    {

        public static ModelOutput Predict(ModelInput inputData)
        {
            return ConsumeModel.Predict(inputData);
        }

        public static string Test()
        {
            return "hello";
        }
    }
}
