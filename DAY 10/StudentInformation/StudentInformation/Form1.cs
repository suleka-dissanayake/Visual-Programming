using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   string RegNo=trno.Text;
            string indexNo = tinno.Text;
            string Name = tname.Text;
            int TVisualM=int.Parse(m1.Text);
            int TVisualC = int.Parse(c1.Text);
            int PVisualM = int.Parse(m2.Text);
            int PVisualC = int.Parse(c2.Text);
            int TCGM = int.Parse(m3.Text);
            int TCGC = int.Parse(c3.Text);
            int PCGM = int.Parse(m4.Text);
            int PCGC = int.Parse(c4.Text);

            Student1 s = new Student1(RegNo,indexNo,Name,TVisualM,TVisualC,TCGM,TCGC,PVisualM,PVisualC,PCGM,PCGC);

            string visualResult = s.Results(TVisualM, TVisualC, PVisualM, PVisualC);
            string cgResult = s.Results(TCGM, TCGC, PCGM, PCGC);
            double GPAVisual = s.GPA(visualResult);
            double GPACG=s.GPA(cgResult);
            int cV = TVisualC + PVisualC;
            int cC=TCGC + PCGC;
            double FinalGPAvalue = s.finalGPA(GPAVisual, cV, GPACG, cC);

            string year = cl.SelectedItem?.ToString();
            string semester = cs.SelectedItem?.ToString();

            // ✅ Clear listbox before printing (optional, if you want fresh details every time)
            li1.Items.Clear();

            // ✅ Print details line by line
            li1.Items.Add("Student Details:");
            li1.Items.Add("**************************************"); // separator line
            li1.Items.Add($"Name              : {Name}");
            li1.Items.Add($"RegNo             : {RegNo}");
            li1.Items.Add($"IndexNo           : {indexNo}");
            li1.Items.Add($"Year              : {year}");
            li1.Items.Add($"Semester          : {semester}");
            li1.Items.Add($"Visual Grade      : {visualResult}");
            li1.Items.Add($"Visual GPA        : {GPAVisual:F2}");
            li1.Items.Add($"CG Grade          : {cgResult:F2}");
            li1.Items.Add($"CG GPA            : {GPACG:F2}");
            li1.Items.Add($"Final GPA         : {FinalGPAvalue:F2}");
            li1.Items.Add("*****************************************"); // separator line




        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ✅ Clear textboxes
            trno.Clear();
            tinno.Clear();
            tname.Clear();
            m1.Clear();
            c1.Clear();
            m2.Clear();
            c2.Clear();
            m3.Clear();
            c3.Clear();
            m4.Clear();
            c4.Clear();
            li1.Items.Clear();

            // ✅ Reset combo boxes
            cl.SelectedIndex = -1;      // no selection
            cs.SelectedIndex = -1;  // no selection

        }
    }
}
