Imports System.IO
Imports System.Net
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.Xml
Imports System.Net.Sockets
Public Class Form1
    Public launcher_url As String = "http://launcher.rp-w.de/1" 'The page url
    Public realmlist As String = "youtube.com" 'You're server realmlist
    Public server_port As Integer = 8085 ' You´re worldserver port
    Public game_local As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        debug_mode()

        style_load()
        browser_load()
        clear_game()
        server_check()
    End Sub

#Region "Browser Script"
    Private Sub browser_load()
        WebBrowser1.Navigate(launcher_url)
        IsAvailable()
    End Sub
    Private Sub IsAvailable()
        If Not My.Computer.Network.IsAvailable Then
            WebBrowser1.Visible = False
            no_i.Visible = True
            blablabla()
        End If
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)
    End Sub
    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        Dim sURL As String = e.Url.AbsoluteUri.ToString
        If Not e.Url.Host.ToString = "launcher.rp-w.de" Then
            e.Cancel = True
            Process.Start(sURL)
        End If
    End Sub

    Private Sub blablabla()
        'Eastern Egg don`t remove !
        My.Computer.Audio.Play(My.Resources.Bla_Bla_Bla, AudioPlayMode.Background)
    End Sub


#End Region
#Region "Game Script"
    Private Sub Play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Play.Click
        Game_Start()
    End Sub

    Public Sub Game_Start()
        Dim game As New Process()

        Me.WindowState = FormWindowState.Minimized
        MessageBox.Show("Deine Realmlist wurde temporäre auf: " + realmlist + " gesetzt.", "Realmlist änderung", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Realmlist_Change()
        game.StartInfo.FileName = "Wow.exe"
        game.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        game.Start()
        game.WaitForExit()
        game.Close()
        If MessageBox.Show("Deine Realmlist wurde wieder auf ihren alten Zustand zurückgesetzt ! Soll der Launcher jetzt beendet werden ?", "Realmlist änderung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Realmlist_Change()
            Me.Close()
        Else
            Me.WindowState = FormWindowState.Normal
            Realmlist_Change()
            clear_game()
        End If
    End Sub

    Public Sub clear_game()
        Local_Check()
        Dim Realmlist_path = "Data/" + game_local
        If File.Exists(Realmlist_path + "/realmlist.wtf.old") Then
            File.Delete(Realmlist_path + "/realmlist.wtf")
            File.Copy(Realmlist_path + "/realmlist.wtf.old", Realmlist_path + "/realmlist.wtf")
            File.Delete(Realmlist_path + "/realmlist.wtf.old")
        End If
        If Directory.Exists("Cache") Then
            Directory.Delete("Cache", True)
            Directory.CreateDirectory("Cache")
        End If
    End Sub

    Public Sub Realmlist_Change()
        Local_Check()
        Dim Realmlist_path = "Data/" + game_local
        If File.Exists(Realmlist_path + "/realmlist.wtf.old") Then
            File.Delete(Realmlist_path + "/realmlist.wtf")
            File.Copy(Realmlist_path + "/realmlist.wtf.old", Realmlist_path + "/realmlist.wtf")
            File.Delete(Realmlist_path + "/realmlist.wtf.old")
        ElseIf File.Exists(Realmlist_path + "/realmlist.wtf") Then
            File.Copy(Realmlist_path + "/realmlist.wtf", Realmlist_path + "/realmlist.wtf.old")
            File.Delete(Realmlist_path + "/realmlist.wtf")
            File.WriteAllText(Realmlist_path + "/realmlist.wtf", "set realmlist " + realmlist)
        End If

    End Sub

    Private Sub Local_Check()
        If Directory.Exists("Data/deDE") Then
            game_local = "deDE"
        ElseIf Directory.Exists("Data/enUS") Then
            game_local = "enUS"
        ElseIf Directory.Exists("Data/enGB") Then
            game_local = "enGB"
        ElseIf Directory.Exists("Data/enTW") Then
            game_local = "enTW"
        ElseIf Directory.Exists("Data/esMX") Then
            game_local = "esMX"
        ElseIf Directory.Exists("Data/esES") Then
            game_local = "esES"
        ElseIf Directory.Exists("Data/frFR") Then
            game_local = "frFR"
        ElseIf Directory.Exists("Data/ruRU") Then
            game_local = "ruRU"
        ElseIf Directory.Exists("Data/ptBR") Then
            game_local = "ptBR"
        ElseIf Directory.Exists("Data/ptPT") Then
            game_local = "ptPT"
        ElseIf Directory.Exists("Data/koKR") Then
            game_local = "koKR"
        ElseIf Directory.Exists("Data/zhTW") Then
            game_local = "zhTW"
        Else
            MessageBox.Show("Bitte verschieben sie den Launcher in ihren World of Warcraft Hauptverzeichnis !", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If debug_mode_status = 0 Then Me.Close()
        End If

    End Sub

#End Region
#Region "Other Script"
    'Closebutton
    Private Sub CloseBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBut.Click
        clear_game()
        Me.Close()
    End Sub

    'Server Status Check
    Public Sub server_check()
        ServerStatus.BackgroundImage = My.Resources.server_off
        Dim TCPConnect As New TcpClient
        Dim IAR As IAsyncResult = TCPConnect.BeginConnect(realmlist, server_port, Nothing, Nothing)
        Dim WH As System.Threading.WaitHandle = IAR.AsyncWaitHandle
        Try
            If Not IAR.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1), False) Then
                TCPConnect.Close()
                Throw New TimeoutException()
            End If
            ServerStatus.BackgroundImage = My.Resources.server_on
            TCPConnect.EndConnect(IAR)
        Catch ex As Exception
            ServerStatus.BackgroundImage = My.Resources.server_off
        Finally
            WH.Close()
        End Try
    End Sub

    'Testing & Debugging Mode
    Public debug_mode_status As Integer
    Private Sub debug_mode()
        If MessageBox.Show("Der Debug Mode wurde im Quellcode aktiviert. Möchtest du diesen jetzt nutzen ?", "Debug Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            debug_button.Visible = True
            debug_mode_status = 1
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles debug_button.Click
        Form2.Show()
    End Sub
#End Region
#Region "Style"
    'No Background Color
    <StructLayout(LayoutKind.Sequential)>
    Public Structure MARGINS
        Public Right As Integer
        Public Left As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
    'No Background Color load
    Private Sub style_load()
        Dim margins As MARGINS = New MARGINS
        margins.Left = -1
        margins.Right = -1
        margins.Top = -1
        margins.Bottom = -1
        Dim hwnd As IntPtr = Handle

        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        Me.BackColor = Color.Black
        Icon_Set()
    End Sub

    Private Sub Icon_Set()
        Me.Icon = My.Resources.icon
        NotifyIcon1.Icon = My.Resources.icon
    End Sub

    Dim lStartPos As Point
    'Windows Move (MouseDown)
    Private Sub bg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bg.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lStartPos = e.Location
        End If
    End Sub
    'Windows Move (MoseMove)
    Private Sub bg_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bg.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim lDelta As New Point(e.Location.X - lStartPos.X, e.Location.Y - lStartPos.Y)
            Dim lNewPos = New Point(Me.Location.X + lDelta.X, Me.Location.Y + lDelta.Y)
            Me.Location = lNewPos
        End If
    End Sub
    'Windows Move (MouseDown)
    Private Sub ServerStatus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ServerStatus.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lStartPos = e.Location
        End If
    End Sub
    'Windows Move (MoseMove)
    Private Sub ServerStatus_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ServerStatus.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim lDelta As New Point(e.Location.X - lStartPos.X, e.Location.Y - lStartPos.Y)
            Dim lNewPos = New Point(Me.Location.X + lDelta.X, Me.Location.Y + lDelta.Y)
            Me.Location = lNewPos
        End If
    End Sub

    'Playbutton Style
    Private Sub Play_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Play.MouseHover
        Play.Image = My.Resources.play_active
    End Sub

    Private Sub Play_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Play.MouseLeave
        Play.Image = My.Resources.play_root
    End Sub

    'Closebutton Style
    Private Sub CloseBot_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseBut.MouseHover
        CloseBut.Image = My.Resources.x_active
    End Sub

    Private Sub CloseBot_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseBut.MouseLeave
        CloseBut.Image = My.Resources.x_root
    End Sub

    'SystemTray Notify
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            Me.WindowState = FormWindowState.Minimized
            Me.NotifyIcon1.Visible = True
        ElseIf Me.WindowState = FormWindowState.Normal Then
            style_load()
            WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)
            Me.ShowInTaskbar = True
            Me.NotifyIcon1.Visible = False
        End If
    End Sub
#End Region
End Class