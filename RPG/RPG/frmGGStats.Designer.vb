<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGGStats
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblHorV = New System.Windows.Forms.Label
        Me.lblVin = New System.Windows.Forms.Label
        Me.lblLovk = New System.Windows.Forms.Label
        Me.lblSila = New System.Windows.Forms.Label
        Me.lblStatHorV = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(130, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 182)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblHorV)
        Me.GroupBox1.Controls.Add(Me.lblVin)
        Me.GroupBox1.Controls.Add(Me.lblLovk)
        Me.GroupBox1.Controls.Add(Me.lblSila)
        Me.GroupBox1.Controls.Add(Me.lblStatHorV)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 134)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Характеристики"
        '
        'lblHorV
        '
        Me.lblHorV.BackColor = System.Drawing.Color.Transparent
        Me.lblHorV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHorV.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblHorV.Location = New System.Drawing.Point(153, 100)
        Me.lblHorV.Name = "lblHorV"
        Me.lblHorV.Size = New System.Drawing.Size(64, 26)
        Me.lblHorV.TabIndex = 14
        Me.lblHorV.Text = "0"
        Me.lblHorV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVin
        '
        Me.lblVin.BackColor = System.Drawing.Color.Transparent
        Me.lblVin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblVin.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblVin.Location = New System.Drawing.Point(153, 74)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(64, 26)
        Me.lblVin.TabIndex = 13
        Me.lblVin.Text = "0"
        Me.lblVin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLovk
        '
        Me.lblLovk.BackColor = System.Drawing.Color.Transparent
        Me.lblLovk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLovk.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLovk.Location = New System.Drawing.Point(153, 48)
        Me.lblLovk.Name = "lblLovk"
        Me.lblLovk.Size = New System.Drawing.Size(64, 26)
        Me.lblLovk.TabIndex = 12
        Me.lblLovk.Text = "0"
        Me.lblLovk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSila
        '
        Me.lblSila.BackColor = System.Drawing.Color.Transparent
        Me.lblSila.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSila.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblSila.Location = New System.Drawing.Point(153, 22)
        Me.lblSila.Name = "lblSila"
        Me.lblSila.Size = New System.Drawing.Size(64, 26)
        Me.lblSila.TabIndex = 11
        Me.lblSila.Text = "0"
        Me.lblSila.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatHorV
        '
        Me.lblStatHorV.BackColor = System.Drawing.Color.Transparent
        Me.lblStatHorV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatHorV.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblStatHorV.Location = New System.Drawing.Point(6, 100)
        Me.lblStatHorV.Name = "lblStatHorV"
        Me.lblStatHorV.Size = New System.Drawing.Size(118, 26)
        Me.lblStatHorV.TabIndex = 10
        Me.lblStatHorV.Text = "Хитрость \ Вера"
        Me.lblStatHorV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Выносливость"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ловкость"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Сила "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 248)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Способности"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 26)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Стойкость к алкоголю"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 26)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Выживание в стресовых ситуациях"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Владение холодным оружием"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(81, 462)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 28)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Назад"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.Location = New System.Drawing.Point(694, 462)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 28)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Далее"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox3.Location = New System.Drawing.Point(351, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 134)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Описание характеристик \ способностей"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic)
        Me.TextBox1.Location = New System.Drawing.Point(100, 257)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 24)
        Me.TextBox1.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(100, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(183, 26)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Имя персонажа"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGGStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RPG.My.Resources.Resources.orig
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(880, 531)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGGStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGGStats"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHorV As System.Windows.Forms.Label
    Friend WithEvents lblVin As System.Windows.Forms.Label
    Friend WithEvents lblLovk As System.Windows.Forms.Label
    Friend WithEvents lblSila As System.Windows.Forms.Label
    Friend WithEvents lblStatHorV As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
