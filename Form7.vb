Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting.ChartImageFormat
Imports System.Globalization

Public Class Form7

    Private Sub Camera_Click(sender As System.Object, e As System.EventArgs) Handles Camera.Click
        'Create a Directory
        My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\Image")
        Dim currentdate As Date = DateTime.Now
        Chart1.SaveImage(Directory.GetCurrentDirectory() + "\Image" + "\" + "TMWB2" + " - " + Form1.ComboBox1.Text + "_versus(" + currentdate.ToString("HH,mm,ss tt", CultureInfo.CreateSpecificCulture("en-us")) + ")" + ".bmp", Bmp)
    End Sub
End Class
