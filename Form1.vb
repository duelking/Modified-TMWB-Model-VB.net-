Imports System.IO
Imports System.Text
Imports System.Math
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.DataVisualization.Charting.ChartImageFormat
Imports System.Globalization
Imports System.Threading
Imports System.Drawing

Public Class Form1
    Dim k, c As Single
    Dim PET As String
    Dim th_soil_max As Single
    Dim t As Integer
    Dim smax As Single
    Dim DataSource As String
    Dim datasource2 As String
    Dim s2 As String = ""


    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
    'http://msdn.microsoft.com/zh-tw/library/system.windows.forms.button.performclick.aspx  
    '偷抄http://msdn.microsoft.com/zh-tw/library/system.windows.forms.filedialog(v=VS.100).aspx
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
         openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files(*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ComboBox1.Enabled = True
            TextBox1.Text = openFileDialog1.FileName

            Form4.yyyymmm.Items.Clear()
            Form4.PPET.Items.Clear()
            Form3.inputtxt.Items.Clear()
            Form3.year.Items.Clear()
            Form3.month.Items.Clear()
            Form3.T.Items.Clear()
            Form3.P.Items.Clear()
            Form3.solar.Items.Clear()
            Form3.dates.Items.Clear()

            DataSource = openFileDialog1.FileName
            Dim sr As StreamReader
            Dim s1 As String
            sr = New StreamReader(DataSource, Encoding.Default)
            s1 = sr.ReadLine()

            While s1 <> Nothing

                Form3.inputtxt.Items.Add(s1 & vbNewLine)
                s1 = sr.ReadLine()
            End While

            Dim a(Form3.inputtxt.Items.Count.ToString(), 6) As String

            Dim c() As String

            For f As Integer = 0 To Form3.inputtxt.Items.Count() - 1

                c = Form3.inputtxt.Items.Item(f).ToString.Split(New [Char]() {" "c, ","c, ":"c, CChar(vbTab)})

                For j As Integer = 0 To c.Length - 1
                    a(f, j) = c(j)
                Next

                s2 += Form3.inputtxt.Items(f).ToString() + vbCrLf
            Next
            sr.Close()

            ComboBox1.Items.Clear()
            If a(0, 4) <> 0 Then
                ComboBox1.Items.Add("Malmstrom")
                ComboBox1.Items.Add("Thornthwaite")
                ComboBox1.Items.Add("Hamon")
                For i As Integer = 0 To Form3.inputtxt.Items.Count() - 1

                    Form3.year.Items.Add(a(i, 0))
                    Form3.month.Items.Add(a(i, 1))
                    Form3.T.Items.Add(a(i, 2))
                    Form3.P.Items.Add(Val(a(i, 3)))
                    Form3.solar.Items.Add(a(i, 4))
                    Form3.dates.Items.Add(a(i, 5))

                Next
                '    Button10.Enabled = False
                Button10.Visible = True
            Else
                ComboBox1.Items.Add("Malmstrom")
                ComboBox1.Items.Remove("Thornthwaite")
                ComboBox1.Items.Remove("Hamon")
                For i As Integer = 0 To Form3.inputtxt.Items.Count() - 1

                    Form3.year.Items.Add(a(i, 0))
                    Form3.month.Items.Add(a(i, 1))
                    Form3.T.Items.Add(a(i, 2))
                    Form3.P.Items.Add(Val(a(i, 3)))


                Next
                '   Button10.Enabled = False
                Button10.Visible = True

            End If
        End If
        Form2.TextBox1.Text = Str(Form3.inputtxt.Items.Count()) + "月"

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll

        soilmax.Value = TrackBar1.Value
    
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog2 As New OpenFileDialog()

        openFileDialog2.InitialDirectory = Directory.GetCurrentDirectory()
        openFileDialog2.Filter = "Text Documents (*.txt)|*.txt|All Files|*.*"
        openFileDialog2.FilterIndex = 1
        openFileDialog2.RestoreDirectory = True

        If openFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Form3.obs.Items.Clear()
            Form3.obsR.Items.Clear()

            TextBox6.Text = openFileDialog2.FileName
            datasource2 = TextBox6.Text
            Dim sro As StreamReader
            Dim s1o As String
            Dim s2o As String = ""
            sro = New StreamReader(datasource2, Encoding.Default)
            s1o = sro.ReadLine()

            While s1o <> Nothing

                Form3.obs.Items.Add(s1o & vbNewLine)
                s1o = sro.ReadLine()
            End While

            Dim d(Form3.obs.Items.Count.ToString(), 3) As String

            Dim h() As String

            For g As Integer = 0 To Form3.obs.Items.Count() - 1
                h = Form3.obs.Items.Item(g).ToString.Split(New [Char]() {" "c, ","c, ":"c, CChar(vbTab)})

                For l = 0 To h.Length - 1
                    d(g, l) = h(l)
                Next
                s2o += Form3.obs.Items(g).ToString() + vbCrLf
            Next
            sro.Close()

            Dim zz As Single
            Dim Ro(Form3.obs.Items.Count() - 1) As Single
           
            For i As Integer = 0 To Form3.obs.Items.Count() - 1
                Ro(i) = d(i, 2)
                Form3.obsR.Items.Add(d(i, 2))
                zz += d(i, 2)
                Form3.Form1_avg_oR.Text = zz / Form3.obs.Items.Count()
            Next
            Form3.obsRmax.Text = getmax(Ro)
           

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

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Form4.PET.Items.Clear()
        Form4.im.Items.Clear()
        Form4.thI.Items.Clear()

        Dim ss, oops As String
        Dim sum As Single

        Select Case ComboBox1.SelectedItem.ToString()

            Case "Malmstrom"
                For i As Integer = 0 To Form3.inputtxt.Items.Count() - 1
                    ss = malmstrom(Form3.T.Items.Item(i))
                    Form4.PET.Items.Add(Round(Val(ss), 1))
                Next

                Call calcR()
                Call chart_draw()
                If Form3.obs.Items.Count <> 0 Then
                    Call chart_drawxy()
                End If


                GroupBox1.Enabled = True
                Button2.Visible = True
                Button2.Enabled = True


            Case "Hamon"
                For i As Integer = 0 To Form3.inputtxt.Items.Count() - 1
                    oops = 13.97 * Form3.dates.Items.Item(i) * Form3.solar.Items.Item(i) / 12 * Form3.solar.Items.Item(i) / 12 * (4.95 * Exp(0.062 * Form3.T.Items.Item(i)) / 100)
                    Form4.PET.Items.Add(Round(Val(oops), 1))
                Next

                Call calcR()
                Call chart_draw()
                If Form3.obs.Items.Count <> 0 Then
                    Call chart_drawxy()
                End If

                GroupBox1.Enabled = True
                Button2.Visible = True
                Button2.Enabled = True

            Case "Thornthwaite"

                For i As Integer = 0 To Form3.inputtxt.Items.Count() - 1
                    '
                    im(Form3.T.Items.Item(i))
                    Dim s As Integer
                    Dim u(Form3.inputtxt.Items.Count()) As Single

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
                            Form4.PET.Items.Add(Round(Val(16 * Form3.solar.Items.Item(ii) / 12 * Form3.dates.Items.Item(ii) / 30 * (10 * Form3.T.Items.Item(ii) / u(ii)) ^ (6.7 * 10 ^ -7 * u(ii) ^ 3 - 7.7 * 10 ^ -5 * u(ii) ^ 2 + 1.8 * 10 ^ -2 * u(ii) + 0.49)), 1))

                        Next
                        s += 1

                    Else
                        sum += Val(Form4.im.Items.Item(i))

                    End If
                Next
                Call calcR()
                Call chart_draw()
                If Form3.obs.Items.Count <> 0 Then
                    Call chart_drawxy()
                End If


                GroupBox1.Enabled = True
                Button2.Visible = True
                Button2.Enabled = True


        End Select
        PET = ComboBox1.Text

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form5.Show()
    End Sub
   
    Private Sub calcR()
        Dim i, j As Short
        Dim b(Form3.inputtxt.Items.Count.ToString(), 9) As String

        '========================================================計算=======================================================================

        Dim gg As DateTime
        c = PETc.Value
        For i = 0 To Form3.inputtxt.Items.Count() - 1

            'PET    
            b(i, 1) = Round(Form4.PET.Items.Item(i) * c, 1)
            'Date
            gg = CDate(Form3.month.Items.Item(i) + "/1/" + Form3.year.Items.Item(i))
            '   b(i, 0) = String.Format("{0:MMM-yy}", gg)
            b(i, 0) = gg.ToString("MMM-yy",CultureInfo.CreateSpecificCulture("en-us"))
            Form4.yyyymmm.Items.Add(gg.ToString("MMM-yyyy", CultureInfo.CreateSpecificCulture("en-us")))
            'P
            b(i, 2) = Round(Val(Form3.P.Items.Item(i)), 1)
            'P-PET
            b(i, 3) = Round((b(i, 2) - b(i, 1)), 1)

            'soil以後
            Dim sa As Single
            th_soil_max = soilmax.Value
            k = kk.Value
            smax = NumericUpDown1.Value

            Dim Si, Q1, Q2, Sj As Single

            Select Case i
                Case Is = 0

                    If b(i, 3) < 0 Then

                        b(i, 4) = Round(Val(th_soil_max * Exp(b(i, 3) / th_soil_max)), 1)
                        b(i, 5) = b(i, 2) + Round(th_soil_max * Abs(Exp(b(i, 3) / th_soil_max) - 1), 1)
                        b(i, 6) = 0
                    Else

                        b(i, 4) = Round(th_soil_max, 1)
                        b(i, 5) = b(i, 1)
                        b(i, 6) = b(i, 3)
                    End If

                    Si = (1 - k) * smax + Val(b(i, 6))  '=Qt-1+del Q
                    If Si > smax Then
                        Q1 = Si - smax
                        Sj = smax
                    Else
                        Q1 = 0
                        Sj = Si
                    End If
                    Q2 = Sj * k
                    b(i, 7) = Round(Sj - Q2, 1)
                    b(i, 8) = Round(Q2, 1)
                    b(i, 9) = Round(Q1 + Q2, 1)
                Case Else
                    If b(i, 3) >= 0 Then
                        sa = Val(b(i, 3)) + Val(b(i - 1, 4))    'sa=P-PET+St-1
                        b(i, 5) = b(i, 1)
                        If sa >= th_soil_max Then
                            b(i, 4) = th_soil_max
                            b(i, 6) = Round(sa - th_soil_max, 1)
                        Else
                            b(i, 4) = sa
                            b(i, 6) = 0

                        End If

                    Else
                        b(i, 4) = Round(Val(b(i - 1, 4) * Exp(b(i, 3) / th_soil_max)), 1)
                        b(i, 5) = b(i, 2) + Round(b(i - 1, 4) - b(i, 4), 1)
                        b(i, 6) = 0
                    End If


                    'Dim Si, Q1, Q2, Sj As Single
                    Si = Val(b(i - 1, 7)) + Val(b(i, 6))  '=Qt-1+del Q

                    Select Case Si
                        Case Is > smax
                            Q1 = Si - smax
                            Sj = smax
                        Case Is <= smax
                            Q1 = 0
                            Sj = Si
                    End Select
                   
                    Q2 = Sj * k
                    b(i, 7) = Round(Sj - Q2, 1)
                    b(i, 8) = Round(Q2, 1)
                    b(i, 9) = Round(Q1 + Q2, 1)

            End Select

        Next



        '========================================================輸出=======================================================================

        s2 = "  Date                   PET                 P                  P-PET        Soil Moisture             ET                   ∆Q                    S                    Gout                      R " _
            + vbCrLf + "================================================================================================================ " _
            + vbCrLf

        Form4.PET_2.Items.Clear()
        Form4.soil.Items.Clear()
        Form4.ET.Items.Clear()
        Form4.delQ.Items.Clear()
        Form4.Q.Items.Clear()
        Form4.simR.Items.Clear()
        Form4.baseflow.Items.Clear()
        Form4.PPET.Items.Clear()


        For i = 0 To Form3.inputtxt.Items.Count() - 1
            For j = 0 To 9
                s2 = s2 + b(i, j).PadRight(20)
            Next
            s2 = s2 + vbCrLf
            Form4.PPET.Items.Add(b(i, 3))
            Form4.soil.Items.Add(b(i, 4))
            Form4.ET.Items.Add(b(i, 5))
            Form4.delQ.Items.Add(b(i, 6))
            Form4.Q.Items.Add(b(i, 7))
            Form4.baseflow.Items.Add(b(i, 8))
            Form4.simR.Items.Add(b(i, 9))
            Form4.PET_2.Items.Add(b(i, 1))
        Next
        Form2.RichTextBox1.Text = s2
        If Form3.obs.Items.Count <> 0 Then
            Call correl()
            corr.Visible = True
            corr.Enabled = True
            GroupBox2.Enabled = True
            GroupBox2.Visible = True
        End If
        Button2.Enabled = True

    End Sub
    Sub chart_draw()
        Chart1.Series.Clear()
        ' Create new data series and set it's visual attributes
        Dim series As New Series("Model2")

        If Form3.obs.Items.Count <> 0 Then
            Call chart_drawo()
            Chart1.ChartAreas("ChartArea1").AxisY.Maximum = Ceiling(Form3.obsRmax.Text / Chart1.ChartAreas("ChartArea1").AxisY.Interval) * Chart1.ChartAreas("ChartArea1").AxisY.Interval
        End If

        ' Dim obs As New Series("Obs.")
        Dim year As DateTime
        series.ChartType = SeriesChartType.Spline

        series.BorderWidth = 1.4
        series.ShadowOffset = 0
        Chart1.ChartAreas("ChartArea1").BackColor = Color.Azure
        ' Set  axis title
        'Chart1.ChartAreas("ChartArea1").AxisX.Title = "month"
        Chart1.ChartAreas("ChartArea1").AxisY.Title = "Runoff(mm/month)"
        '標題字色
        'Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.Transparent
        Chart1.ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.BurlyWood
        '標題字型
        Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)
        Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Times New Roman", 14, FontStyle.Bold)
        'MarkerStyle
        ' obs.MarkerStyle = MarkerStyle.Triangle
        ' obs.Color = Color.OrangeRed

        ' Populate new series with data
        For i = 0 To Form3.inputtxt.Items.Count() - 1
            year = Form3.year.Items.Item(i) + "/" + Form3.month.Items.Item(i)
            series.Points.AddXY(String.Format("{0:yyyy}", year), Form4.simR.Items.Item(i))
        Next
        

        Dim m As Integer
        Select Case Form3.inputtxt.Items.Count / 12
            Case Is < 10
                m = 1
            Case 10 To 18
                m = 2
            Case 19 To 36
                m = 3
            Case Else
                m = 4
        End Select
       
        'Chart1.ChartAreas("ChartArea1").AxisX.Interval = 12 * m + 1
        Chart1.ChartAreas("ChartArea1").AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
        ' Chart1.ChartAreas("ChartArea1").AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount
        Chart1.ChartAreas("ChartArea1").AxisY.Interval = 200
        Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
        Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.FromArgb(85, 10, 10, 10)

        ' Chart1.ChartAreas("ChartArea1").BackColor = Color.Transparent
        ' Chart1.ChartAreas("ChartArea1").BackSecondaryColor = Color.White
        Chart1.ChartAreas("ChartArea1").BackGradientStyle = GradientStyle.TopBottom
        Chart1.BackColor = Color.OldLace
        Chart1.BackSecondaryColor = Color.White
        Chart1.BackGradientStyle = GradientStyle.TopBottom
        'Chart1.Legends.

        'Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
        '  Dim oo(Form3.obs.Items.Count.ToString(), 1) As String

        '區間=12*n+1,隔年一月=13月
        ' Add series into the chart's series collection
        series.Color = Color.BlueViolet
        Chart1.Series.Add(series)
        Camera.Enabled = True

    End Sub
    Sub chart_drawo()
        Dim obs As New Series("Observed")
        Dim year As DateTime

        obs.ChartType = SeriesChartType.Point
        
        'MarkerStyle
        obs.MarkerStyle = MarkerStyle.Triangle
        obs.Color = Color.OrangeRed
        ' Populate new series with data
        For i = 0 To Form3.inputtxt.Items.Count() - 1
            year = Form3.year.Items.Item(i) + "/" + Form3.month.Items.Item(i)

            obs.Points.AddXY(String.Format("{0:yyyy}", year), Form3.obsR.Items.Item(i))

        Next
        ' Add series into the chart's series collection

        Chart1.Series.Add(obs)
    End Sub
    Sub chart_drawxy()
        Form7.Chart1.Series.Clear()
        Dim series As New Series("Runoff")
        Dim ofo As New Series("1:1")

        Dim x(1, Form3.obsR.Items.Count) As String
        Dim y(1, Form3.obsR.Items.Count) As String
        ' Create new data series and set it's visual attributes

        ofo.ChartType = SeriesChartType.Spline
        series.ChartType = SeriesChartType.Point
        ofo.BorderWidth = 3
        series.MarkerSize = 5
        series.ShadowOffset = 0

        ' Set  axis title
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.Title = "Model2(mm/month)"
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.Title = "Observed(mm/month)"
        '標題字色
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.Red
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.BurlyWood
        '標題字型
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Times New Roman", 20, FontStyle.Bold)
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Times New Roman", 20, FontStyle.Bold)
        'MarkerStyle
        series.MarkerStyle = MarkerStyle.Triangle
        series.Color = Color.OrangeRed
        ' Populate new series with data
        Dim xx As Double
        For i = 0 To Form3.inputtxt.Items.Count() - 1
            xx = Form4.simR.Items.Item(i)
            series.Points.AddXY(xx, Form3.obsR.Items.Item(i))
        Next
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.Interval = 250
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.Interval = 250
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.Minimum = 0
        Form7.Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Ceiling(Form3.obsRmax.Text / Form7.Chart1.ChartAreas("ChartArea1").AxisX.Interval) * Form7.Chart1.ChartAreas("ChartArea1").AxisX.Interval
        Form7.Chart1.ChartAreas("ChartArea1").AxisY.Maximum = Form7.Chart1.ChartAreas("ChartArea1").AxisX.Maximum
        ofo.Points.AddXY(0, 0)
        ofo.Points.AddXY(Form7.Chart1.ChartAreas("ChartArea1").AxisX.Maximum, Form7.Chart1.ChartAreas("ChartArea1").AxisX.Maximum)
        'Form7.Chart1.ChartAreas("ChartArea1").BackColor = Color.li
        'Form7.Chart1.ChartAreas("ChartArea1").BackGradientStyle = GradientStyle.TopBottom
        Form7.Chart1.BackColor = Color.AliceBlue
        Form7.Chart1.BackSecondaryColor = Color.White
        Form7.Chart1.BackGradientStyle = GradientStyle.TopBottom
        Form7.Chart1.Series.Add(ofo)
        Form7.Chart1.Series.Add(series)
    End Sub

    Private Sub corr_Click(sender As System.Object, e As System.EventArgs) Handles corr.Click
        Form7.Show()
    End Sub

    Sub correl()
        Dim obs, sim, os, obs2, sim2 As Single
        Dim xx As Single
        Dim yy, zz As Single
        For i = 12 To Form3.inputtxt.Items.Count() - 1

            os += Form3.obsR.Items.Item(i) * Form4.simR.Items.Item(i)
            obs += Form3.obsR.Items.Item(i)
            sim += Form4.simR.Items.Item(i)
            obs2 += Form3.obsR.Items.Item(i) * Form3.obsR.Items.Item(i)
            sim2 += Form4.simR.Items.Item(i) * Form4.simR.Items.Item(i)

            xx += Val(Form3.obsR.Items.Item(i) - Form4.simR.Items.Item(i)) ^ 2
            yy += (Form3.obsR.Items.Item(i) - Form3.Form1_avg_oR.Text) ^ 2
            zz += (Form3.obsR.Items.Item(i) - Form4.simR.Items.Item(i)) ^ 2

        Next
        Dim x, y As Single
        Dim j As Integer

        Dim a, b, c As Single
        For j = 12 To Form3.inputtxt.Items.Count() - 1
            x = Form3.obsR.Items.Item(j) - obs / Form3.inputtxt.Items.Count()
            y = Form4.simR.Items.Item(j) - sim / Form3.inputtxt.Items.Count()
            a += x * y
            b += x * x
            c += y * y
        Next
        'R^2
        Label1.Text = Round((a / Sqrt(b * c)) ^ 2, 2)
        'RMES
        Label6.Text = Round(Sqrt(xx / (Form3.inputtxt.Items.Count())), 2)
        'E
        Label7.Text = Round(1 - zz / yy, 3) * 100
        xx = 0
        yy = 0
        zz = 0
        x = 0
        y = 0
        a = 0
        b = 0
        c = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button10.Enabled = True
    End Sub

    Private Sub TrackBar3_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar3.Scroll
        NumericUpDown1.Value = TrackBar3.Value
    End Sub

    Private Sub TrackBar4_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar4.Scroll
        PETc.Value = TrackBar4.Value / 100
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
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Form3.Show()
        'Form4.Show()
    End Sub

    Private Sub kk_ValueChanged(sender As System.Object, e As System.EventArgs) Handles kk.ValueChanged
        Call calcR()
        Call chart_draw()
        If Form3.obs.Items.Count <> 0 Then
            Call chart_drawxy()
        End If
    End Sub

    Private Sub Camera_Click(sender As System.Object, e As System.EventArgs) Handles Camera.Click
        'Create a Directory
        My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory() + "\Image")
        Dim currentdate As Date = DateTime.Now
        Chart1.SaveImage(Directory.GetCurrentDirectory() + "\Image" + "\" + "TMWB2" + " - " + PET + "(" + currentdate.ToString("HH,mm,ss tt", CultureInfo.CreateSpecificCulture("en-us")) + ")" + ".bmp", Bmp)

    End Sub

    
    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        TrackBar3.Value = NumericUpDown1.Value
        Call calcR()
        Call chart_draw()
        If Form3.obs.Items.Count <> 0 Then
            Call chart_drawxy()
        End If
    End Sub

    Private Sub soilmax_ValueChanged(sender As System.Object, e As System.EventArgs) Handles soilmax.ValueChanged
        TrackBar1.Value = soilmax.Value
        Call calcR()
        Call chart_draw()
        If Form3.obs.Items.Count <> 0 Then
            Call chart_drawxy()
        End If
    End Sub

    Private Sub PETc_ValueChanged(sender As System.Object, e As System.EventArgs) Handles PETc.ValueChanged
        TrackBar4.Value = PETc.Value * 100
        Call calcR()
        Call chart_draw()
        If Form3.obs.Items.Count <> 0 Then
            Call chart_drawxy()
        End If
    End Sub
End Class

