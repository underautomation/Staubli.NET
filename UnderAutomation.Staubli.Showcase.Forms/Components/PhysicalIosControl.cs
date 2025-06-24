using System.ComponentModel;
using System.Globalization;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class PhysicalIosControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public PhysicalIosControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(PhysicalIoState), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(PhysicalIoState), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(PhysicalIo), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(PhysicalIoAttribute), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(PhysicalAioAttribute), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(PhysicalDioAttribute), new TypeConverterAttribute(typeof(ObjectConverter)));
    }

    #region IUserControl
    public string Title => "Physical IOs";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion
    private void btnGetAllPhysicalIos_Click(object sender, EventArgs e)
    {
        PhysicalIo[] physicalIos = _controller.Soap.GetAllPhysicalIos();
        gridPhysicalIos.SelectedObject = physicalIos;
        gridPhysicalIos.ExpandAllGridItems();

    }

    private void btnReadIos_Click(object sender, EventArgs e)
    {
        string[] names = ioNamesToRead.Rows.OfType<DataGridViewRow>().Select(x => x.Cells[0].Value?.ToString()).Where(x => !string.IsNullOrEmpty(x)).ToArray();

        PhysicalIoState[] state = _controller.Soap.ReadIos(names);

        gridReadIos.SelectedObject = state;
        gridReadIos.ExpandAllGridItems();
    }

    private void btnWriteIos_Click(object sender, EventArgs e)
    {
        var names = new List<string>();
        var values = new List<double>();
        foreach (var row in ioToWrite.Rows.OfType<DataGridViewRow>())
        {
            var name = row.Cells[0].Value?.ToString();
            if (!string.IsNullOrEmpty(name) && double.TryParse(row.Cells[1].Value?.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
            {
                names.Add(name);
                values.Add(value);
            }
        }

        PhysicalIoWriteResponse[] responses = _controller.Soap.WriteIos(names.ToArray(), values.ToArray());

        gridWriteIos.SelectedObject = responses;
        gridWriteIos.ExpandAllGridItems();
    }

    private void ioToWrite_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != 1) return;

        ioToWrite.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = double.TryParse(ioToWrite.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), CultureInfo.InvariantCulture, out double value) ? null : "Not a float number";
    }

    private void ioToWrite_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
    {
        e.Row.Cells[1].Value = "0";
    }
}
