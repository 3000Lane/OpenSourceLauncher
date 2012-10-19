<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ssd_button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ssd_port = New System.Windows.Forms.TextBox()
        Me.ssd_ip = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.g_start = New System.Windows.Forms.Button()
        Me.g_realmlist = New System.Windows.Forms.Button()
        Me.g_clear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tr_port = New System.Windows.Forms.TextBox()
        Me.tr_ip = New System.Windows.Forms.TextBox()
        Me.tr_set = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssd_button
        '
        Me.ssd_button.Location = New System.Drawing.Point(253, 71)
        Me.ssd_button.Name = "ssd_button"
        Me.ssd_button.Size = New System.Drawing.Size(75, 23)
        Me.ssd_button.TabIndex = 0
        Me.ssd_button.Text = "Debug"
        Me.ssd_button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ssd_port)
        Me.GroupBox1.Controls.Add(Me.ssd_ip)
        Me.GroupBox1.Controls.Add(Me.ssd_button)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server Status Debug"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serv. Port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server IP"
        '
        'ssd_port
        '
        Me.ssd_port.Location = New System.Drawing.Point(58, 45)
        Me.ssd_port.Name = "ssd_port"
        Me.ssd_port.Size = New System.Drawing.Size(270, 20)
        Me.ssd_port.TabIndex = 3
        '
        'ssd_ip
        '
        Me.ssd_ip.Location = New System.Drawing.Point(58, 19)
        Me.ssd_ip.Name = "ssd_ip"
        Me.ssd_ip.Size = New System.Drawing.Size(270, 20)
        Me.ssd_ip.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.g_start)
        Me.GroupBox2.Controls.Add(Me.g_realmlist)
        Me.GroupBox2.Controls.Add(Me.g_clear)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Function Debug"
        '
        'g_start
        '
        Me.g_start.Location = New System.Drawing.Point(124, 19)
        Me.g_start.Name = "g_start"
        Me.g_start.Size = New System.Drawing.Size(75, 23)
        Me.g_start.TabIndex = 3
        Me.g_start.Text = "Game Start"
        Me.g_start.UseVisualStyleBackColor = True
        '
        'g_realmlist
        '
        Me.g_realmlist.Location = New System.Drawing.Point(6, 19)
        Me.g_realmlist.Name = "g_realmlist"
        Me.g_realmlist.Size = New System.Drawing.Size(75, 23)
        Me.g_realmlist.TabIndex = 2
        Me.g_realmlist.Text = "Realmlist"
        Me.g_realmlist.UseVisualStyleBackColor = True
        '
        'g_clear
        '
        Me.g_clear.Location = New System.Drawing.Point(253, 19)
        Me.g_clear.Name = "g_clear"
        Me.g_clear.Size = New System.Drawing.Size(75, 23)
        Me.g_clear.TabIndex = 1
        Me.g_clear.Text = "Clear Game"
        Me.g_clear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tr_port)
        Me.GroupBox3.Controls.Add(Me.tr_ip)
        Me.GroupBox3.Controls.Add(Me.tr_set)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 48)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Set a temporary realmlist"
        '
        'tr_port
        '
        Me.tr_port.Location = New System.Drawing.Point(217, 16)
        Me.tr_port.Name = "tr_port"
        Me.tr_port.Size = New System.Drawing.Size(71, 20)
        Me.tr_port.TabIndex = 6
        Me.tr_port.Text = "8085"
        '
        'tr_ip
        '
        Me.tr_ip.Location = New System.Drawing.Point(6, 16)
        Me.tr_ip.Name = "tr_ip"
        Me.tr_ip.Size = New System.Drawing.Size(205, 20)
        Me.tr_ip.TabIndex = 5
        Me.tr_ip.Text = "IP"
        '
        'tr_set
        '
        Me.tr_set.Location = New System.Drawing.Point(294, 14)
        Me.tr_set.Name = "tr_set"
        Me.tr_set.Size = New System.Drawing.Size(34, 23)
        Me.tr_set.TabIndex = 0
        Me.tr_set.Text = "Set"
        Me.tr_set.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 249)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.Text = "Debug"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ssd_button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ssd_port As System.Windows.Forms.TextBox
    Friend WithEvents ssd_ip As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents g_start As System.Windows.Forms.Button
    Friend WithEvents g_realmlist As System.Windows.Forms.Button
    Friend WithEvents g_clear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tr_port As System.Windows.Forms.TextBox
    Friend WithEvents tr_ip As System.Windows.Forms.TextBox
    Friend WithEvents tr_set As System.Windows.Forms.Button
End Class
