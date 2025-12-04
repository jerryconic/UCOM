using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RainDataViewModel
    {
        [Range(0, 2000)]
        public double M1 { get; set; }
        [Range(0, 2000)]
        public double M2 { get; set; }
        [Range(0, 2000)]
        public double M3 { get; set; }
        [Range(0, 2000)]
        public double M4 { get; set; }
        [Range(0, 2000)]
        public double M5 { get; set; }
        [Range(0, 2000)]
        public double M6 { get; set; }
        [Range(0, 2000)]
        public double M7 { get; set; }
        [Range(0, 2000)]
        public double M8 { get; set; }
        [Range(0, 2000)]
        public double M9 { get; set; }
        [Range(0, 2000)]
        public double M10 { get; set; }
        [Range(0, 2000)]
        public double M11 { get; set; }
        [Range(0, 2000)]
        public double M12 { get; set; }

        public double[] ToArray() =>
            new[] { M1, M2, M3, M4, M5, M6, M7, M8, M9, M10, M11, M12 };

        public static RainDataViewModel FromArray(double[] data)
        {
            return new RainDataViewModel
            {
                M1 = data.Length > 0 ? data[0] : 0,
                M2 = data.Length > 1 ? data[1] : 0,
                M3 = data.Length > 2 ? data[2] : 0,
                M4 = data.Length > 3 ? data[3] : 0,
                M5 = data.Length > 4 ? data[4] : 0,
                M6 = data.Length > 5 ? data[5] : 0,
                M7 = data.Length > 6 ? data[6] : 0,
                M8 = data.Length > 7 ? data[7] : 0,
                M9 = data.Length > 8 ? data[8] : 0,
                M10 = data.Length > 9 ? data[9] : 0,
                M11 = data.Length > 10 ? data[10] : 0,
                M12 = data.Length > 11 ? data[11] : 0
            };
        }
    }
}