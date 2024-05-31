using System;
namespace BasicOOP_Practice2
{
	public class Rectagle
	{
        private double chieuDai;
        private double chieuRong;

        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }

		public object MyProperty { get; set; }
		public Rectagle()
		{
		}
		public double DienTich()
		{
			return chieuDai * chieuRong;
		}
	}
}

