using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace InvoiceAssignNumber
{
    class INIFile
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 讀取ini資訊
        /// </summary>
        /// <param name="Section">區段名稱</param>
        /// <param name="KeyName">設定名稱</param>
        /// <param name="IniFileLoc">檔案位置</param>
        /// <param name="strDefault">預設空值</param>
        /// <returns></returns>
        public string GetINI(string Section, string KeyName, string IniFileLoc , string strDefault = "")
        {
            if (System.IO.File.Exists(IniFileLoc))
            {
                StringBuilder sbResult = null;

                try
                {
                    sbResult = new StringBuilder(255);

                    GetPrivateProfileString(Section, KeyName, "", sbResult, 255, IniFileLoc);

                    return (sbResult.Length > 0) ? sbResult.ToString() : strDefault;
                }
                catch
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
