namespace Log4NetTest
{
    using System;
    using log4net;
    using log4net.Config;

    public class MyTest
    {
        private static readonly ILog MyLog = LogManager.GetLogger("Debug");

        public static void Main()
        {
            BasicConfigurator.Configure();

            string hello = null;

            MyLog.Warn("Program starts to execute code.");
            MyLog.Debug("Line 18 executed.");

            try
            {
                MyLog.Info("Try parse null:");
                int myInt = int.Parse(hello);
            }
            catch (ArgumentNullException ex)
            {
                MyLog.Error(ex.Message);
            }

            try
            {
                int zero = 0;
                MyLog.Info("Try divide integer by zero.");
                int testDevisionByZero = 1 / zero;
            }
            catch (DivideByZeroException ex)
            {
                MyLog.Error(ex.Message);
            }
        }
    }
}
