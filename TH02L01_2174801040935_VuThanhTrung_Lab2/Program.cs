namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ChonChuongTrinh());
        }
    }
    // lớp cho bài 4
    [Serializable]
    public class HocVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public float DiemToan { get; set; }
        public float DiemVan { get; set; }
        public float DTB { get; set; }
    }
}