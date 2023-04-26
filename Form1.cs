using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_em_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //WHILE;
            int vezes = 0;
            while (vezes <= 100)
            {
                ListBox.Items.Add(vezes);
                vezes++;
            }
            // O exemplo de cima e este de baixo faz exatamente o mesmo efeito:
            //int vezes = 0;
            //while (vezes <= 100)
            //{
            //    ListBox.Items.Add(vezes++);
            //}

            //DO WHILE;
            //    int vezes = 0;
            //    do
            //    {
            //        ListBox.Items.Add(vezes++);

            //    } while (vezes <= 100);
            //}
        }
    }
}
