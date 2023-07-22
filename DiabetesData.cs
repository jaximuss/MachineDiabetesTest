using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineDiabetesTest
{
    public class DiabetesData
    {
        [LoadColumn(0)] public float Glucose;
        [LoadColumn(0)] public float BloodPressure;
        //Add other feature columns here...
        [LoadColumn(0)] public float Diabetes;
    }
}
