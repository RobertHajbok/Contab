using System.Collections.Generic;
using System.Windows.Forms;

namespace Contab
{
    public partial class ChartForm : Form
    {
        public ChartForm(IList<Operation> operations)
        {
            InitializeComponent();
            crt_Operations.DataSource = operations;
        }
    }
}
