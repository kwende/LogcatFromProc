using Java.IO;
using System;
using System.Text;

namespace LogcatViewer.Droid
{
    public class AndroidLogcat : ILogCat
    {
        public string GetLogcatOutput()
        {
            var process = Java.Lang.Runtime.GetRuntime().Exec("logcat -d");
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(process.InputStream));
            StringBuilder builder = new StringBuilder();
            string line;
            while ((line = bufferedReader.ReadLine()) != null)
            {
                builder.Append(line + "\n");
            }
            return builder.ToString(); 
        }
    }
}