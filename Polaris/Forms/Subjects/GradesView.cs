using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polaris.Forms.Subjects
{
    public partial class GradesView : Form
    {
        private string subText;
        private static GradesView grades = new GradesView();
        public GradesView()
        {
            InitializeComponent();
        }

        public GradesView(string text)
        {
            grades.subText = text;
            InitializeComponent();
        }
    }
}
