using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace After.Generic.Generic
{
    public class ClassControl
    {
        public float X = 0;
        public float x1 = 0;
        public float Y = 0;
        public float y1 = 0;

        public Control SetContol { get; set; }

        public void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        public void setControls(float newx, float newy, Control cons)
        {
            try
            {
                foreach (Control con in cons.Controls)
                {
                    string[] mytag = con.Tag.ToString().Split(':');
                    float a = Convert.ToSingle(mytag[0]) * newx;
                    con.Width = (int) a;
                    a = Convert.ToSingle(mytag[1]) * newy;
                    con.Height = (int) a;
                    a = Convert.ToSingle(mytag[2]) * newx;
                    con.Left = (int) a;
                    a = Convert.ToSingle(mytag[3]) * newy;
                    con.Top = (int) a;
                    float currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void ChangeDisplayVal(Control ctrl, string txt)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new Showdisplay(ChangeDisplayVal), ctrl, txt);
            }
            else
            {
                ctrl.Text = txt;
            }
        }

        private delegate void Showdisplay(Control ctrl, string txt);
    }

    internal class APIcls
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        //讀ini文件-String
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //讀ini文件-Int32
        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileInt(string section, string key, int returnValue, string filePath);

        [DllImport("User32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public static string rdiniStr(string fileName, string section, string key, string val)
        {
            StringBuilder sb = new StringBuilder(100);
            try
            {
                GetPrivateProfileString(section, key, "", sb, 100, fileName);
                return sb.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static int rdiniInt(string fileName, string section, string key, string val)
        {
            int irtn = 0;
            try
            {
                GetPrivateProfileInt(section, key, irtn, fileName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return irtn;
        }

        public static void writeIniFile(string fileName, string section, string key, string val)
        {
            long iRtn = 0;
            try
            {
                iRtn = WritePrivateProfileString(section, key, val, fileName);
            }
            catch (Exception ex)
            {
                throw new SystemException("write ini file error :\r\n  exception is " + ex.Message);
            }
        }
    }
}