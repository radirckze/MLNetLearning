// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace TitanicSurvivalML.Model
{
    public class ModelInput
    {
        [ColumnName("Survived"), LoadColumn(0)]
        public bool Survived { get; set; }


        [ColumnName("Pclass"), LoadColumn(1)]
        public float Pclass { get; set; }


        [ColumnName("Gender Normalized"), LoadColumn(2)]
        public float Gender_Normalized { get; set; }


        [ColumnName("Age Notmalized"), LoadColumn(3)]
        public float Age_Notmalized { get; set; }


        [ColumnName("Fare Notmalized"), LoadColumn(4)]
        public float Fare_Notmalized { get; set; }


    }
}
