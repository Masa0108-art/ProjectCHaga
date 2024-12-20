Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Windows.Win32.System
Public Class Sansyou
    Dim connString As String = "Server=LocalHost; DataBase=ProjectC; User ID = root; Password=root; Pooling=true "
    Dim conn As New MySqlConnection(connString)
    Dim currentpage As Integer = 1
    Dim rowperpage As Integer = 10
    Dim count As Integer
    Dim maxpage As Integer



    'gridviewに表示するためのメソッド
    Private Sub RoadGrid()

        '1つめのストアドプロシージャ
        Dim command As New MySqlCommand()
        command.Connection = conn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CustomerAll"
        command.Parameters.AddWithValue("@pageNumber", currentpage)
        command.Parameters.AddWithValue("@PageSize", rowperpage)

        If Radio1.Checked Then
            command.Parameters.AddWithValue("@d", "desc")
        ElseIf Radio2.Checked Then
            command.Parameters.AddWithValue("@d", "asc")
        Else
            command.Parameters.AddWithValue("d", "asc")
        End If

        Dim com As New DataSet
        Dim adapter As New MySqlDataAdapter(command)
        adapter.SelectCommand = command
        adapter.Fill(com)
        DataGridView1.DataSource = com.Tables(1)
        count = com.Tables(0).Rows(0)(0)
        maxpage = Math.Ceiling(count / rowperpage)

    End Sub


    'メイン画面へ戻る戻るボタン
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    '検索ボタン
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Kensaku.ShowDialog()
    End Sub

    '次へ
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If currentpage < maxpage Then
            currentpage += 1
        End If
        Call RoadGrid()
    End Sub

    '前へ
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If currentpage > 1 Then
            currentpage -= 1
        End If
        Call RoadGrid()
    End Sub

    Private Sub Sansyou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoadGrid()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Radio1.CheckedChanged
        RoadGrid()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Radio2.CheckedChanged
        RoadGrid()
    End Sub
End Class