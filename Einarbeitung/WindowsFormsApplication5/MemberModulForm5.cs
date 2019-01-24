﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class MemberModulForm5 : BasisModulForm
    {
        public MemberModulForm5()
        {
            InitializeComponent();
            speichern.Visible = false;
            verwerfen.Visible = false;
            textBox1.Visible = false;
            Closing1 = true;

        }

        public override void load()
        {
            label1.Text = " ID: " + Patient.Id + "\n "
                            + "Geschlecht: " + Patient.Geschlecht + "\n "
                            + "Vorname: " + Patient.VorName + "\n "
                            + "Nachname: " + Patient.NachName + "\n "
                            + "Geburtstag: " + Patient.Geburtstag.ToString("MM/dd/yyyy");
        }

        public void ModulFormLoad(object sender, EventArgs e)
        {
            load();
        }
    }
}
