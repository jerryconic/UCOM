using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap03
{
    class BMICalculator
    {
        private double _height, _weight;
        public string Status()
        {
            double bmi = _weight / _height / _height;
            if (bmi < 18.5)
                return $"BMI={bmi:0.00}, 體重過輕";
            else if (bmi < 24)
                return $"BMI={bmi:0.00}, 體重正常";
            else
                return $"BMI={bmi:0.00}, 體重過重";

        }

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="height">身高(cm)</param>
        /// <param name="weight">體重(kg)</param>
        public BMICalculator(double height, double weight)
        {
            _height = height/100;
            _weight = weight;
        }
    }
}
