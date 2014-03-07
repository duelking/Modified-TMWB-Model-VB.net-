Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting.ChartImageFormat
Imports System.Globalization

Public Class Form8

    Private Sub Camera_Click(sender As System.Object, e As System.EventArgs) Handles Camera.Click
        'Create a Directory
        My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\Image")
        Dim currentdate As Date = DateTime.Now
        If Form6.Label2.Text = "X - Pike" Then
            Chart1.SaveImage(Directory.GetCurrentDirectory() + "\Image" + "\" + "Pike" + "(" + currentdate.ToString("HH,mm,ss tt", CultureInfo.CreateSpecificCulture("en-us")) + ")" + ".bmp", Bmp)
        Else
            Chart1.SaveImage(Directory.GetCurrentDirectory() + "\Image" + "\" + Form6.Label2.Text + "(" + currentdate.ToString("HH,mm,ss tt", CultureInfo.CreateSpecificCulture("en-us")) + ")" + ".bmp", Bmp)
        End If
    End Sub
End Class