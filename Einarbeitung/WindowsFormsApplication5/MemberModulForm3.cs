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
    public partial class MemberModulForm3 : BasisModulForm
    {
        public MemberModulForm3()
        {
            InitializeComponent();
        }


        public override void load()
        {
            label1.Text = "Vor- und Nachname: " + Patient.VorName + " " + Patient.NachName;
        }

        public void ModulFormLoad(object sender, EventArgs e)
        {
            label1.Text = "Vor- und Nachname: " + Patient.VorName+" "+ Patient.NachName;
            //print(text);


            //label1.Text = " ID: " + patient.id + "\n "
            //                + "Geschlecht: " + patient.geschlecht + "\n "
            //                + "Vorname: " + patient.vorName + "\n "
            //                + "Nachname: " + patient.nachName + "\n "
            //                + "Geburtstag: " + patient.geburtstag.ToString("MM/dd/yyyy");

        }
    }
}
