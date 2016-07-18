using System.Windows.Forms;

namespace MyDataGridViewControl
{
    public partial class MyDataGridView : DataGridView
    {
        public MyDataGridView()
        {
            InitializeComponent();

            // http://msdn.microsoft.com/ja-jp/library/61fe4bte.aspx
            SetStyle(ControlStyles.ContainerControl, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
