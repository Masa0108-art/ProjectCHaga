Public Class Form1

    '顧客フォーム
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Touroku.Click
        Touroku.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Sansyou.Click
        Sansyou.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        MessageBox.Show("アプリを終了します")
        Me.Close()
    End Sub
End Class
