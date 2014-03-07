Imports System.IO
Imports System.Text
Imports System.Math
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization.Charting.ChartImageFormat


Public Class Form5
    Dim PET, ET As String
    Dim DataSource As String
    Dim datasource2 As String
    Dim yc As Single

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call y_calc()

    End Sub

    '偷抄http://msdn.microsoft.com/zh-tw/library/system.windows.forms.filedialog(v=VS.100).aspx
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim s0 As String = ""
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
        openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files(*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Text = openFileDialog1.FileName
            Form3.inputtxt5.Items.Clear()
            Form4.year.Items.Clear()
            Form4.yT.Items.Clear()
            Form4.yP.Items.Clear()
            Form4.yPET.Items.Clear()
            Form4.yR.Items.Clear()

            Form3.y5.Items.Clear()
            Form3.m5.Items.Clear()
            Form3.T5.Items.Clear()
            Form3.P5.Items.Clear()
            Form3.s5.Items.Clear()
            Form3.d5.Items.Clear()


            DataSource = TextBox1.Text
            Dim sr As StreamReader
            Dim s1 As String
            sr = New StreamReader(DataSource, Encoding.Default)
            s1 = sr.ReadLine()

            While s1 <> Nothing

                Form3.inputtxt5.Items.Add(s1 & vbNewLine)
                s1 = sr.ReadLine()
            End While

            Dim a(Form3.inputtxt5.Items.Count.ToString(), 6) As String

            Dim c() As String

            For f As Integer = 0 To Form3.inputtxt5.Items.Count() - 1

                c = Form3.inputtxt5.Items.Item(f).ToString.Split(New [Char]() {" "c, ","c, ":"c, CChar(vbTab)})

                For j As Integer = 0 To c.Length - 1
                    a(f, j) = c(j)
                Next

                s0 += Form3.inputtxt5.Items(f).ToString() + vbCrLf
            Next
            sr.Close()

            Dim yt, yp As Single
            If a(0, 4) <> 0 Then
                th.Enabled = True
                Ha.Enabled = True
                For i As Integer = 0 To Form3.inputtxt5.Items.Count() - 1
                    th.Enabled = True
                    Ha.Enabled = True
                    Form3.y5.Items.Add(a(i, 0))
                    Form3.m5.Items.Add(a(i, 1))
                    Form3.T5.Items.Add(a(i, 2))
                    Form3.P5.Items.Add(a(i, 3))
                    Form3.s5.Items.Add(a(i, 4))
                    Form3.d5.Items.Add(a(i, 5))
                    yt += a(i, 2)
                    yp += a(i, 3)
                    If i Mod 12 = 11 Then
                        Form4.year.Items.Add(a(i, 0))
                        Form4.yT.Items.Add(Round(yt / 12, 0))
                        Form4.yP.Items.Add(Round(yp, 0))
                        yt = 0
                        yp = 0
                    End If
                Next

            Else
                th.Enabled = False
                Ha.Enabled = False
                For i As Integer = 0 To Form3.inputtxt5.Items.Count() - 1

                    Form3.y5.Items.Add(a(i, 0))
                    Form3.m5.Items.Add(a(i, 1))
                    Form3.T5.Items.Add(a(i, 2))
                    Form3.P5.Items.Add(a(i, 3))
                    yt += a(i, 2)
                    yp += a(i, 3)
                    If i Mod 12 = 11 Then
                        Form4.year.Items.Add(a(i, 0))
                        Form4.yT.Items.Add(Round(yt / 12, 0))
                        Form4.yP.Items.Add(Round(yp, 0))
                        yt = 0
                        yp = 0
                    End If

                Next

            End If
        End If
        Form6.TextBox1.Text = Str(Form4.year.Items.Count()) + "年"
        GroupBox3.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form3.obs5.Items.Clear()

        Form4.yobsR.Items.Clear()

        Dim myStream As Stream = Nothing
        Dim openFileDialog2 As New OpenFileDialog()
        openFileDialog2.InitialDirectory = Directory.GetCurrentDirectory()
        openFileDialog2.Filter = "Text Documents (*.txt)|*.txt|All Files(*.*)|*.*"
        openFileDialog2.FilterIndex = 1
        openFileDialog2.RestoreDirectory = True

        If openFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox6.Text = openFileDialog2.FileName

            datasource2 = TextBox6.Text
            Dim sro As StreamReader
            Dim s1o As String
            Dim s2o As String = ""
            sro = New StreamReader(datasource2, Encoding.Default)
            s1o = sro.ReadLine()

            While s1o <> Nothing

                Form3.obs5.Items.Add(s1o & vbNewLine)
                s1o = sro.ReadLine()
            End While

            Dim d(Form3.obs5.Items.Count.ToString(), 4) As String

            Dim h() As String

            For g As Integer = 0 To Form3.obs5.Items.Count() - 1
                h = Form3.obs5.Items.Item(g).ToString.Split(New [Char]() {" "c, ","c, ":"c, CChar(vbTab)})

                For l = 0 To h.Length - 1
                    d(g, l) = h(l)
                Next

                s2o += Form3.obs5.Items(g).ToString() + vbCrLf
            Next
            sro.Close()

            Dim ee, ff As Single
            Dim Ro(Form3.obs5.Items.Count() - 1) As Single
            'ee用來計算年逕流
            For i As Integer = 0 To (Form3.obs5.Items.Count() - 1)
                ee += d(i, 2)
                ff += d(i, 2)
                If i Mod 12 = 11 Then
                    Ro(i) = ee
                    Form4.yobsR.Items.Add(Round(ee, 1))
                    ee = 0
                End If
            Next
            Form3.Form5_avg_oR.Text = ff / Form4.yobsR.Items.Count()
            Form3.yobsRmax.Text = getmax(Ro)

        End If
    End Sub
    Function malmstrom(ByVal kk As String)
        Dim N As String

        N = 40.9 * 0.611 * Exp(17.3 * kk / (kk + 237.3))

        Return N
    End Function

    Sub im(ByVal mm As String)
        Dim im As Single
        im = (Val(mm) / 5) ^ 1.514
        Form4.im.Items.Add(im & vbNewLine)

    End Sub
    Sub PET_clac()
        Form4.PET.Items.Clear()
        Form4.yPET.Items.Clear()
        Dim ss, oops As String
        Dim sum, ll, mm As Single

        If ma.Checked = True Then
            For i As Integer = 0 To Form3.y5.Items.Count() - 1
                ss = malmstrom(Form3.T5.Items.Item(i))
                ll += ss
                Form4.PET.Items.Add(Round(Val(ss), 1))
                If i Mod 12 = 11 Then
                    Form4.yPET.Items.Add(Round(ll, 1))
                    ll = 0
                End If
            Next
            PET = ma.Text
        ElseIf ho.Checked = True Then
            For i As Integer = 0 To Form4.yT.Items.Count() - 1
                holland(Form4.yT.Items.Item(i))
            Next
            PET = ho.Text
        ElseIf Ha.Checked = True Then
            For i As Integer = 0 To Form3.y5.Items.Count() - 1
                oops = 13.97 * Form3.d5.Items.Item(i) * Form3.s5.Items.Item(i) / 12 * Form3.s5.Items.Item(i) / 12 * (4.95 * Exp(0.062 * Form3.T5.Items.Item(i)) / 100)
                mm += oops
                Form4.PET.Items.Add(Round(Val(oops), 1))
                If i Mod 12 = 11 Then
                    Form4.yPET.Items.Add(Round(mm, 1))
                    mm = 0
                End If
            Next
            PET = Ha.Text
        ElseIf th.Checked = True Then

            For i As Integer = 0 To Form3.y5.Items.Count() - 1
                im(Form3.T5.Items.Item(i))
                Dim s As Integer
                Dim u(Form3.y5.Items.Count()), cc As Single

                If i Mod 12 = 11 Then
                    sum += Val(Form4.im.Items.Item(i))
                    Form4.thI.Items.Add(sum)

                    u(i) = Form4.thI.Items.Item(s)

                    u(i - 1) = Form4.thI.Items.Item(s)

                    u(i - 2) = Form4.thI.Items.Item(s)

                    u(i - 3) = Form4.thI.Items.Item(s)

                    u(i - 4) = Form4.thI.Items.Item(s)

                    u(i - 5) = Form4.thI.Items.Item(s)

                    u(i - 6) = Form4.thI.Items.Item(s)

                    u(i - 7) = Form4.thI.Items.Item(s)

                    u(i - 8) = Form4.thI.Items.Item(s)

                    u(i - 9) = Form4.thI.Items.Item(s)

                    u(i - 10) = Form4.thI.Items.Item(s)

                    u(i - 11) = Form4.thI.Items.Item(s)

                    sum = 0
                    For ii As Integer = i - 11 To i
                        Form4.PET.Items.Add(Round(Val(16 * Form3.s5.Items.Item(ii) / 12 * Form3.d5.Items.Item(ii) / 30 * (10 * Form3.T5.Items.Item(ii) / u(ii)) ^ (6.7 * 10 ^ -7 * u(ii) ^ 3 - 7.7 * 10 ^ -5 * u(ii) ^ 2 + 1.8 * 10 ^ -2 * u(ii) + 0.49)), 1))
                        cc += Val(16 * Form3.s5.Items.Item(ii) / 12 * Form3.d5.Items.Item(ii) / 30 * (10 * Form3.T5.Items.Item(ii) / u(ii)) ^ (6.7 * 10 ^ -7 * u(ii) ^ 3 - 7.7 * 10 ^ -5 * u(ii) ^ 2 + 1.8 * 10 ^ -2 * u(ii) + 0.49))
                    Next
                    s += 1
                    Form4.yPET.Items.Add(Round(cc, 1))
                    cc = 0
                Else
                    sum += Val(Form4.im.Items.Item(i))

                End If
            Next
            PET = th.Text
        
        End If
        GroupBox3.Enabled = True

    End Sub
  

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles X_Yplot.Click
        Form8.Show()
    End Sub


    Private Sub ma_click(sender As System.Object, e As System.EventArgs) Handles ma.Click, ho.Click, th.Click, Ha.Click
        Call PET_clac()
        ' Button10.Visible = True
        X_Yplot.Enabled = False
        sc.Enabled = True
        ol.Enabled = True
        bu.Enabled = True
        fu.Enabled = True
        truc.Enabled = True
       

    End Sub

    Private Sub holland(ByVal yT As String)
        Dim aa As Single
        aa = Round((1.2 * 10 ^ 10 * Exp(-4620 / (273.15 + yT))), 1)
        Form4.yPET.Items.Add(aa & vbNewLine)
    End Sub

    Private Sub fu_Click(sender As System.Object, e As System.EventArgs) Handles fu.Click
        Label2.Enabled = True
        Label2.Visible = True
        w.Enabled = True
        w.Visible = True
        TrackBar1.Enabled = True
        TrackBar1.Visible = True

    End Sub

    Private Sub sc_Click(sender As System.Object, e As System.EventArgs) Handles sc.Click, ol.Click, bu.Click, truc.Click
        Form4.yET.Items.Clear()
        Form4.yR.Items.Clear()
        Label2.Enabled = False
        w.Enabled = False

        TrackBar1.Enabled = False
        Call y_calc()
    End Sub

    Private Sub y_calc()
        Dim s2 As String = ""

        Dim i, j As Short
        Dim b(Form4.yP.Items.Count.ToString(), 5) As String

        '========================================================計算=======================================================================


        Dim scf, olf, buf, tuf As Single
        For i = 0 To Form4.yT.Items.Count() - 1
            'Date
            b(i, 0) = Form4.year.Items.Item(i)

            'P
            b(i, 2) = Round(Val(Form4.yP.Items.Item(i)), 1)
            b(i, 1) = Int(Val(Form4.yPET.Items.Item(i) * PETyc.Value))
            'ET & Runoff
            If sc.Checked = True Then


                scf = Form4.yP.Items.Item(i) * Exp(-b(i, 1) / Form4.yP.Items.Item(i))
                b(i, 3) = Int(Val(Form4.yP.Items.Item(i)) - scf)

                b(i, 4) = Int(scf)

                ET = sc.Text
            ElseIf ol.Checked = True Then
               
                olf = Form4.yP.Items.Item(i) - b(i, 1) * Tanh(Form4.yP.Items.Item(i) / b(i, 1))
                b(i, 3) = Int(Val(Form4.yP.Items.Item(i)) - olf)

                b(i, 4) = Int(olf)

                ET = ol.Text
            ElseIf bu.Checked = True Then
             
                buf = Form4.yP.Items.Item(i) - b(i, 1) * Sqrt(Form4.yP.Items.Item(i) / b(i, 1) * Tanh(Form4.yP.Items.Item(i) / b(i, 1)) * (1 - Exp(-b(i, 1) / Form4.yP.Items.Item(i))))
                b(i, 3) = Int(Val(Form4.yP.Items.Item(i)) - buf)

                b(i, 4) = Int(buf)

                ET = bu.Text

            ElseIf truc.Checked = True Then
               
                tuf = Form4.yP.Items.Item(i) - Form4.yP.Items.Item(i) / Sqrt(0.9 + (Form4.yP.Items.Item(i) / b(i, 1)) ^ 2)
                b(i, 3) = Int(Val(Form4.yP.Items.Item(i)) - tuf)

                b(i, 4) = Int(tuf)

                ET = truc.Text
            ElseIf fu.Checked = True Then
                Dim fuf As Single
                
                fuf = Form4.yP.Items.Item(i) - Form4.yP.Items.Item(i) * (1 + b(i, 1) / Form4.yP.Items.Item(i) - (1 + (b(i, 1) / Form4.yP.Items.Item(i)) ^ w.Text) ^ (1 / w.Text))
                b(i, 3) = Int(Val(Form4.yP.Items.Item(i)) - fuf)

                b(i, 4) = Int(fuf)

                ET = fu.Text

            End If
        Next

        GroupBox2.Visible = True

        '========================================================輸出=======================================================================

        s2 = "Date                PET                   P                     ET                    R " _
            + vbCrLf + "= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =" _
            + vbCrLf
        Form4.yET.Items.Clear()
        Form4.yR.Items.Clear()
        Form4.yPET_2.Items.Clear()
        For i = 0 To Form4.yT.Items.Count() - 1
            For j = 0 To 4
                s2 += b(i, j).PadRight(20)
            Next
            s2 += vbNewLine
            Form4.yPET_2.Items.Add(Int(b(i, 1)))
            Form4.yET.Items.Add(Int(b(i, 3)))
            Form4.yR.Items.Add(Int(b(i, 4)))
        Next

        Form6.RichTextBox1.Text = s2
        If Form4.yobsR.Items.Count <> 0 Then
            Call correl()
            Call chart_drawxy()
        End If
        Call chart_draw()
        X_Yplot.Enabled = True
        Result.Enabled = True
        X_Yplot.Visible = True
        Result.Visible = True
        TrackBar4.Enabled = True
        PETyc.Enabled = True
        Camera.Enabled = True
        Form6.Label2.Text = PET + " - " + ET
    End Sub
    
    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        w.Text = TrackBar1.Value / 10
        Call y_calc()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Result.Click
        Form6.Show()
    End Sub

    Sub chart_draw()
        Chart1.Series.Clear()
        ' Create new data series and set it's visual attributes
        Dim series As New Series(PET + " - " + ET)
        If Form4.yobsR.Items.Count <> 0 Then
            Call chart_drawo()
            Chart1.ChartAreas("ChartArea1").AxisY.Maximum = Ceiling(Form3.yobsRmax.Text / Chart1.ChartAreas("ChartArea1").AxisY.Interval) * Chart1.ChartAreas("ChartArea1").AxisY.Interval
        End If
        series.ChartType = SeriesChartType.Spline

        series.BorderWidth = 3
        series.ShadowOffset = 0
        series.MarkerStyle = MarkerStyle.Square
        series.MarkerSize = 12
        'obs.MarkerSize = 12
        ' Set  axis title
        Chart1.ChartAreas("ChartArea1").AxisX.Title = "Year"
        Chart1.ChartAreas("ChartArea1").AxisY.Title = "Runoff(mm/year)"
        '標題字色
        Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.PaleGreen
        Chart1.ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.Violet
        '標題字型
        ' Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Times New Roman", 20, FontStyle.Bold)
        Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)

        'Chart1.ChartAreas("ChartArea1").AxisX.Interval = 2
        ' Populate new series with data
        Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.FromArgb(85, 10, 10, 10)

        For i = 0 To Form4.yR.Items.Count() - 1

            series.Points.AddXY(Form4.year.Items.Item(i).ToString, Form4.yR.Items.Item(i))

        Next
        Chart1.ChartAreas("ChartArea1").BackColor = Color.FromArgb(100, 192, 255, 255)
        Chart1.ChartAreas("ChartArea1").BackSecondaryColor = Color.White
        Chart1.ChartAreas("ChartArea1").BackGradientStyle = GradientStyle.TopBottom
        Chart1.BackColor = Color.OldLace
        Chart1.BackSecondaryColor = Color.White
        Chart1.BackGradientStyle = GradientStyle.TopBottom
        series.Color = Color.FromArgb(80, 64, 200, 100)
        Chart1.Series.Add(series)
        Chart1.ChartAreas("ChartArea1").AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        '  Chart1.ChartAreas("ChartArea1").AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount
        Chart1.ChartAreas("ChartArea1").AxisY.Interval = 400

    End Sub
    Sub chart_drawo()
        Dim obs As New Series("Observed")
        obs.ChartType = SeriesChartType.Point
        obs.MarkerStyle = MarkerStyle.Star6
        obs.Color = Color.OrangeRed
        obs.MarkerSize = 12
        For i = 0 To Form4.yR.Items.Count() - 1

            obs.Points.AddXY(Form4.year.Items.Item(i).ToString, Form4.yobsR.Items.Item(i))

        Next

        Chart1.Series.Add(obs)
    End Sub
    Sub chart_drawxy()
        Form8.Chart1.Series.Clear()
        Dim series As New Series("Runoff")
        Dim ofo As New Series("1:1")

        Dim x(1, Form3.obsR.Items.Count) As String
        Dim y(1, Form3.obsR.Items.Count) As String
        ' Create new data series and set it's visual attributes

        ofo.ChartType = SeriesChartType.Spline
        series.ChartType = SeriesChartType.Point
        ofo.BorderWidth = 4
        series.MarkerSize = 12
        series.ShadowOffset = 0

        ' Set  axis title
        Form8.Chart1.ChartAreas("ChartArea1").AxisX.Title = "Simulated(mm/year)"
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.Title = "Observed(mm/year)"
        '標題字色
        Form8.Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.Red
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.BurlyWood
        '標題字型
        Form8.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Times New Roman", 20, FontStyle.Bold)
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Times New Roman", 20, FontStyle.Bold)
        'MarkerStyle
        series.MarkerStyle = MarkerStyle.Star5
        series.Color = Color.OrangeRed
        ' Populate new series with data
        Dim xx As Double
        For i = 0 To Form4.yR.Items.Count() - 1
            xx = Form4.yR.Items.Item(i)
            series.Points.AddXY(xx, Form4.yobsR.Items.Item(i))
        Next


        Form8.Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.Minimum = 0

        Form8.Chart1.ChartAreas("ChartArea1").AxisX.Interval = 500
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.Interval = 500

        Form8.Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
        Form8.Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Ceiling(Form3.yobsRmax.Text / Form8.Chart1.ChartAreas("ChartArea1").AxisX.Interval) * Form8.Chart1.ChartAreas("ChartArea1").AxisX.Interval
        Form8.Chart1.ChartAreas("ChartArea1").AxisY.Maximum = Form8.Chart1.ChartAreas("ChartArea1").AxisX.Maximum
        ofo.Points.AddXY(0, 0)
        ofo.Points.AddXY(Form8.Chart1.ChartAreas("ChartArea1").AxisX.Maximum, Form8.Chart1.ChartAreas("ChartArea1").AxisX.Maximum)

        Form8.Chart1.Series.Add(ofo)
        Form8.Chart1.Series.Add(series)

    End Sub
    Sub correl()
        Dim obs, sim As Single
        Dim xx As Single
        Dim yy, zz As Single
        For i = 0 To Form4.yT.Items.Count() - 1
            obs += Form4.yobsR.Items.Item(i)
            sim += Form4.yR.Items.Item(i)
            xx += Val(Form4.yobsR.Items.Item(i) - Form4.yR.Items.Item(i)) ^ 2
            yy += Val(Form4.yobsR.Items.Item(i) - Form3.Form5_avg_oR.Text) ^ 2
            zz += Val(Form4.yobsR.Items.Item(i) - Form4.yR.Items.Item(i)) ^ 2
        Next

        Dim x, y As Single
        Dim j As Integer

        Dim a, b, c As Single
        For j = 0 To Form4.yT.Items.Count() - 1
            x = Form4.yobsR.Items.Item(j) - obs / Form4.yT.Items.Count()
            y = Form4.yR.Items.Item(j) - sim / Form4.yT.Items.Count()
            a += x * y
            b += x * x
            c += y * y
        Next

        'R^2
        Label1.Text = Round((a / Sqrt(b * c)) ^ 2, 2)
        'RMSE
        Label6.Text = Round(Sqrt(xx / Form4.yT.Items.Count()), 1)
        'E
        Label7.Text = Round(1 - zz / yy, 3) * 100
        xx = 0
        yy = 0
        zz = 0
        a = 0
        b = 0
        c = 0
    End Sub

    Private Sub Camera_Click(sender As System.Object, e As System.EventArgs) Handles Camera.Click
        'Create a Directory
        My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\Image")

        Chart1.SaveImage(Directory.GetCurrentDirectory() + "\Image" + "\" + PET + " - " + ET + ".png", Png)

    End Sub
    Function getmax(ByRef ary() As Single) As Single
        Dim max As Single
        max = ary(0)
        For i As Integer = 1 To ary.GetUpperBound(0)
            If max < ary(i) Then
                max = ary(i)
            End If
        Next
        Return max
    End Function
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Form3.Show()
        'Form4.Show()
    End Sub

    Private Sub PETc_ValueChanged(sender As Object, e As EventArgs) Handles PETyc.ValueChanged
        TrackBar4.Value = PETyc.Value * 100
        'Select Case ET
        ' Case "Schreiber", "Ol'dekop", "Pike", "Budyko"
        'Call y_calc()
        'Case "fu."
        Call y_calc()
        'End Select
        If Form4.yobsR.Items.Count <> 0 Then
            Call chart_drawxy()
        End If
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        PETyc.Value = TrackBar4.Value / 100
    End Sub
End Class

