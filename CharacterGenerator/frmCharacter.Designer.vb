<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnRandonName = New System.Windows.Forms.Button()
        Me.gbxStats = New System.Windows.Forms.GroupBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblCHA = New System.Windows.Forms.Label()
        Me.lblCHADescr = New System.Windows.Forms.Label()
        Me.lblCON = New System.Windows.Forms.Label()
        Me.lblCONDescr = New System.Windows.Forms.Label()
        Me.lblDEX = New System.Windows.Forms.Label()
        Me.lblDEXDescr = New System.Windows.Forms.Label()
        Me.lblWIS = New System.Windows.Forms.Label()
        Me.lblWISDescr = New System.Windows.Forms.Label()
        Me.lblINT = New System.Windows.Forms.Label()
        Me.lblINTDescr = New System.Windows.Forms.Label()
        Me.lblSTR = New System.Windows.Forms.Label()
        Me.lblSTRDescr = New System.Windows.Forms.Label()
        Me.cboRace = New System.Windows.Forms.ComboBox()
        Me.gbxStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 14)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Location = New System.Drawing.Point(16, 45)
        Me.lblRace.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(36, 13)
        Me.lblRace.TabIndex = 1
        Me.lblRace.Text = "Race:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 14)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(62, 20)
        Me.txtName.TabIndex = 2
        '
        'btnRandonName
        '
        Me.btnRandonName.ForeColor = System.Drawing.Color.Black
        Me.btnRandonName.Location = New System.Drawing.Point(150, 14)
        Me.btnRandonName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRandonName.Name = "btnRandonName"
        Me.btnRandonName.Size = New System.Drawing.Size(62, 23)
        Me.btnRandonName.TabIndex = 4
        Me.btnRandonName.Text = "Random"
        Me.btnRandonName.UseVisualStyleBackColor = True
        '
        'gbxStats
        '
        Me.gbxStats.Controls.Add(Me.btnGenerate)
        Me.gbxStats.Controls.Add(Me.lblCHA)
        Me.gbxStats.Controls.Add(Me.lblCHADescr)
        Me.gbxStats.Controls.Add(Me.lblCON)
        Me.gbxStats.Controls.Add(Me.lblCONDescr)
        Me.gbxStats.Controls.Add(Me.lblDEX)
        Me.gbxStats.Controls.Add(Me.lblDEXDescr)
        Me.gbxStats.Controls.Add(Me.lblWIS)
        Me.gbxStats.Controls.Add(Me.lblWISDescr)
        Me.gbxStats.Controls.Add(Me.lblINT)
        Me.gbxStats.Controls.Add(Me.lblINTDescr)
        Me.gbxStats.Controls.Add(Me.lblSTR)
        Me.gbxStats.Controls.Add(Me.lblSTRDescr)
        Me.gbxStats.Location = New System.Drawing.Point(26, 86)
        Me.gbxStats.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxStats.Name = "gbxStats"
        Me.gbxStats.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxStats.Size = New System.Drawing.Size(185, 158)
        Me.gbxStats.TabIndex = 5
        Me.gbxStats.TabStop = False
        Me.gbxStats.Text = "Stats"
        '
        'btnGenerate
        '
        Me.btnGenerate.ForeColor = System.Drawing.Color.Black
        Me.btnGenerate.Location = New System.Drawing.Point(96, 124)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(77, 22)
        Me.btnGenerate.TabIndex = 12
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblCHA
        '
        Me.lblCHA.AutoSize = True
        Me.lblCHA.Location = New System.Drawing.Point(60, 116)
        Me.lblCHA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCHA.Name = "lblCHA"
        Me.lblCHA.Size = New System.Drawing.Size(11, 13)
        Me.lblCHA.TabIndex = 11
        Me.lblCHA.Text = "*"
        '
        'lblCHADescr
        '
        Me.lblCHADescr.AutoSize = True
        Me.lblCHADescr.Location = New System.Drawing.Point(12, 116)
        Me.lblCHADescr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCHADescr.Name = "lblCHADescr"
        Me.lblCHADescr.Size = New System.Drawing.Size(29, 13)
        Me.lblCHADescr.TabIndex = 10
        Me.lblCHADescr.Text = "CHA"
        '
        'lblCON
        '
        Me.lblCON.AutoSize = True
        Me.lblCON.Location = New System.Drawing.Point(60, 95)
        Me.lblCON.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCON.Name = "lblCON"
        Me.lblCON.Size = New System.Drawing.Size(11, 13)
        Me.lblCON.TabIndex = 9
        Me.lblCON.Text = "*"
        '
        'lblCONDescr
        '
        Me.lblCONDescr.AutoSize = True
        Me.lblCONDescr.Location = New System.Drawing.Point(12, 95)
        Me.lblCONDescr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCONDescr.Name = "lblCONDescr"
        Me.lblCONDescr.Size = New System.Drawing.Size(30, 13)
        Me.lblCONDescr.TabIndex = 8
        Me.lblCONDescr.Text = "CON"
        '
        'lblDEX
        '
        Me.lblDEX.AutoSize = True
        Me.lblDEX.Location = New System.Drawing.Point(60, 76)
        Me.lblDEX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDEX.Name = "lblDEX"
        Me.lblDEX.Size = New System.Drawing.Size(11, 13)
        Me.lblDEX.TabIndex = 7
        Me.lblDEX.Text = "*"
        '
        'lblDEXDescr
        '
        Me.lblDEXDescr.AutoSize = True
        Me.lblDEXDescr.Location = New System.Drawing.Point(12, 76)
        Me.lblDEXDescr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDEXDescr.Name = "lblDEXDescr"
        Me.lblDEXDescr.Size = New System.Drawing.Size(29, 13)
        Me.lblDEXDescr.TabIndex = 6
        Me.lblDEXDescr.Text = "DEX"
        '
        'lblWIS
        '
        Me.lblWIS.AutoSize = True
        Me.lblWIS.Location = New System.Drawing.Point(60, 57)
        Me.lblWIS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWIS.Name = "lblWIS"
        Me.lblWIS.Size = New System.Drawing.Size(11, 13)
        Me.lblWIS.TabIndex = 5
        Me.lblWIS.Text = "*"
        '
        'lblWISDescr
        '
        Me.lblWISDescr.AutoSize = True
        Me.lblWISDescr.Location = New System.Drawing.Point(12, 57)
        Me.lblWISDescr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWISDescr.Name = "lblWISDescr"
        Me.lblWISDescr.Size = New System.Drawing.Size(28, 13)
        Me.lblWISDescr.TabIndex = 4
        Me.lblWISDescr.Text = "WIS"
        '
        'lblINT
        '
        Me.lblINT.AutoSize = True
        Me.lblINT.Location = New System.Drawing.Point(60, 39)
        Me.lblINT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblINT.Name = "lblINT"
        Me.lblINT.Size = New System.Drawing.Size(11, 13)
        Me.lblINT.TabIndex = 3
        Me.lblINT.Text = "*"
        '
        'lblINTDescr
        '
        Me.lblINTDescr.AutoSize = True
        Me.lblINTDescr.Location = New System.Drawing.Point(12, 39)
        Me.lblINTDescr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblINTDescr.Name = "lblINTDescr"
        Me.lblINTDescr.Size = New System.Drawing.Size(25, 13)
        Me.lblINTDescr.TabIndex = 2
        Me.lblINTDescr.Text = "INT"
        '
        'lblSTR
        '
        Me.lblSTR.AutoSize = True
        Me.lblSTR.Location = New System.Drawing.Point(60, 21)
        Me.lblSTR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSTR.Name = "lblSTR"
        Me.lblSTR.Size = New System.Drawing.Size(11, 13)
        Me.lblSTR.TabIndex = 1
        Me.lblSTR.Text = "*"
        '
        'lblSTRDescr
        '
        Me.lblSTRDescr.AutoSize = True
        Me.lblSTRDescr.Location = New System.Drawing.Point(12, 21)
        Me.lblSTRDescr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSTRDescr.Name = "lblSTRDescr"
        Me.lblSTRDescr.Size = New System.Drawing.Size(29, 13)
        Me.lblSTRDescr.TabIndex = 0
        Me.lblSTRDescr.Text = "STR"
        '
        'cboRace
        '
        Me.cboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRace.FormattingEnabled = True
        Me.cboRace.Location = New System.Drawing.Point(70, 45)
        Me.cboRace.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboRace.Name = "cboRace"
        Me.cboRace.Size = New System.Drawing.Size(62, 21)
        Me.cboRace.TabIndex = 2
        '
        'frmCharacter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(226, 279)
        Me.Controls.Add(Me.cboRace)
        Me.Controls.Add(Me.gbxStats)
        Me.Controls.Add(Me.btnRandonName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.lblName)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCharacter"
        Me.Text = "Character Generator"
        Me.gbxStats.ResumeLayout(False)
        Me.gbxStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblRace As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnRandonName As Button
    Friend WithEvents gbxStats As GroupBox
    Friend WithEvents lblCHA As Label
    Friend WithEvents lblCHADescr As Label
    Friend WithEvents lblCON As Label
    Friend WithEvents lblCONDescr As Label
    Friend WithEvents lblDEX As Label
    Friend WithEvents lblDEXDescr As Label
    Friend WithEvents lblWIS As Label
    Friend WithEvents lblWISDescr As Label
    Friend WithEvents lblINT As Label
    Friend WithEvents lblINTDescr As Label
    Friend WithEvents lblSTR As Label
    Friend WithEvents lblSTRDescr As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents cboRace As ComboBox
End Class
