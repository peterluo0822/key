﻿using EmrInfirce;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace EMRTESTWINDOW
{
    public partial class test : DevExpress.XtraEditors.XtraForm
    {
        public test()
        {
            InitializeComponent();
        }
        Assembly emr = null;
        UserControl uc = null;
        MethodInfo mthod = null;
        private void test_Load(object sender, EventArgs e)
        {
            try
            {
                string patNum = "0106713_1";
                changePat changpat = new changePat();
                int i = changpat.InitEmr("003322");
                tabPage1.Controls.Add(changpat.ChangePatient(patNum));
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }
    }
}