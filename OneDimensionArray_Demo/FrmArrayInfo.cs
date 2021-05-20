using System;
using System.Windows.Forms;

namespace OneDimensionArray_Demo
{
    public partial class FrmArrayInfo : Form
    {
        public FrmArrayInfo()
        {
            InitializeComponent();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            string[] StudentName = new string[6];
            int[] StudentMark = new int[6];

            StudentName[1] = "Mary";
            StudentMark[1] = 80;
            StudentName[2] = "Jim";
            StudentMark[2] = 87;
            StudentName[3] = "Frank";
            StudentMark[3] = 68;
            StudentName[4] = "Karen";
            StudentMark[4] = 77;
            StudentName[5] = "Peter";
            StudentMark[5] = 56;

            LstInfo.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                LstInfo.Items.Add(StudentName[i] + "   " + StudentMark[i].ToString());
            }
        }

        private void Display(string[] n, int[] m, int u)
        {
            LstInfo.Items.Clear();
            for (int i = 1; i <= u; i++)
            {
                LstInfo.Items.Add(n[i] + "\t" + m[i].ToString());
            }
        }

        private void btnDirect_Click(object sender, EventArgs e)
        {
            string[] StudentName = { "", "Mary", "Jim", "Frank", "Karen", "Peter" };
            int[] StudentMark = { 0, 80, 87, 68, 77, 45 };

            LstInfo.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                LstInfo.Items.Add(StudentName[i] + "\t  " + StudentMark[i].ToString());
            }
        }
    }
}