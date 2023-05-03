using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class WriteLogFile
    {

        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                FileStream logger = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter logwriter = new StreamWriter((Stream)logger);
                logwriter.WriteLine($"{DateTime.Now}: {strMessage}");
                logwriter.Close();
                logger.Close();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
    }


}
