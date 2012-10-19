<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CloseBut = New System.Windows.Forms.PictureBox()
        Me.no_i = New System.Windows.Forms.PictureBox()
        Me.Play = New System.Windows.Forms.PictureBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.bg = New System.Windows.Forms.PictureBox()
        Me.ServerStatus = New System.Windows.Forms.PictureBox()
        Me.debug_button = New System.Windows.Forms.PictureBox()
        CType(Me.CloseBut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.no_i, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.debug_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'CloseBut
        '
        Me.CloseBut.Image = Global.OpenSourceLauncher.My.Resources.Resources.x_root
        Me.CloseBut.Location = New System.Drawing.Point(415, 78)
        Me.CloseBut.Name = "CloseBut"
        Me.CloseBut.Size = New System.Drawing.Size(24, 24)
        Me.CloseBut.TabIndex = 4
        Me.CloseBut.TabStop = False
        '
        'no_i
        '
        Me.no_i.Image = Global.OpenSourceLauncher.My.Resources.Resources.no_i
        Me.no_i.Location = New System.Drawing.Point(53, 92)
        Me.no_i.Name = "no_i"
        Me.no_i.Size = New System.Drawing.Size(361, 527)
        Me.no_i.TabIndex = 3
        Me.no_i.TabStop = False
        Me.no_i.Visible = False
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Transparent
        Me.Play.Image = Global.OpenSourceLauncher.My.Resources.Resources.play_root
        Me.Play.Location = New System.Drawing.Point(75, 641)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(322, 63)
        Me.Play.TabIndex = 2
        Me.Play.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(53, 92)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(361, 527)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://launcher.rp-w.de/1", System.UriKind.Absolute)
        '
        'bg
        '
        Me.bg.BackColor = System.Drawing.Color.Transparent
        Me.bg.BackgroundImage = Global.OpenSourceLauncher.My.Resources.Resources.bg1
        Me.bg.Location = New System.Drawing.Point(2, 9)
        Me.bg.Name = "bg"
        Me.bg.Size = New System.Drawing.Size(465, 766)
        Me.bg.TabIndex = 0
        Me.bg.TabStop = False
        '
        'ServerStatus
        '
        Me.ServerStatus.BackColor = System.Drawing.Color.Black
        Me.ServerStatus.BackgroundImage = Global.OpenSourceLauncher.My.Resources.Resources.server_off
        Me.ServerStatus.Location = New System.Drawing.Point(165, 9)
        Me.ServerStatus.Name = "ServerStatus"
        Me.ServerStatus.Size = New System.Drawing.Size(139, 90)
        Me.ServerStatus.TabIndex = 5
        Me.ServerStatus.TabStop = False
        '
        'debug_button
        '
        Me.debug_button.BackColor = System.Drawing.Color.Black
        Me.debug_button.Image = Global.OpenSourceLauncher.My.Resources.Resources.debug
        Me.debug_button.Location = New System.Drawing.Point(400, 33)
        Me.debug_button.Name = "debug_button"
        Me.debug_button.Size = New System.Drawing.Size(39, 39)
        Me.debug_button.TabIndex = 6
        Me.debug_button.TabStop = False
        Me.debug_button.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(465, 800)
        Me.Controls.Add(Me.debug_button)
        Me.Controls.Add(Me.ServerStatus)
        Me.Controls.Add(Me.CloseBut)
        Me.Controls.Add(Me.no_i)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.bg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CloseBut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.no_i, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.debug_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bg As System.Windows.Forms.PictureBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Play As System.Windows.Forms.PictureBox
    Friend WithEvents no_i As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents CloseBut As System.Windows.Forms.PictureBox
    Friend WithEvents ServerStatus As System.Windows.Forms.PictureBox
    Friend WithEvents debug_button As System.Windows.Forms.PictureBox

End Class
