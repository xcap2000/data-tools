using CarpeDiem.DataTools.Tasks.Models;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Tasks.Views;

public partial class TaskView : UserControl
{
    public TaskView()
    {
        InitializeComponent();
    }

    public ITaskModel DataSource
    {
        set
        {
            idDisplayLabel.DataBindings.Add("Text", value, "ID");
        }
    }
}
