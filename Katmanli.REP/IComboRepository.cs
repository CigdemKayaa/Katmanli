using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katmanli.REP
{
    interface IComboRepository<T> where T : class, new()
    {

        ComboBox GetComboBox(ComboBox comboBox);
    }
}
