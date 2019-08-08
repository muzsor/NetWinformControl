﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HZH_Controls.Forms
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public partial class FrmTemp1 : FrmBase
    {
        private string _frmTitle = "自定义窗体";
        /// <summary>
        /// 窗体标题
        /// </summary>
        [Description("窗体标题"), Category("自定义")]
        public string FrmTitle
        {
            get { return _frmTitle; }
            set
            {
                _frmTitle = value;
                btnBack1.BtnText = value;
            }
        }
        [Description("帮助按钮点击事件"), Category("自定义")]
        public event EventHandler BtnHelpClick;

        public FrmTemp1()
        {
            InitializeComponent();
        }

        private void btnBack1_btnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (BtnHelpClick != null)
                BtnHelpClick(sender, e);
        }
    }
}