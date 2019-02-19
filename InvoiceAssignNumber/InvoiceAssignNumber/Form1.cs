using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InvoiceAssignNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        #region 預設資訊
        private void Form1_Load(object sender, EventArgs e)
        {
            INIFile loadINI = new INIFile();
            string strINI, strShopCode, strTerminalCode;
            strINI = "D:\\xposTGNet\\PRSET.ini";
            txtDBLoc.Text = "D:\\xposTGNet\\SBX.mdb";
            btnQuickSetting.Select();

            if (System.IO.File.Exists(strINI))
            {
                strShopCode = loadINI.GetINI("PRSET", "StoreID", strINI, "871030");
                strTerminalCode = loadINI.GetINI("PRSET", "McnID", strINI, "1");

                if (string.IsNullOrEmpty(strShopCode) || string.IsNullOrEmpty(strTerminalCode))
                {
                    txtShopCode.ReadOnly = false;
                    txtTerminalCode.ReadOnly = false;
                }
                else
                {
                    txtShopCode.Text = strShopCode;
                    txtTerminalCode.Text = strTerminalCode;
                }
            }
            else
            {
                txtShopCode.ReadOnly = false;
                txtTerminalCode.ReadOnly = false;
            }
        }
        #endregion

        /// <summary>
        /// 快速設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuickSetting_Click(object sender, EventArgs e)
        {
            string strPath = txtDBLoc.Text;
            string queryData = "";
            bool bln = false;
            List<string> colName = new List<string>();
            List<string> rowValuse = new List<string>();

            if (System.IO.File.Exists(strPath))
            {
                //若未填入店號及機號，填入預設值
                if (txtShopCode.Text == "")
                {
                    txtShopCode.Text = "871030";
                }
                if (txtTerminalCode.Text == "")
                {
                    txtTerminalCode.Text = "1";
                }

                //取得DB欄位及要插入DB的值
                colName = GetColumn();
                rowValuse = GetValues();

                try
                {
                    //操作DB
                    MDBOBJ CnOrd = new MDBOBJ(strPath);
                    CnOrd.OpenDB();

                    queryData = CnOrd.QueryData("電子發票配號", "流水序號");
                    if (queryData != "")
                    {
                        var result = MessageBox.Show("已有發票配號\n是否要刪除舊資料?", "", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            CnOrd.DeleteData("電子發票配號");
                            CnOrd.InsertData("電子發票配號", colName, rowValuse);
                            CnOrd.CloseDB();
                            CnOrd.Dispose();

                            DialogResult dr = MessageBox.Show("設定完成\n按下確認後，自動開啟POS程式", "提示", MessageBoxButtons.OKCancel);
                            if (dr == DialogResult.OK)
                            {
                                try
                                {
                                    //開啟POS程式
                                    System.Diagnostics.Process.Start("D:\\xposTGNet\\xposTGNet.exe");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("開啟POS失敗\n" + ex.ToString());
                                }
                                finally
                                {
                                    Application.Exit();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("設定失敗");
                        }
                    }
                    else
                    {
                        CnOrd.InsertData("電子發票配號", colName, rowValuse);
                        CnOrd.CloseDB();
                        CnOrd.Dispose();

                        DialogResult dr = MessageBox.Show("設定完成\n按下確認後，自動開啟POS程式","提示", MessageBoxButtons.OKCancel);
                        if(dr == DialogResult.OK)
                        {
                            try
                            {
                                //開啟POS程式
                                System.Diagnostics.Process.Start("D:\\xposTGNet\\xposTGNet.exe");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("開啟POS失敗\n" + ex.ToString());
                            }
                            finally
                            {
                                Application.Exit();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("設定失敗\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("找不到DB");
            }
        }

        private List<string> GetColumn()
        {
            List<string> name = new List<string>();

            name.Add("流水序號");
            name.Add("分店代號");
            name.Add("收銀機別");
            name.Add("起始月份");
            name.Add("結束月份");
            name.Add("發票起號");
            name.Add("發票訖號");
            name.Add("配號方式");
            name.Add("目前使用號");
            name.Add("使用狀態");
            name.Add("同步");

            return name;
        }

        private List<string> GetValues(string s1 = "", string s2 = "")
        {
            int intDate;
            string strPath, strShopCode, strTerminalCode, startMonth, endMonth;
            List<string> values = new List<string>();
            INIFile loadINI = new INIFile();
            DateTime date;

            strPath = "D:\\xposTGNet\\SBX.mdb";
            strShopCode = txtShopCode.Text;
            strTerminalCode = txtTerminalCode.Text;

            MDBOBJ CnOrd = new MDBOBJ(strPath);
            CnOrd.OpenDB();
            date = DateTime.Parse(CnOrd.QueryData("本班紀錄", "本班日期"));
            intDate = date.Month;
            CnOrd.CloseDB();
            CnOrd.Dispose();

            if ((intDate % 2) == 0)
            {
                startMonth = date.AddMonths(-1).ToString("yyyy/MM");
                endMonth = date.ToString("yyyy/MM");
            }
            else
            {
                startMonth = date.ToString("yyyy/MM");
                endMonth = date.AddMonths(+1).ToString("yyyy/MM");
            }
            values.Add("1");
            values.Add(strShopCode);
            values.Add(strTerminalCode);
            values.Add(startMonth);
            values.Add(endMonth);
            if (s1 != "")
            {
                values.Add(s1);
            }
            else
            {
                values.Add("XX" + strTerminalCode + "0000001");
            }
            if (s2 != "")
            {
                values.Add(s2);
            }
            else
            {
                values.Add("XX" + strTerminalCode + "9999999");
            }
            values.Add("1");
            values.Add("0");
            values.Add("1");
            values.Add("Y");

            return values;
        }

        /// <summary>
        /// 自訂字軌設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            int txtLengh1, txtLengh2;
            string txtBox1, txtBox2;
            txtLengh1 = textBox1.Text.Length;
            txtLengh2 = textBox2.Text.Length;

            //判斷輸入的字軌是否有10碼
            if (txtLengh1 == 10 && txtLengh2 == 10)
            {
                string strPath = txtDBLoc.Text;
                string queryData = "";
                List<string> colName = new List<string>();
                List<string> rowValuse = new List<string>();

                txtBox1 = textBox1.Text;
                txtBox2 = textBox2.Text;

                if (System.IO.File.Exists(strPath))
                {
                    //若未填入店號及機號，填入預設值
                    if (txtShopCode.Text == "")
                    {
                        txtShopCode.Text = "871030";
                    }
                    if (txtTerminalCode.Text == "")
                    {
                        txtTerminalCode.Text = "1";
                    }

                    //取得DB欄位及要插入DB的值
                    colName = GetColumn();
                    rowValuse = GetValues(txtBox1, txtBox2);

                    try
                    {
                        //操作DB
                        MDBOBJ CnOrd = new MDBOBJ(strPath);
                        CnOrd.OpenDB();

                        queryData = CnOrd.QueryData("電子發票配號", "流水序號");
                        if (queryData != "")
                        {
                            var result = MessageBox.Show("已有發票配號/n是否要刪除舊資料?", "", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                CnOrd.DeleteData("電子發票配號");
                                CnOrd.InsertData("電子發票配號", colName, rowValuse);
                                CnOrd.CloseDB();
                                CnOrd.Dispose();

                                DialogResult dr = MessageBox.Show("設定完成\n按下確認後，自動開啟POS程式", "提示", MessageBoxButtons.OKCancel);
                                if (dr == DialogResult.OK)
                                {
                                    try
                                    {
                                        //開啟POS程式
                                        System.Diagnostics.Process.Start("D:\\xposTGNet\\xposTGNet.exe");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("開啟POS失敗\n" + ex.ToString());
                                    }
                                    finally
                                    {
                                        Application.Exit();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("設定失敗");
                            }
                        }
                        else
                        {
                            CnOrd.InsertData("電子發票配號", colName, rowValuse);
                            CnOrd.CloseDB();
                            CnOrd.Dispose();

                            DialogResult dr = MessageBox.Show("設定完成\n按下確認後，自動開啟POS程式", "提示", MessageBoxButtons.OKCancel);
                            if (dr == DialogResult.OK)
                            {
                                try
                                {
                                    //開啟POS程式
                                    System.Diagnostics.Process.Start("D:\\xposTGNet\\xposTGNet.exe");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("開啟POS失敗\n" + ex.ToString());
                                }
                                finally
                                {
                                    Application.Exit();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("設定失敗\n" + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("找不到DB");
                }
            }
            else
            {
                MessageBox.Show("字軌輸入錯誤\n範例:XX00000001");
            }
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            string strPath;

            if (file.ShowDialog() == DialogResult.OK)
            {
                strPath = file.FileName;
                txtDBLoc.Text = Path.GetFullPath(strPath);
            }
        }
    }
}
