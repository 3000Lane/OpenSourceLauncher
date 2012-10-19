Public Class Form2
    Private Sub ssd_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ssd_button.Click
        Form1.realmlist = ssd_ip.Text
        Form1.server_port = ssd_port.Text
        Form1.Server_Check()
    End Sub

    Private Sub g_realmlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g_realmlist.Click
        Form1.Realmlist_Change()
    End Sub

    Private Sub g_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g_start.Click
        Form1.Game_Start()
    End Sub

    Private Sub g_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g_clear.Click
        Form1.clear_game()
    End Sub

    Private Sub tr_set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tr_set.Click
        Form1.realmlist = tr_ip.Text
        Form1.server_port = tr_port.Text
    End Sub
End Class