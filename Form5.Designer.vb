<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.X_Yplot = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ho = New System.Windows.Forms.RadioButton()
        Me.ma = New System.Windows.Forms.RadioButton()
        Me.th = New System.Windows.Forms.RadioButton()
        Me.fu = New System.Windows.Forms.RadioButton()
        Me.bu = New System.Windows.Forms.RadioButton()
        Me.ol = New System.Windows.Forms.RadioButton()
        Me.sc = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ha = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.truc = New System.Windows.Forms.RadioButton()
        Me.w = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Result = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Camera = New System.Windows.Forms.Button()
        Me.PETyc = New System.Windows.Forms.NumericUpDown()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETyc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 12)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "R^2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(26, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 58)
        Me.Panel1.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 12)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "RMSE(mm/yr):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 12)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "E(%):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 12)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Label7"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 536)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 102)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accurary Indices"
        Me.GroupBox2.Visible = False
        '
        'X_Yplot
        '
        Me.X_Yplot.Location = New System.Drawing.Point(67, 508)
        Me.X_Yplot.Name = "X_Yplot"
        Me.X_Yplot.Size = New System.Drawing.Size(75, 23)
        Me.X_Yplot.TabIndex = 57
        Me.X_Yplot.Text = "X-Y Plot"
        Me.X_Yplot.UseMnemonic = False
        Me.X_Yplot.UseVisualStyleBackColor = True
        Me.X_Yplot.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(931, 7)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "Obs."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Location = New System.Drawing.Point(201, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(351, 22)
        Me.TextBox1.TabIndex = 48
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(559, 7)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Input"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.MintCream
        Me.TextBox6.Location = New System.Drawing.Point(640, 8)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(285, 22)
        Me.TextBox6.TabIndex = 51
        '
        'ho
        '
        Me.ho.AutoSize = True
        Me.ho.ForeColor = System.Drawing.Color.DarkRed
        Me.ho.Location = New System.Drawing.Point(20, 22)
        Me.ho.Name = "ho"
        Me.ho.Size = New System.Drawing.Size(60, 16)
        Me.ho.TabIndex = 59
        Me.ho.Text = "Holland"
        Me.ho.UseVisualStyleBackColor = True
        '
        'ma
        '
        Me.ma.AutoSize = True
        Me.ma.Location = New System.Drawing.Point(19, 50)
        Me.ma.Name = "ma"
        Me.ma.Size = New System.Drawing.Size(72, 16)
        Me.ma.TabIndex = 60
        Me.ma.Text = "Malmstom"
        Me.ma.UseVisualStyleBackColor = True
        '
        'th
        '
        Me.th.AutoSize = True
        Me.th.Location = New System.Drawing.Point(19, 80)
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(85, 16)
        Me.th.TabIndex = 61
        Me.th.Text = "Thornthwaite"
        Me.th.UseVisualStyleBackColor = True
        '
        'fu
        '
        Me.fu.AutoSize = True
        Me.fu.Enabled = False
        Me.fu.Location = New System.Drawing.Point(20, 113)
        Me.fu.Name = "fu"
        Me.fu.Size = New System.Drawing.Size(38, 16)
        Me.fu.TabIndex = 66
        Me.fu.Text = "Fu."
        Me.fu.UseVisualStyleBackColor = True
        '
        'bu
        '
        Me.bu.AutoSize = True
        Me.bu.Enabled = False
        Me.bu.Location = New System.Drawing.Point(20, 81)
        Me.bu.Name = "bu"
        Me.bu.Size = New System.Drawing.Size(61, 16)
        Me.bu.TabIndex = 65
        Me.bu.Text = "Budyko"
        Me.bu.UseVisualStyleBackColor = True
        '
        'ol
        '
        Me.ol.AutoSize = True
        Me.ol.Enabled = False
        Me.ol.Location = New System.Drawing.Point(20, 48)
        Me.ol.Name = "ol"
        Me.ol.Size = New System.Drawing.Size(65, 16)
        Me.ol.TabIndex = 64
        Me.ol.Text = "Ol'dekop"
        Me.ol.UseVisualStyleBackColor = True
        '
        'sc
        '
        Me.sc.AutoSize = True
        Me.sc.Enabled = False
        Me.sc.Location = New System.Drawing.Point(20, 21)
        Me.sc.Name = "sc"
        Me.sc.Size = New System.Drawing.Size(67, 16)
        Me.sc.TabIndex = 63
        Me.sc.Text = "Schreiber"
        Me.sc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ha)
        Me.GroupBox1.Controls.Add(Me.ma)
        Me.GroupBox1.Controls.Add(Me.ho)
        Me.GroupBox1.Controls.Add(Me.th)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 146)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PET"
        '
        'Ha
        '
        Me.Ha.AutoSize = True
        Me.Ha.Location = New System.Drawing.Point(19, 111)
        Me.Ha.Name = "Ha"
        Me.Ha.Size = New System.Drawing.Size(57, 16)
        Me.Ha.TabIndex = 74
        Me.Ha.Text = "Hamon"
        Me.Ha.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.truc)
        Me.GroupBox3.Controls.Add(Me.bu)
        Me.GroupBox3.Controls.Add(Me.sc)
        Me.GroupBox3.Controls.Add(Me.fu)
        Me.GroupBox3.Controls.Add(Me.ol)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 166)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ET"
        '
        'truc
        '
        Me.truc.AutoSize = True
        Me.truc.Enabled = False
        Me.truc.Location = New System.Drawing.Point(20, 145)
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(43, 16)
        Me.truc.TabIndex = 67
        Me.truc.Text = "Pike"
        Me.truc.UseVisualStyleBackColor = True
        '
        'w
        '
        Me.w.BackColor = System.Drawing.SystemColors.Info
        Me.w.Location = New System.Drawing.Point(47, 402)
        Me.w.Name = "w"
        Me.w.ReadOnly = True
        Me.w.Size = New System.Drawing.Size(109, 22)
        Me.w.TabIndex = 69
        Me.w.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.w.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 12)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "w"
        Me.Label2.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(47, 430)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 10
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(115, 45)
        Me.TrackBar1.TabIndex = 71
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.Value = 10
        Me.TrackBar1.Visible = False
        '
        'Result
        '
        Me.Result.Enabled = False
        Me.Result.Location = New System.Drawing.Point(33, 479)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(148, 23)
        Me.Result.TabIndex = 72
        Me.Result.Text = "Show Result"
        Me.Result.UseVisualStyleBackColor = True
        Me.Result.Visible = False
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.SaddleBrown
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(201, 38)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(55, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(800, 600)
        Me.Chart1.TabIndex = 73
        Me.Chart1.Text = "Chart1"
        '
        'Camera
        '
        Me.Camera.Enabled = False
        Me.Camera.Image = CType(resources.GetObject("Camera.Image"), System.Drawing.Image)
        Me.Camera.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Camera.Location = New System.Drawing.Point(968, 39)
        Me.Camera.Name = "Camera"
        Me.Camera.Size = New System.Drawing.Size(33, 34)
        Me.Camera.TabIndex = 75
        Me.Camera.UseVisualStyleBackColor = True
        '
        'PETyc
        '
        Me.PETyc.BackColor = System.Drawing.SystemColors.Info
        Me.PETyc.DecimalPlaces = 2
        Me.PETyc.Enabled = False
        Me.PETyc.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PETyc.Location = New System.Drawing.Point(56, 159)
        Me.PETyc.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PETyc.Name = "PETyc"
        Me.PETyc.Size = New System.Drawing.Size(95, 22)
        Me.PETyc.TabIndex = 78
        Me.PETyc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBar4
        '
        Me.TrackBar4.Enabled = False
        Me.TrackBar4.Location = New System.Drawing.Point(51, 182)
        Me.TrackBar4.Maximum = 100
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar4.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar4.TabIndex = 77
        Me.TrackBar4.TickFrequency = 10
        Me.TrackBar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1010, 647)
        Me.Controls.Add(Me.PETyc)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.Camera)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.w)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.X_Yplot)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox6)
        Me.Name = "Form5"
        Me.Text = "Annual  Evapotranspiration Formula"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETyc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents X_Yplot As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ho As System.Windows.Forms.RadioButton
    Friend WithEvents ma As System.Windows.Forms.RadioButton
    Friend WithEvents th As System.Windows.Forms.RadioButton
    Friend WithEvents fu As System.Windows.Forms.RadioButton
    Friend WithEvents bu As System.Windows.Forms.RadioButton
    Friend WithEvents ol As System.Windows.Forms.RadioButton
    Friend WithEvents sc As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents w As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Result As System.Windows.Forms.Button
    Friend WithEvents truc As System.Windows.Forms.RadioButton
    Friend WithEvents Ha As System.Windows.Forms.RadioButton
    Friend WithEvents Camera As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PETyc As System.Windows.Forms.NumericUpDown
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
End Class
