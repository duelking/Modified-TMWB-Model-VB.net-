<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PETc = New System.Windows.Forms.NumericUpDown()
        Me.soilmax = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.kk = New System.Windows.Forms.NumericUpDown()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.corr = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Camera = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PETc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.soilmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(12, 474)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Show Result"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(541, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Input"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LimeGreen
        Me.TextBox1.Location = New System.Drawing.Point(185, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(347, 22)
        Me.TextBox1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 12)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Max. S.M.C. (mm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 12)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Recession Const.(1/mo)"
        '
        'TrackBar1
        '
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Location = New System.Drawing.Point(28, 79)
        Me.TrackBar1.Maximum = 1500
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 24
        Me.TrackBar1.TickFrequency = 100
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PETc)
        Me.GroupBox1.Controls.Add(Me.soilmax)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.kk)
        Me.GroupBox1.Controls.Add(Me.TrackBar4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TrackBar3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 379)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameter"
        '
        'PETc
        '
        Me.PETc.BackColor = System.Drawing.SystemColors.Info
        Me.PETc.DecimalPlaces = 2
        Me.PETc.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PETc.Location = New System.Drawing.Point(33, 309)
        Me.PETc.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PETc.Name = "PETc"
        Me.PETc.Size = New System.Drawing.Size(95, 22)
        Me.PETc.TabIndex = 42
        Me.PETc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'soilmax
        '
        Me.soilmax.BackColor = System.Drawing.SystemColors.Info
        Me.soilmax.Location = New System.Drawing.Point(32, 52)
        Me.soilmax.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.soilmax.Name = "soilmax"
        Me.soilmax.Size = New System.Drawing.Size(95, 22)
        Me.soilmax.TabIndex = 41
        Me.soilmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Info
        Me.NumericUpDown1.Location = New System.Drawing.Point(33, 222)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(95, 22)
        Me.NumericUpDown1.TabIndex = 40
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kk
        '
        Me.kk.BackColor = System.Drawing.SystemColors.Info
        Me.kk.DecimalPlaces = 2
        Me.kk.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.kk.Location = New System.Drawing.Point(33, 154)
        Me.kk.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.kk.Name = "kk"
        Me.kk.Size = New System.Drawing.Size(95, 22)
        Me.kk.TabIndex = 39
        Me.kk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(28, 332)
        Me.TrackBar4.Maximum = 100
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrackBar4.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar4.TabIndex = 35
        Me.TrackBar4.TickFrequency = 10
        Me.TrackBar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 12)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "PET Coefficient"
        '
        'TrackBar3
        '
        Me.TrackBar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar3.Location = New System.Drawing.Point(28, 247)
        Me.TrackBar3.Maximum = 1500
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar3.TabIndex = 29
        Me.TrackBar3.TickFrequency = 100
        Me.TrackBar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 12)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Max. A.S.C. (mm)"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox6.Location = New System.Drawing.Point(622, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(285, 22)
        Me.TextBox6.TabIndex = 27
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(913, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 23)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Obs."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Location = New System.Drawing.Point(44, 61)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(96, 23)
        Me.Button10.TabIndex = 32
        Me.Button10.Text = "Compute"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 12)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 12)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "E(%):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "RMSE(mm/mo):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 12)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Label6"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(26, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 58)
        Me.Panel1.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 12)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "R^2:"
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 528)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(156, 107)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accurary Indices"
        Me.GroupBox2.Visible = False
        '
        'corr
        '
        Me.corr.Location = New System.Drawing.Point(52, 503)
        Me.corr.Name = "corr"
        Me.corr.Size = New System.Drawing.Size(75, 23)
        Me.corr.TabIndex = 42
        Me.corr.Text = "X-Y Plot"
        Me.corr.UseMnemonic = False
        Me.corr.UseVisualStyleBackColor = True
        Me.corr.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(44, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Annual ET Eq."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(39, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 20)
        Me.ComboBox1.TabIndex = 44
        Me.ComboBox1.Text = "     Select PET Eq."
        '
        'Chart1
        '
        ChartArea2.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Alignment = System.Drawing.StringAlignment.Center
        Legend2.BackColor = System.Drawing.Color.White
        Legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.DarkRed
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Legend2.TextWrapThreshold = 0
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(185, 35)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(800, 600)
        Me.Chart1.TabIndex = 45
        Me.Chart1.Text = "Chart1"
        '
        'Camera
        '
        Me.Camera.Enabled = False
        Me.Camera.Image = CType(resources.GetObject("Camera.Image"), System.Drawing.Image)
        Me.Camera.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Camera.Location = New System.Drawing.Point(952, 33)
        Me.Camera.Name = "Camera"
        Me.Camera.Size = New System.Drawing.Size(33, 34)
        Me.Camera.TabIndex = 76
        Me.Camera.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1000, 647)
        Me.Controls.Add(Me.Camera)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.corr)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Thornthwaite-Mather Model"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PETc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.soilmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents corr As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
    Friend WithEvents kk As System.Windows.Forms.NumericUpDown
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Camera As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents soilmax As System.Windows.Forms.NumericUpDown
    Friend WithEvents PETc As System.Windows.Forms.NumericUpDown

End Class
