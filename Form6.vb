Imports System.IO
Imports System.Text

Public Class Form6
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start(Directory.GetCurrentDirectory())
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim b(Form4.year.Items.Count.ToString(), 4) As String
        For z = 0 To Form4.year.Items.Count() - 1
            b(z, 0) = Form4.year.Items.Item(z)
            b(z, 1) = Form4.yPET_2.Items.Item(z)
            b(z, 2) = Form4.yP.Items.Item(z)
            b(z, 3) = Form4.yET.Items.Item(z)
            b(z, 4) = Form4.yR.Items.Item(z)

        Next
        Dim sw As StreamWriter
        'Dim file1 As New FileInfo(Directory.GetCurrentDirectory() + "\output_month.csv")
        Dim root As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            root = saveFileDialog1.FileName
            sw = New StreamWriter(root, False, Encoding.Default)
            sw.WriteLine("Date,PET,P,ET,R")
            For i = 0 To Form4.year.Items.Count() - 1
                For j = 0 To 4
                    If j < 4 Then
                        sw.Write(b(i, j))
                        sw.Write(",")
                    Else
                        sw.Write(b(i, j))
                    End If
                Next
                '   sw.WriteLine()
            Next
            sw.Close()

        End If
    End Sub

End Class