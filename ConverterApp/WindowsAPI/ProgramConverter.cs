namespace WindowsAPI
{
    internal static class ProgramConverter
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ConverterForm());
        }
    }
}