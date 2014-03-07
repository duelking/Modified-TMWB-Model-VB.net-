Imports System.IO
Imports System.Text

Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start(Directory.GetCurrentDirectory())
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim b(Form3.inputtxt.Items.Count.ToString(), 9) As String
        For z = 0 To Form3.year.Items.Count() - 1
            b(z, 0) = Form4.yyyymmm.Items.Item(z)
            b(z, 1) = Form4.PET_2.Items.Item(z)
            b(z, 2) = Form3.P.Items.Item(z)
            b(z, 3) = Form4.PPET.Items.Item(z)
            b(z, 4) = Form4.soil.Items.Item(z)
            b(z, 5) = Form4.ET.Items.Item(z)
            b(z, 6) = Form4.delQ.Items.Item(z)
            b(z, 7) = Form4.Q.Items.Item(z)
            b(z, 8) = Form4.baseflow.Items.Item(z)
            b(z, 9) = Form4.simR.Items.Item(z)
        Next
        Dim sw As StreamWriter
        'Dim file1 As New FileInfo(Directory.GetCurrentDirectory() + "\output_month.csv")
        Dim root As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All Files|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            root = saveFileDialog1.FileName
            sw = New StreamWriter(root, False, Encoding.Default)
            sw.WriteLine("Date,PET,P,P-PET,Soil Moisture,ET,∆Q,S,Gout,R")
            For i = 0 To Form3.year.Items.Count() - 1
                For j = 0 To 9
                    sw.Write(b(i, j))
                    sw.Write(",")
                Next
                sw.WriteLine()
            Next
            sw.Close()

        End If
    End Sub

End Class