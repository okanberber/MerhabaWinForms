using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Bu metot sürükle bırak ile aşağıdaki yazmış olduğumuz kodları zaten otomatik bir şekilde yazıyor.
            Label lbl_murtaza = new Label();
            lbl_murtaza.Text = "Ben Murtaza Nasılsınız ?";
            lbl_murtaza.AutoSize = true;
            lbl_murtaza.Location = new Point(40, 100); // Point de bir nesnedir. bizden x,y koordinatlarını ister. Bu sayede label için lokasyon belirtebiliriz.
            this.Controls.Add(lbl_murtaza); // Ram üzerinde var edildi ancak henüz forma eklenmedi. Forma eklemek için bu kodu yazıyoruz. Form eklenenleri list olarak aldığından add komutu ile ekliyoruz.
        }
    }
}
